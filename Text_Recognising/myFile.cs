using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Recognising
{
    static class myFile
    {
        private const string filePath = @"temp_files\tm.png";
        public static void CreateIMG(Image image)
        {
            image.Save(filePath);
        }

        public static void Delete()
        {
            File.Delete(filePath);
        }
    }
}
