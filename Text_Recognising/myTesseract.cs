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
        public static string Recognize(string leng, string filePath)
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
