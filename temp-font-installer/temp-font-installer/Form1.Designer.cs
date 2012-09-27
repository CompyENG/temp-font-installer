namespace temp_font_installer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Test-font.ttf");
            this.listView1 = new System.Windows.Forms.ListView();
            this.colHeadFilname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFont = new System.Windows.Forms.Button();
            this.btnInstallNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadFilname});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 154);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colHeadFilname
            // 
            this.colHeadFilname.Text = "Font Filename";
            this.colHeadFilname.Width = 315;
            // 
            // btnAddFont
            // 
            this.btnAddFont.Location = new System.Drawing.Point(13, 172);
            this.btnAddFont.Name = "btnAddFont";
            this.btnAddFont.Size = new System.Drawing.Size(102, 23);
            this.btnAddFont.TabIndex = 1;
            this.btnAddFont.Text = "Add a Font";
            this.btnAddFont.UseVisualStyleBackColor = true;
            this.btnAddFont.Click += new System.EventHandler(this.btnAddFont_Click);
            // 
            // btnInstallNow
            // 
            this.btnInstallNow.Location = new System.Drawing.Point(209, 171);
            this.btnInstallNow.Name = "btnInstallNow";
            this.btnInstallNow.Size = new System.Drawing.Size(126, 23);
            this.btnInstallNow.TabIndex = 2;
            this.btnInstallNow.Text = "Install Fonts Now";
            this.btnInstallNow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 206);
            this.Controls.Add(this.btnInstallNow);
            this.Controls.Add(this.btnAddFont);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colHeadFilname;
        private System.Windows.Forms.Button btnAddFont;
        private System.Windows.Forms.Button btnInstallNow;

    }
}

