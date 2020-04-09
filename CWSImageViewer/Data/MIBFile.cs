using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ASWImageViewer.Data
{
    class MIBFile
    {
        private string fileName;
        private bool isValid;
        private int bpp;
        private int width;
        private int height;
        private MIBFile paletteFile;
        private Color[] palette;
        private Bitmap image;
        private BinaryReader br;

        public MIBFile(string fileName)
        {
            this.fileName = fileName;
            br = new BinaryReader(File.Open(this.fileName, FileMode.Open));
            if (!VerifyHeader())
            {
                MessageBox.Show("Invalid MIB file.");
                isValid = false;
                br.Close();
            }
            else
            {
                isValid = true;
                bpp = br.ReadInt32();
                width = br.ReadInt16();
                height = br.ReadInt16();
                if (bpp == 8)
                {
                    byte[] paletteFileNameRaw = br.ReadBytes(16);
                    string paletteFileName = Encoding.UTF8.GetString(paletteFileNameRaw).TrimEnd('\0');
                    string paletteFilePath = Path.GetDirectoryName(this.fileName) + "\\" + paletteFileName + ".cmb";
                    // MessageBox.Show(paletteFilePath);
                    if (!File.Exists(paletteFilePath))
                    {
                        MessageBox.Show("Could not find CMB file.");
                        isValid = false;
                        br.Close();
                    }
                    else
                    {
                        paletteFile = new MIBFile(paletteFilePath, true);
                    }
                }
                else
                {
                    br.ReadBytes(16);
                    paletteFile = new MIBFile(true);
                }
                image = new Bitmap(width, height);
            }
        }

        public MIBFile(string fileName, bool isColourMIB)
        {
            this.fileName = fileName;
            br = new BinaryReader(File.Open(this.fileName, FileMode.Open));
            if (!VerifyHeader())
            {
                MessageBox.Show("Invalid CMB file.");
                isValid = false;
                br.Close();
            }
            else
            {
                isValid = true;
                bpp = br.ReadInt32();
                width = br.ReadInt16();
                height = br.ReadInt16();
                br.ReadBytes(16);
                palette = new Color[width];
                for (int i = 0; i < width; i++)
                {
                    palette[i] = GetColor(br.ReadBytes(2));
                }
                br.Close();
            }
        }

        public MIBFile(bool isColourMIB)
        {
            fileName = "No palette file";
            isValid = true;
        }

        private bool VerifyHeader()
        {
            byte[] magicRaw = br.ReadBytes(4);
            string magicId = Encoding.UTF8.GetString(magicRaw);
            if (magicId == "MIB\0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        This code snippet for getting a color value from a 2 byte source is borrowed from Barubary's TiledGGD, which can be found at: https://github.com/Barubary/tiledggd

        Copyright (c) 2010 Barubary

        Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

        The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

        THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
        */
        private Color GetColor(byte[] data)
        {
            uint bt;
            uint b1, b2;
            uint fst, scn, thd;
            uint a, r, g, b;

            b2 = (uint)data[0];
            b1 = (uint)data[1];

            bt = (b1 << 8) | b2;

            a = (bt & 0x8000) >> 15;
            fst = (bt & 0x7C00) >> 7;
            scn = (bt & 0x03E0) >> 2;
            thd = (bt & 0x001F) << 3;

            a = 1 * 0xFF;

            b = fst;
            g = scn;
            r = thd;

            int[] col = new int[] { (int)((a << 24) | (r << 16) | (g << 8) | b) };

            return Color.FromArgb(col[0]);
        }

        public void Render()
        {
            if (bpp == 8)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        image.SetPixel(x, y, paletteFile.palette[br.ReadByte()]);
                    }
                }
            }
            else
            {
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        image.SetPixel(x, y, GetColor(br.ReadBytes(2)));
                    }
                }
            }
            br.Close();
        }

        public bool IsValid()
        {
            return isValid;
        }

        public string GetFileName()
        {
            return fileName;
        }

        public int GetBPP()
        {
            return bpp;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public MIBFile GetPaletteFile()
        {
            return paletteFile;
        }

        public Color[] GetColorPalette()
        {
            return palette;
        }

        public Bitmap GetImage()
        {
            return image;
        }
    }
}