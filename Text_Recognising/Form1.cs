using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Recognising
{
    public partial class Form1 : Form
    {
        private const string filePath = @"temp_files\tm.png";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Clipboard.ContainsImage())
                {
                    throw new Exception("Изображение не выбрано");
                }
                else if(toolStripComboBox1.SelectedItem == null)
                {
                    throw new Exception("Язык не выбран");
                }
                else
                {
                    pictureBox1.Image = Clipboard.GetImage();

                    myFile.CreateIMG(Clipboard.GetImage());

                    Clipboard.SetText(myTesseract.Recognize(toolStripComboBox1.SelectedItem.ToString(), filePath));

                    richTextBox1.Text = Clipboard.GetText();

                    myFile.Delete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
