using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.Util;


namespace Text_Recognising
{
    public partial class Form1 : Form
    {
        private string filePath { get; set; }

        public Form1()
        {
            InitializeComponent();
            //
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();

            if(res == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                pictureBox1.Image = Clipboard.GetImage();//Image.FromFile(filePath);
            }
            else
            {
                MessageBox.Show("Изображение не выбрано");
            }
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath) || string.IsNullOrWhiteSpace(filePath)) //Clipboard.ContainsImage();
                {
                    throw new Exception("Изображение не выбрано");
                }
                else if(toolStripComboBox1.SelectedItem == null)
                {
                    throw new Exception("Язык не выбран");
                }
                else
                {
                    Tesseract tesseract = new Tesseract(@"Languages", toolStripComboBox1.SelectedItem.ToString(), OcrEngineMode.TesseractLstmCombined);

                    //var arr = ImageToByte(Clipboard.GetImage());

                    tesseract.SetImage(new Image<Bgr, byte>(filePath));

                    //Clipboard.GetImage();

                    Image image = Clipboard.GetImage();

                    //image.GetThumbnailImage();


                    tesseract.Recognize();

                    richTextBox1.Text = tesseract.GetUTF8Text();

                    //Clipboard.SetText(tesseract.GetUTF8Text());

                    tesseract.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

    }
}
