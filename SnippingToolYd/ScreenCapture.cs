using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace NinjaSnippingTool
{
    class ScreenCapture
    {
        private Rectangle captureRectangle = Screen.GetBounds(Point.Empty);

        /// <summary>
        /// L'utilisateur a annulé la capture
        /// </summary>
        public bool IsCancelledByUser { get; set; } = false;

        public ScreenCapture(bool isFullScreen)
        {
            SetCaptureRectangle(isFullScreen);
        }

        public static ScreenCapture StartNewCapture(bool isFullScreen)
        {
            return new ScreenCapture(isFullScreen);
        }

        public Bitmap GetSnapShot()
        {
            using (Image image = new Bitmap(captureRectangle.Width, captureRectangle.Height))
            {
                using (Graphics graphics = Graphics.FromImage(image))
                {
                    graphics.CopyFromScreen(new Point (captureRectangle.Left, captureRectangle.Top), Point.Empty, captureRectangle.Size);
                }
                return new Bitmap(SetBorder(image, Color.Black, 1));
            }
        }

        private Image SetBorder(Image srcImg, Color color, int width)
        {
            // Create a copy of the image and graphics context
            Image dstImg = srcImg.Clone() as Image;
            Graphics g = Graphics.FromImage(dstImg);

            // Create the pen
            Pen pBorder = new Pen(color, width)
            {
                Alignment = PenAlignment.Center
            };

            // Draw
            g.DrawRectangle(pBorder, 0, 0, dstImg.Width - 1, dstImg.Height - 1);

            // Clean up
            pBorder.Dispose();
            g.Save();
            g.Dispose();

            // Return
            return dstImg;
        }

        private void SetCaptureRectangle(bool isFullScreen)
        {
            //capture our Current Screen
            //if (isFullScreen) { captureRectangle = Screen.AllScreens[0].Bounds; return; }
            if (isFullScreen) { captureRectangle = SystemInformation.VirtualScreen; return; }

            using (Canvas canvas = new Canvas())
            {
                if (canvas.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.captureRectangle = canvas.LastDrawnRectangle;
                }
                else
                    IsCancelledByUser = true;
            }
        }
    }
}
