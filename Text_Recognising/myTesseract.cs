using Emgu;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Text_Recognising
{
    static class myTesseract
    {
        private const string filePathPNG = @"temp_files\tm.png";
        private const string filePathLanguages = @"Languages";
        public static string Recognize()
        {
            Tesseract tesseract = new Tesseract(filePathLanguages, Form1.GetLanguage(), OcrEngineMode.TesseractLstmCombined);

            try
            {
                tesseract.SetImage(new Image<Bgr, byte>(filePathPNG));
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
