using System;
using System.IO;
using System.Windows.Forms;
using TheyerImageViewer.Data;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace TheyerImageViewer.UI
{
    public partial class MainWindow : Form
    {

        AboutBox aboutBox = null;
        MIBFile currentMIB = null;
        P1IFile currentP1I = null;

        public MainWindow()
        {
            InitializeComponent();
            RefreshDefault();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutBox == null || aboutBox.IsDisposed == true)
            {
                aboutBox = new AboutBox();
            }
            aboutBox.Visible = true;
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MIB texture file (*.mib)|*.mib";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowHelp = false;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Open Texture";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                RefreshDefault();
                currentMIB = new MIBFile(openFileDialog.FileName);
                if (currentMIB.IsValid() && currentMIB.GetPaletteFile().IsValid())
                {
                    currentMIB.Render();
                }
                attributeTextBox.Text = $"Texture file: {currentMIB.GetFileName()}\r\n\r\nPalette file: {currentMIB.GetPaletteFile().GetFileName()}\r\n\r\nBits per pixel: {currentMIB.GetBPP()}bpp\r\n\r\nWidth: {currentMIB.GetWidth()}px\r\n\r\nHeight: {currentMIB.GetHeight()}px";
                texturePicBox.Image = currentMIB.GetImage();
                convertCurrentFileToolStripMenuItem.Enabled = true;
                closeFileToolStripMenuItem.Enabled = true;
            }
            // Refresh();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshDefault();
        }

        private void RefreshDefault()
        {
            currentMIB = null;
            currentP1I = null;
            texturePicBox.Image = null;
            attributeTextBox.Text = "Texture file: \r\n\r\nPalette file: \r\n\r\nBits per pixel: \r\n\r\nWidth: \r\n\r\nHeight: ";
            convertCurrentFileToolStripMenuItem.Enabled = false;
            convertCurrentP1IToolStripMenuItem.Enabled = false;
            closeFileToolStripMenuItem.Enabled = false;
        }

        private void ConvertCurrentFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG (*.png)|*.png";
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.Title = "Convert current MIB";
            saveFileDialog.SupportMultiDottedExtensions = true;
            saveFileDialog.ShowHelp = false;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.AddExtension = true;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = Path.GetFileName(currentMIB.GetFileName()) + ".png";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                string saveFileName = saveFileDialog.FileName;
                if (!saveFileName.ToLower().EndsWith(".png"))
                {
                    saveFileName += ".png";
                }
                currentMIB.GetImage().Save(saveFileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Converted current MIB.");
            }
        }

        private void BatchConvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderBrowserDialog = new CommonOpenFileDialog();
            folderBrowserDialog.IsFolderPicker = true;
            folderBrowserDialog.RestoreDirectory = true;
            folderBrowserDialog.Title = "Open folder for batch MIB processing";
            var result = folderBrowserDialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                int exportCount = 0;
                string[] workFiles = Directory.GetFiles(folderBrowserDialog.FileName);
                foreach (string filePath in workFiles)
                {
                    if (filePath.ToLower().EndsWith(".mib"))
                    {
                        currentMIB = new MIBFile(filePath);
                        if (currentMIB.IsValid() && currentMIB.GetPaletteFile().IsValid())
                        {
                            currentMIB.Render();
                        }
                        string savePath = filePath + ".png";
                        currentMIB.GetImage().Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
                        exportCount++;
                    }
                }
                MessageBox.Show($"Converted {exportCount} files.");
            }
        }

        private void ConvertPAKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ASW packed file (*.pak)|*.pak";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowHelp = false;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Open PAK file";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                PAKFile currentPAK = new PAKFile(openFileDialog.FileName);
                if (currentPAK.IsValid())
                {
                    currentPAK.Extract();
                }
                MessageBox.Show("Extracted PAK file");
            }
        }

        private void BatchConvertPAKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderBrowserDialog = new CommonOpenFileDialog();
            folderBrowserDialog.IsFolderPicker = true;
            folderBrowserDialog.RestoreDirectory = true;
            folderBrowserDialog.Title = "Open folder for batch PAK processing";
            var result = folderBrowserDialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                int exportCount = 0;
                string[] workFiles = Directory.GetFiles(folderBrowserDialog.FileName);
                foreach (string filePath in workFiles)
                {
                    if (filePath.ToLower().EndsWith(".pak"))
                    {
                        PAKFile currentPAK = new PAKFile(filePath);
                        if (currentPAK.IsValid())
                        {
                            currentPAK.Extract();
                        }
                        exportCount++;
                    }
                }
                MessageBox.Show($"Extracted from {exportCount} files.");
            }
        }

        private void OpenP1IFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "P1I texture file (*.p1i)|*.p1i";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowHelp = false;
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Open Texture";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                RefreshDefault();
                currentP1I = new P1IFile(openFileDialog.FileName);
                if (currentP1I.IsValid() && currentP1I.GetPaletteFile().IsValid())
                {
                    currentP1I.Render();
                }
                attributeTextBox.Text = $"Texture file: {currentP1I.GetFileName()}\r\n\r\nPalette file: {currentP1I.GetPaletteFile().GetFileName()}\r\n\r\nBits per pixel: {currentP1I.GetBPP()}bpp\r\n\r\nWidth: {currentP1I.GetWidth()}px\r\n\r\nHeight: {currentP1I.GetHeight()}px";
                texturePicBox.Image = currentP1I.GetImage();
                convertCurrentP1IToolStripMenuItem.Enabled = true;
                closeFileToolStripMenuItem.Enabled = true;
            }
        }

        private void ConvertCurrentP1IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG (*.png)|*.png";
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.Title = "Convert current P1I";
            saveFileDialog.SupportMultiDottedExtensions = true;
            saveFileDialog.ShowHelp = false;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.AddExtension = true;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = Path.GetFileName(currentP1I.GetFileName()) + ".png";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                string saveFileName = saveFileDialog.FileName;
                if (!saveFileName.ToLower().EndsWith(".png"))
                {
                    saveFileName += ".png";
                }
                currentP1I.GetImage().Save(saveFileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Converted current P1I.");
            }
        }

        private void BatchConvertP1IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderBrowserDialog = new CommonOpenFileDialog();
            folderBrowserDialog.IsFolderPicker = true;
            folderBrowserDialog.RestoreDirectory = true;
            folderBrowserDialog.Title = "Open folder for batch P1I processing";
            var result = folderBrowserDialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                int exportCount = 0;
                string[] workFiles = Directory.GetFiles(folderBrowserDialog.FileName);
                foreach (string filePath in workFiles)
                {
                    if (filePath.ToLower().EndsWith(".p1i"))
                    {
                        currentP1I = new P1IFile(filePath);
                        if (currentP1I.IsValid() && currentP1I.GetPaletteFile().IsValid())
                        {
                            currentP1I.Render();
                        }
                        string savePath = filePath + ".png";
                        currentP1I.GetImage().Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
                        exportCount++;
                    }
                }
                MessageBox.Show($"Converted {exportCount} files.");
            }
        }
    }
}
