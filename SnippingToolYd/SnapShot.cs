using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaSnippingTool
{
    public class SnapShot : IDisposable
    {

        private static int _uidCounter = 0;

        public int Uid { get; private set; }
        public bool IsDisposed { get; set; }

        private static int NewUid()
        {
            _uidCounter++;
            return _uidCounter;
        }

        public ImageOutput CompressedOutput { get; set; }
        public ImageOutput UncompressedOutput { get; set; }

        // public DateTime CreationDate { get; set; }
        // public object MaxQualityOutput { get; internal set; }

        public ImageOutput MaxQualityOutput
        {
            get { return UncompressedOutput != null ? UncompressedOutput : CompressedOutput; }
        }



        public string Title
        {
            get { return MaxQualityOutput.File.Name; }

        }






        public SnapShot()
        {
            Uid = NewUid();
        }


        public override string ToString()
        {
            return string.Format("{0} Disposed:{1} {2}", Uid, IsDisposed, Title);
        }


        public static SnapShot GetNewFromPathes(string compressedImgPath, string uncompressedImgPath)
        {
            var result = new SnapShot();

            result.CompressedOutput = ImageOutput.GetNewFromFilePath(compressedImgPath);

            if (!string.IsNullOrWhiteSpace(uncompressedImgPath))
                result.UncompressedOutput = ImageOutput.GetNewFromFilePath(uncompressedImgPath);

            // TODO : result.CreationDate = implémenter la déduction de la date depuis le system de nommage du fichier

            return result;
        }

        public void Dispose()
        {
            if (CompressedOutput != null)
                CompressedOutput.Dispose();

            if (UncompressedOutput != null)
                UncompressedOutput.Dispose();

            IsDisposed = true;
        }
    }
}
