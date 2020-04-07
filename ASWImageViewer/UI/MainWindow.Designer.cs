namespace ASWImageViewer.UI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertCurrentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchConvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texturePicBox = new System.Windows.Forms.PictureBox();
            this.fileAttributesGroupBox = new System.Windows.Forms.GroupBox();
            this.attributeTextBox = new System.Windows.Forms.TextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.convertPAKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchConvertPAKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texturePicBox)).BeginInit();
            this.fileAttributesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(585, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.closeFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeFileToolStripMenuItem.Text = "Close File";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.CloseFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertCurrentFileToolStripMenuItem,
            this.batchConvertToolStripMenuItem,
            this.toolStripMenuItem2,
            this.convertPAKToolStripMenuItem,
            this.batchConvertPAKToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.convertToolStripMenuItem.Text = "Tools";
            // 
            // convertCurrentFileToolStripMenuItem
            // 
            this.convertCurrentFileToolStripMenuItem.Name = "convertCurrentFileToolStripMenuItem";
            this.convertCurrentFileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.convertCurrentFileToolStripMenuItem.Text = "Convert Current MIB";
            this.convertCurrentFileToolStripMenuItem.Click += new System.EventHandler(this.ConvertCurrentFileToolStripMenuItem_Click);
            // 
            // batchConvertToolStripMenuItem
            // 
            this.batchConvertToolStripMenuItem.Name = "batchConvertToolStripMenuItem";
            this.batchConvertToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.batchConvertToolStripMenuItem.Text = "Batch Convert MIB";
            this.batchConvertToolStripMenuItem.Click += new System.EventHandler(this.BatchConvertToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // texturePicBox
            // 
            this.texturePicBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.texturePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texturePicBox.Location = new System.Drawing.Point(248, 32);
            this.texturePicBox.Name = "texturePicBox";
            this.texturePicBox.Size = new System.Drawing.Size(328, 320);
            this.texturePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.texturePicBox.TabIndex = 1;
            this.texturePicBox.TabStop = false;
            // 
            // fileAttributesGroupBox
            // 
            this.fileAttributesGroupBox.Controls.Add(this.attributeTextBox);
            this.fileAttributesGroupBox.Location = new System.Drawing.Point(8, 32);
            this.fileAttributesGroupBox.Name = "fileAttributesGroupBox";
            this.fileAttributesGroupBox.Size = new System.Drawing.Size(232, 320);
            this.fileAttributesGroupBox.TabIndex = 2;
            this.fileAttributesGroupBox.TabStop = false;
            this.fileAttributesGroupBox.Text = "File Information";
            // 
            // attributeTextBox
            // 
            this.attributeTextBox.Location = new System.Drawing.Point(16, 24);
            this.attributeTextBox.Multiline = true;
            this.attributeTextBox.Name = "attributeTextBox";
            this.attributeTextBox.ReadOnly = true;
            this.attributeTextBox.Size = new System.Drawing.Size(200, 280);
            this.attributeTextBox.TabIndex = 0;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 6);
            // 
            // convertPAKToolStripMenuItem
            // 
            this.convertPAKToolStripMenuItem.Name = "convertPAKToolStripMenuItem";
            this.convertPAKToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.convertPAKToolStripMenuItem.Text = "Extract PAK";
            this.convertPAKToolStripMenuItem.Click += new System.EventHandler(this.ConvertPAKToolStripMenuItem_Click);
            // 
            // batchConvertPAKToolStripMenuItem
            // 
            this.batchConvertPAKToolStripMenuItem.Name = "batchConvertPAKToolStripMenuItem";
            this.batchConvertPAKToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.batchConvertPAKToolStripMenuItem.Text = "Batch Extract PAK";
            this.batchConvertPAKToolStripMenuItem.Click += new System.EventHandler(this.BatchConvertPAKToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 361);
            this.Controls.Add(this.fileAttributesGroupBox);
            this.Controls.Add(this.texturePicBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "ASW Image Viewer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texturePicBox)).EndInit();
            this.fileAttributesGroupBox.ResumeLayout(false);
            this.fileAttributesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertCurrentFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchConvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox texturePicBox;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.GroupBox fileAttributesGroupBox;
        private System.Windows.Forms.TextBox attributeTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem convertPAKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchConvertPAKToolStripMenuItem;
    }
}