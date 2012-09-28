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
            this.listFonts = new System.Windows.Forms.ListView();
            this.colHeadFilname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFont = new System.Windows.Forms.Button();
            this.btnInstallNow = new System.Windows.Forms.Button();
            this.dlgAddFont = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFonts
            // 
            this.listFonts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFonts.CheckBoxes = true;
            this.listFonts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadFilname});
            this.listFonts.GridLines = true;
            this.listFonts.HideSelection = false;
            this.listFonts.Location = new System.Drawing.Point(12, 12);
            this.listFonts.Name = "listFonts";
            this.listFonts.Size = new System.Drawing.Size(324, 154);
            this.listFonts.TabIndex = 0;
            this.listFonts.UseCompatibleStateImageBehavior = false;
            this.listFonts.View = System.Windows.Forms.View.Details;
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
            this.btnInstallNow.Click += new System.EventHandler(this.btnInstallNow_Click);
            // 
            // dlgAddFont
            // 
            this.dlgAddFont.Filter = "Font Files|*.ttf;*.otf";
            this.dlgAddFont.Multiselect = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgress,
            this.statusPercent});
            this.statusStrip1.Location = new System.Drawing.Point(0, 207);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(349, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusPercent
            // 
            this.statusPercent.Name = "statusPercent";
            this.statusPercent.Size = new System.Drawing.Size(0, 17);
            this.statusPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusProgress
            // 
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(100, 16);
            this.statusProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 229);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnInstallNow);
            this.Controls.Add(this.btnAddFont);
            this.Controls.Add(this.listFonts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listFonts;
        private System.Windows.Forms.ColumnHeader colHeadFilname;
        private System.Windows.Forms.Button btnAddFont;
        private System.Windows.Forms.Button btnInstallNow;
        private System.Windows.Forms.OpenFileDialog dlgAddFont;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusPercent;

    }
}

