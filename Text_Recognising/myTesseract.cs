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
        private static string res_text { get; set; } 
        public static string Recognize(string leng, string filePath)
        {
            Tesseract tesseract = new Tesseract(@"Languages", leng, OcrEngineMode.TesseractLstmCombined);

            tesseract.SetImage(new Image<Bgr, byte>(filePath));

            tesseract.Recognize();

            res_text = tesseract.GetUTF8Text();

            tesseract.Dispose();

            return res_text;
        }
    }
}
