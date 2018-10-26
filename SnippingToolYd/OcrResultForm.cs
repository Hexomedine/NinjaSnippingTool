using System;
using System.Drawing;
using System.Windows.Forms;
using Windows.Graphics.Imaging;
using Windows.Media.Ocr;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.Foundation;

namespace NinjaSnippingTool
{
    public partial class OcrResultForm : Form
    {
        private static  Lazy<OcrResultForm> lazy = new Lazy<OcrResultForm>(() => new OcrResultForm());

        public static OcrResultForm Instance { get { return lazy.Value; } set { lazy = new Lazy<OcrResultForm>(() => new OcrResultForm()); } }

        private OcrResultForm()
        {
            InitializeComponent();
            this.Show();
        }

        public async void SetOcr(SnapShot SelectedSnapShot)
        {
            var ocr = OcrEngine.TryCreateFromUserProfileLanguages();

            var storageFile = await StorageFile.GetFileFromPathAsync(SelectedSnapShot.MaxQualityOutput.File.FullName);

            SoftwareBitmap softwareBitmap;

            using (IRandomAccessStream stream = await storageFile.OpenAsync(FileAccessMode.Read))
            {
                // Create the decoder from the stream
                BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);

                // Get the SoftwareBitmap representation of the file
                softwareBitmap = await decoder.GetSoftwareBitmapAsync();
                var result = await ocr.RecognizeAsync(softwareBitmap);

                // Check whether text is detected.
                if (result.Lines != null)
                {
                    // Collect recognized text.
                    string recognizedText = "";
                    foreach (var line in result.Lines)
                    {
                        foreach (var word in line.Words)
                        {
                            recognizedText += word.Text + " ";
                        }
                        recognizedText += Environment.NewLine;
                    }

                    // Display recognized text.
                    OcrTextBox.Text = recognizedText;
                }

            }
            
        }

        private void OcrResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instance = null; 
        }
    }
}
