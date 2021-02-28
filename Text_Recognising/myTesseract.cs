using Emgu;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.Drawing;

namespace Text_Recognising
{
    static class myTesseract
    {
        //private const string filePathPNG = @"temp_files\tm.png";
        private const string _filePathLanguages = @"Languages";
        public static string Recognize(Bitmap bmp)
        {
            Tesseract tesseract = new Tesseract(_filePathLanguages, Form1.GetLanguage(), OcrEngineMode.TesseractLstmCombined);
            try
            {
                tesseract.SetImage(bmp.ToImage<Bgr, byte>());
                tesseract.Recognize();

                return tesseract.GetUTF8Text();
            }
            catch (System.Exception)
            {
                return "";
            }
            finally
            {
                tesseract.Dispose();
            }           
        }
    }
}
