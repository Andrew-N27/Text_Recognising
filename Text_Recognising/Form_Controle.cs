using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Recognising
{
    public partial class Form_Controle : Form
    {
        private const string filePath = @"temp_files\tm.png";

        public Form_Controle()
        {
            InitializeComponent();
            // win + shift + s
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Clipboard.GetImage();
            Controllers.Recognize(toolStripComboBox1.SelectedItem.ToString());
            richTextBox1.Text = Clipboard.GetText();
            //try
            //{
            //    if (!Clipboard.ContainsImage())
            //    {
            //        throw new Exception("Изображение не выбрано");
            //    }
            //    else if(toolStripComboBox1.SelectedItem == null)
            //    {
            //        throw new Exception("Язык не выбран");
            //    }
            //    else
            //    {
            //        pictureBox1.Image = Clipboard.GetImage();

            //        myFile.CreateIMG(Clipboard.GetImage());

            //        Clipboard.SetText(myTesseract.Recognize(toolStripComboBox1.SelectedItem.ToString(), filePath));

            //        richTextBox1.Text = Clipboard.GetText();

            //        myFile.Delete();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void btnScrin_Click(object sender, EventArgs e)
        {
            KeyboardSend.KeyDown(Keys.LWin);
            KeyboardSend.KeyDown(Keys.LShiftKey);
            KeyboardSend.KeyDown(Keys.S);
            KeyboardSend.KeyUp(Keys.LWin);
            KeyboardSend.KeyUp(Keys.LShiftKey);
            KeyboardSend.KeyUp(Keys.S);
        }
    }
}
