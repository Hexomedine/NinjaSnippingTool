using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using io = System.IO;

namespace NinjaSnippingTool
{
    public class ImageOutput : IDisposable
    {
        public Image Img { get; set; }
        public FileInfo File { get; set; }

        public ImageOutput(string filePath)
        {
            File = new FileInfo(filePath);
            Img = Image.FromFile(filePath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ImageOutput GetNewFromFilePath(string filePath)
        {
            if (!io.File.Exists(filePath))
                return null;

            var result = new ImageOutput(filePath);            
            return result;
        }

        public void Dispose()
        {
            if(Img != null)
            {
                Img.Dispose();
            }
        }
    }
}
