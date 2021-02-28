using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Recognising
{
    class myFile
    {
        //private const string filePath = @"temp_files\tm.png";

        //private Bitmap _temp = null;

        public static void CreateIMG(Int32 x, Int32 y, Int32 w, Int32 h, Size s)
        {
            Rectangle rect = new Rectangle(x, y, w, h);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, s, CopyPixelOperation.SourceCopy);

            try
            {
                Clipboard.SetText(myTesseract.Recognize(bmp));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
