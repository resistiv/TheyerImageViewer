using System;
using System.Windows.Forms;

namespace ASWImageViewer.UI
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void GitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link.\r\n{0}", ex.StackTrace);
            }
        }

        private void VisitLink()
        {
            gitHubLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Resistiv/CWSImageViewer");
        }
    }
}
