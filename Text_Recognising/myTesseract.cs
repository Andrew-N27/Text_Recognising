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
        private const string filePath = @"temp_files\tm.png";

        public static string Recognize(string leng)
        {
            Tesseract tesseract = new Tesseract(@"Languages", leng, OcrEngineMode.TesseractLstmCombined);

            try
            {
                tesseract.SetImage(new Image<Bgr, byte>(filePath));

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
