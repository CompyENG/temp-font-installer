using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace temp_font_installer
{
    public partial class Form1 : Form
    {
        private static IntPtr HWND_BROADCAST = new IntPtr(0xffff);

        [DllImport("gdi32.dll")]
        static extern int AddFontResource(string lpszFilename);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool PostMessage(IntPtr hWnd, WindowMessages Msg, IntPtr wParam, IntPtr lParam);

        string APP_DATA = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "temp-font-installer");

        PrivateFontCollection fonts;
        
        public Form1()
        {
            InitializeComponent();

            if(!Directory.Exists(APP_DATA)) {
                Directory.CreateDirectory(APP_DATA);
            }

            fonts = new PrivateFontCollection();
        }

        private void btnAddFont_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgAddFont.ShowDialog();
            if (result == DialogResult.OK)
            {
                addFonts(dlgAddFont.FileNames);
            }
        }

        public void addFonts(string[] filePaths)
        {
            foreach (string fileName in filePaths)
            {
                //Console.WriteLine(fileName);
                //Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                FileInfo info = new FileInfo(fileName);

                // If the font list already contains this font, just skip it
                // TODO: This will only check file name. It would be nice if we 
                //  could either open the font file and check font name, or exclude
                //  extension from the check, so that you can't add an OTF and TTF of
                //  the same font, for example.
                // TODO: If we *do* detect a duplicate? Perhaps show a dialog asking the
                //  user what we should do?
                if (listFonts.FindItemWithText(info.Name) != null) continue;

                try
                {
                    File.Copy(fileName,
                        Path.Combine(APP_DATA, info.Name),
                        true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occured: " + ex.ToString());
                    MessageBox.Show(String.Format("Error copying {0} into fonts directory.", fileName), "Error copying file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PrivateFontCollection tempCollection = new PrivateFontCollection();
                tempCollection.AddFontFile(Path.Combine(APP_DATA, info.Name));
                fonts.AddFontFile(Path.Combine(APP_DATA, info.Name));

                // Create the new item to add to the list
                ListViewItem newItem = new ListViewItem(tempCollection.Families[0].Name);
                newItem.Checked = true;
                newItem.Font = new Font(tempCollection.Families[0], 12);
                listFonts.Items.Add(newItem);

                tempCollection.Dispose();
            }
        }

        private void btnInstallNow_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem i in listFonts.CheckedItems)
            {
                AddFontResource(Path.Combine(APP_DATA, i.Text));
                count++;
                statusProgress.Value = (int)(((float)count) / ((float)listFonts.CheckedItems.Count) * 95.0);
                statusPercent.Text = String.Format("{0:0%}", (float)statusProgress.Value/100.0);
            }

            bool posted = PostMessage(HWND_BROADCAST, WindowMessages.FONTCHANGE, IntPtr.Zero, IntPtr.Zero);
            if (!posted)
            {
                Console.WriteLine("New error: " + Marshal.GetLastWin32Error());
                statusProgress.Value = 0;
                statusPercent.Text = String.Format("{0:0%}", (float)statusProgress.Value / 100.0);
            }
            else
            {
                statusProgress.Value = 100;
                statusPercent.Text = String.Format("{0:0%}", (float)statusProgress.Value / 100.0);
            }
        }
    }
}
