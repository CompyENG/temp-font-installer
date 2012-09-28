using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace temp_font_installer
{
    public partial class Form1 : Form
    {
        string APP_DATA = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "temp-font-installer");
        public Form1()
        {
            InitializeComponent();

            if(!Directory.Exists(APP_DATA)) {
                Directory.CreateDirectory(APP_DATA);
            }
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

                // Create the new item to add to the list
                ListViewItem newItem = new ListViewItem(info.Name);
                newItem.Checked = true;
                listFonts.Items.Add(newItem);
            }
        }

        private void btnInstallNow_Click(object sender, EventArgs e)
        {

        }
    }
}
