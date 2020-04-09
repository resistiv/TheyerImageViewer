using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ASWImageViewer.Data
{
    class PAKFile
    {
        private string fileName;
        private bool isValid;
        private int fileCount;
        private string[] internalNames;
        private int[] internalLengths;
        private int[] internalOffsets;
        private string outputDirectory;
        private BinaryReader br;

        public PAKFile(string fileName)
        {
            this.fileName = fileName;
            br = new BinaryReader(File.Open(this.fileName, FileMode.Open));
            if (!VerifyHeader())
            {
                MessageBox.Show("Invalid PAK file.");
                isValid = false;
                br.Close();
            }
            else
            {
                isValid = true;
                fileCount = br.ReadInt32();
                internalNames = new string[fileCount];
                internalLengths = new int[fileCount];
                internalOffsets = new int[fileCount];
                for (int i = 0; i < fileCount; i++)
                {
                    byte[] nameRaw = br.ReadBytes(32);
                    internalNames[i] = Encoding.UTF8.GetString(nameRaw).TrimEnd('\0');
                    internalLengths[i] = br.ReadInt32();
                    internalOffsets[i] = br.ReadInt32();
                }
                outputDirectory = $"{Path.GetDirectoryName(fileName)}\\{Path.GetFileNameWithoutExtension(fileName)}\\";
            }
        }

        private bool VerifyHeader()
        {
            byte[] magicRaw = br.ReadBytes(4);
            string magicId = Encoding.UTF8.GetString(magicRaw);
            if (magicId == "PAK\0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Extract()
        {
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }
            for (int i = 0; i < fileCount; i++)
            {
                string filePath = $"{outputDirectory}{internalNames[i]}";
                br.BaseStream.Seek(internalOffsets[i], SeekOrigin.Begin);
                File.WriteAllBytes(filePath, br.ReadBytes(internalLengths[i]));
            }
            br.Close();
        }

        public bool IsValid()
        {
            return isValid;
        }
    }
}
