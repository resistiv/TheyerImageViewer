namespace ASWImageViewer.UI
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.okButton = new System.Windows.Forms.Button();
            this.appDescription = new System.Windows.Forms.Label();
            this.gitHubLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(96, 128);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // appDescription
            // 
            this.appDescription.AutoSize = true;
            this.appDescription.Location = new System.Drawing.Point(48, 16);
            this.appDescription.Name = "appDescription";
            this.appDescription.Size = new System.Drawing.Size(177, 65);
            this.appDescription.TabIndex = 1;
            this.appDescription.Text = "California Watersports Image Viewer\r\n\r\nCreated by Resistiv\r\n\r\nVersion 1.1";
            this.appDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gitHubLink
            // 
            this.gitHubLink.AutoSize = true;
            this.gitHubLink.Location = new System.Drawing.Point(24, 104);
            this.gitHubLink.Name = "gitHubLink";
            this.gitHubLink.Size = new System.Drawing.Size(228, 13);
            this.gitHubLink.TabIndex = 2;
            this.gitHubLink.TabStop = true;
            this.gitHubLink.Text = "https://github.com/Resistiv/CWSImageViewer";
            this.gitHubLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLink_LinkClicked);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 161);
            this.Controls.Add(this.gitHubLink);
            this.Controls.Add(this.appDescription);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutBox";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label appDescription;
        private System.Windows.Forms.LinkLabel gitHubLink;
    }
}