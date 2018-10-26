using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace NinjaSnippingTool
{
    public class SnapService
    {

        /// <summary>
        /// Répertoire de sortie
        /// </summary>
        public string OutputDirPath { get; set; }

        public SnapService()
        {
            OutputDirAutoSetting();
        }

        /// <summary>
        /// Outil de processus de capture d'écran
        /// </summary>
        private ScreenCapture objScreenCapture;


        private Bitmap _lastSnapBmp;

        // private ImageList myImageList = new ImageList();

        public string LastSavedJpgFile { get; set; }


        // public SnapShot LastSnapShot = new SnapShot();
        public SnapShot LastSnapShot { get; set; } = new SnapShot();


        public static SnapService StartNewSnap()
        {
            var srv = new SnapService();
            srv.TakeSnap(false, false);
            return srv;
        }

        private void OutputDirAutoSetting()
        {
            if (!string.IsNullOrWhiteSpace(OutputDirPath) && Directory.Exists(OutputDirPath))
                return;


            var dirPath = Properties.Settings.Default.OutputDirPath;
            if (string.IsNullOrWhiteSpace(dirPath))
                dirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ScreenShots");

            this.OutputDirPath = dirPath;
        }


        /// <summary>
        /// Lancer le processus de capture
        /// </summary>
        public SnapShot TakeSnap(bool uncompressed, bool fullScreen)
        {

            var captureDate = DateTime.Now;           
            objScreenCapture = ScreenCapture.StartNewCapture(fullScreen);
            if (objScreenCapture.IsCancelledByUser)
                return null;

            _lastSnapBmp = objScreenCapture.GetSnapShot();
            var compOutputPath = GetNewOutputFilePath(captureDate);
            var uncompOutputPath = string.Empty;
            
            var dirPath = Path.GetDirectoryName(compOutputPath);
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            var graphics = Graphics.FromImage((Image)_lastSnapBmp);
            _lastSnapBmp.Save(compOutputPath, ImageFormat.Jpeg);
            if (uncompressed) {
                uncompOutputPath = GetNewOutputFilePathBmp(captureDate);
                _lastSnapBmp.Save(uncompOutputPath, ImageFormat.Bmp);
            }
            LastSavedJpgFile = compOutputPath;

            Clipboard.SetImage(_lastSnapBmp);

            LastSnapShot = SnapShot.GetNewFromPathes(compOutputPath, uncompOutputPath);

            return LastSnapShot;
        }

        public IEnumerable<SnapShot> GetAllSnap()
        {
            List<SnapShot> lastSnapShots = new List<SnapShot>();

            string[] files = Directory.GetFiles(OutputDirPath, "*.jpg");
            int i = 0;

            foreach (var filename in files)
            {
                var filePath = files[i];
                var fileNameWext = Path.GetFileNameWithoutExtension(filePath);
                var compressedFilePath = filePath;

                var uncompressedFilePath = Path.Combine(OutputDirPath, fileNameWext) + ".bmp";


                lastSnapShots.Add(SnapShot.GetNewFromPathes(compressedFilePath, uncompressedFilePath));
                i++;
            }

            return lastSnapShots;
        }

        public string GetNewOutputFilePath(DateTime captureDate)
        {
            OutputDirAutoSetting();
            return Path.Combine(OutputDirPath, string.Format("Screen_{0:yyyyMMdd_HHmmss}.jpg", captureDate));

        }

        public string GetNewOutputFilePathBmp(DateTime captureDate)
        {
            OutputDirAutoSetting();
            return Path.Combine(OutputDirPath, string.Format("Screen_{0:yyyyMMdd_HHmmss}.bmp", captureDate));

        }
    }
}
