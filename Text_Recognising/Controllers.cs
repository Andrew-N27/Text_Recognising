using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Recognising
{
    static public class Controllers
    {
        private const string filePath = @"temp_files\tm.png";

        static public void Recognize(string lang)
        {
            try
            {
                if (!Clipboard.ContainsImage())
                {
                    throw new Exception("Изображение не выбрано");
                }
                else if (lang == null)
                {
                    throw new Exception("Язык не выбран");
                }
                else
                {
                    myFile.CreateIMG(Clipboard.GetImage());
                    Clipboard.SetText(myTesseract.Recognize(lang, filePath));
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
