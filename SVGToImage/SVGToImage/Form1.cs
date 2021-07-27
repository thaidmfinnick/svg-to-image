using NReco.ImageGenerator;
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

namespace SVGToImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Su dung thu vien NReco chuyen tu SVG sang Image
        private NReco.ImageGenerator.HtmlToImageConverter imageConvert = new NReco.ImageGenerator.HtmlToImageConverter();
        private OpenFileDialog openImage = new OpenFileDialog();
        private void btn_LinkImage_Click(object sender, EventArgs e)
        {
            if (openImage.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Can't open, try again!", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Import file successfully!");
            }
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            ChangeWidthHeight();
            ConvertSVGToImage();

        }
        private void ChangeWidthHeight()
        {
            imageConvert.Width = Int32.Parse(textBox_GetWidth.Text);
            imageConvert.Height = Int32.Parse(textBox_GetHeight.Text);
        }

        private void ConvertSVGToImage()
        {
            var imageByte = imageConvert.GenerateImageFromFile(openImage.FileName, NReco.ImageGenerator.ImageFormat.Jpeg);
            //Chua ro
            using (var stream = new System.IO.MemoryStream(imageByte, 0, imageByte.Length))
            {
                Bitmap bm = new Bitmap(Image.FromStream(stream));
                if (comboBox_SaveAs.Text.Contains("PNG"))
                {
                    bm.Save(openImage.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }
                else if (comboBox_SaveAs.Text.Contains("JPEG")|| comboBox_SaveAs.Text.Contains("JPG"))
                {
                    bm.Save(openImage.FileName + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (comboBox_SaveAs.Text.Contains("GIF"))
                {
                    bm.Save(openImage.FileName + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
                }
                else if (comboBox_SaveAs.Text.Contains("TIFF"))
                {
                    bm.Save(openImage.FileName + ".tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                }
                else if (comboBox_SaveAs.Text.Contains("BMP"))
                {
                    bm.Save(openImage.FileName + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                }
                else
                {
                    bm.Save(openImage.FileName + ".ico", System.Drawing.Imaging.ImageFormat.Icon);
                }
            }
        }


    }
}
