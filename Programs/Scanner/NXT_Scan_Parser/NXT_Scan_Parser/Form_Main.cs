using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace NXT_Scan_Parser
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        string Scan_File_Path = "";
        Bitmap DrawArea;
        byte[,] scan = new byte[100, 64];

        private void Form_Main_Load(object sender, EventArgs e)
        {
            DrawArea = new Bitmap(100, 64);
            drawBox.BackgroundImage = DrawArea;
        }

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            drawBox.Height = (Application.OpenForms[0].Height - 39) - (MenuStrip.Height + Tools_Panel.Height);
        }

        private void Menu_ÖffneScan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Öffne die vom Scanner gespeicherte Datei...",
                SupportMultiDottedExtensions = true,
                RestoreDirectory = true,
                Multiselect = false,
                Filter = "Alle Dateien (*.*)|*.*|NXT-Scans (*.bin)|*.bin",
                FilterIndex = 2,
                DereferenceLinks = true,
                CheckPathExists = true,
                CheckFileExists = true,
                AddExtension = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Scan_File_Path = openFileDialog.FileName;
                ParseScan();
                ShowScan(0, 255, 0);
            };
        }

        private void Num_Limits_Changed(object sender, EventArgs e)
        {
            bool Overwrite = Control.ModifierKeys == Keys.Control;

            if (sender == Num_Min)
            {
                if (Num_Min.Value >= Num_Max.Value)
                {
                    if (Overwrite)
                    {
                        Num_Max.Value = Num_Min.Value + 1;
                    }
                    else
                    {
                        Num_Min.Value = Num_Max.Value - 1;
                    };
                }
            }
            else if (sender == Num_Max)
            {
                if (Num_Min.Value >= Num_Max.Value)
                {
                    if (Overwrite)
                    {
                        Num_Min.Value = Num_Max.Value - 1;
                    }
                    else
                    {
                        Num_Max.Value = Num_Min.Value + 1;
                    };
                }
            };

            ShowScan(Convert.ToInt32(Num_Min.Value), Convert.ToInt32(Num_Max.Value), Convert.ToByte(Num_Change.Value));
        }

        private void Num_Change_Changed(object sender, EventArgs e)
        {
            ShowScan(Convert.ToInt32(Num_Min.Value), Convert.ToInt32(Num_Max.Value), Convert.ToInt32(Num_Change.Value));
        }

        private void Num_Scrolled(object sender, ScrollEventArgs e)
        {
            Num_Limits_Changed(sender, new EventArgs());
        }

        public void ParseScan()
        {
            if (Scan_File_Path.Length == 0)
            {
                MessageBox.Show("ParseScan: Keine Datei bereitgestellt.", "Fehlende Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            FileStream ScanFile = File.OpenRead(Scan_File_Path);

            for (int x = 0; x < 100; x++)
            {
                for (int y = 0; y < 64; y++)
                {
                    scan[x, y] = Convert.ToByte(ScanFile.ReadByte());
                };
            }

            ScanFile.Close();
        }

        public void ShowScan(int min, int max, int change)
        {
            byte data = 0;

            for (int x = 0; x < 100; x++)
            {
                for (int y = 0; y < 64; y++)
                {
                    data = scan[x, y];

                    if (change >= 0)
                    {
                        data += Convert.ToByte(change);
                    }
                    else
                    {
                        data -= Convert.ToByte(change * -1);
                    };

                    if (data > max) { data = Convert.ToByte(max); };
                    if (data < min) { data = Convert.ToByte(min); };
                    DrawArea.SetPixel(x, y, Color.FromArgb(data, data, data));

                };
            };

            DrawArea.RotateFlip(RotateFlipType.RotateNoneFlipY);
            drawBox.BackgroundImage = DrawArea;
            drawBox.Refresh();
        }

        private void Menu_SpeichereBild_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                CheckPathExists = true,
                DefaultExt = ".png",
                OverwritePrompt = true,
                SupportMultiDottedExtensions = true,
                Title = "Speichere als...",
                Filter = ".png|*.png|.bmp|*.bmp|.ico|*.ico",
                ValidateNames = true
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                switch (path.Substring(path.Length-3,3))
                {
                    case "png":
                        DrawArea.Save(path, ImageFormat.Png);
                        break;
                    case "bmp":
                        DrawArea.Save(path, ImageFormat.Bmp);
                        break;
                    case "ico":
                        DrawArea.Save(path, ImageFormat.Icon);
                        break;
                }
            };
        }
    }
}
