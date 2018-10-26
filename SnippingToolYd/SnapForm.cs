using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections.Specialized;

namespace NinjaSnippingTool
{
    public partial class SnapForm : Form
    {
        //private GlobalHotKey TakeSnapHotKey;
        private ScreenCapture objScreenCapture;

        // private string _lastSavedJpgFile = null;

        private SnapService _srv = new SnapService();
        private bool _uncompressed = false;
        private bool _fullScreen = false;
        // private string _focusedItem = "Auncune image séléctionnée";
        private IEnumerable<SnapShot> _currentDisplayedSnaps = null;

        /// <summary>
        /// Le snaptshot sélectionné
        /// </summary>
        public SnapShot SelectedSnapShot { get; set; }

        public SnapForm()
        {
            InitForm();
            FillThumbnailsListview();
        }

        public SnapForm(bool snapAutoLaunch)
        {
            InitForm();
            if (snapAutoLaunch)
            {
                NewSnap();
            }
            else
            {
                FillThumbnailsListview();
            }
        }

        private void InitForm()
        {
            InitializeComponent();
        }

        private void DisposeAllSnaps()
        {
            if (_currentDisplayedSnaps != null)
                foreach (var snap in _currentDisplayedSnaps)
                    snap.Dispose();
        }

        //protected override void OnActivated(EventArgs e)
        //{
        //    base.OnActivated(e);

        //    DisposeAllSnaps();
        //}

        private void NewSnap()
        {
            if (SaveCompressCB.Checked)
            {
                _uncompressed = true;
            }
            // Nouvelle capture
            var newSnap = _srv.TakeSnap(_uncompressed, _fullScreen);

            if (newSnap == null)
                return;

            pictureBox1.Image = _srv.LastSnapShot.MaxQualityOutput.Img;
            SelectedSnapShot = newSnap;
            FillThumbnailsListview();

        }

        private void FillThumbnailsListview()
        {
            _currentDisplayedSnaps = _srv.GetAllSnap();
            _currentDisplayedSnaps = _currentDisplayedSnaps.OrderByDescending(x => x.MaxQualityOutput.File.CreationTime);
            snapListView.Clear();
            snapListView.LargeImageList = new ImageList();
            snapListView.LargeImageList.ImageSize = new Size(100, 80);

            foreach (var snap in _currentDisplayedSnaps)
            {
                var lstViewItem = snapListView.Items.Add(string.Format("{0:dd/MM/yyyy HH:mm:ss}", snap.CompressedOutput.File.CreationTime), snap.Uid.ToString());
                snapListView.LargeImageList.Images.Add(snap.Uid.ToString(), snap.CompressedOutput.Img);
            }
            //snapListView.LargeImageList.Images.AddRange(allSnaps.Select(s => s.Image).ToArray());  
            snapListView.Update();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void SetSelectedSnapShot(SnapShot snapShot)
        {
            SelectedSnapShot = snapShot;

            if (SelectedSnapShot == null)
            {
                pictureBox1.Hide();
                FocusedItemLabel.Text = string.Empty;
                return;
            }
            // _focusedItem = snapListView.FocusedItem.ImageKey;
            //var temp = _allSnaps.Where(x => x.MaxQualityOutput.File.FullName == _focusedItem).Select(a => a.MaxQualityOutput.Img).ToList();
            pictureBox1.Show();
            pictureBox1.Image = SelectedSnapShot.MaxQualityOutput.Img; // System.Drawing.Image.FromFile(_focusedItem.ToString());
            FocusedItemLabel.Text = SelectedSnapShot.Title;
            // FocusedItemLabel.Text = _focusedItem;

        }

        /// <summary>
        /// Quand la sélection change dans la liste de vignettes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                

                // TODO : assigner le snapshot 
                if (snapListView.SelectedItems == null || snapListView.SelectedItems.Count == 0)
                {
                    SetSelectedSnapShot(null);
                    return;
                }

                var firstSelectedLstViewItem = snapListView.SelectedItems[snapListView.SelectedItems.Count - 1];
                // var firstSelectedLstViewItemIdx = snapListView.Items.IndexOf(firstSelectedLstViewItem);
                SetSelectedSnapShot(_currentDisplayedSnaps.SingleOrDefault(s => s.Uid.ToString().Equals(firstSelectedLstViewItem.ImageKey)));

            }
            catch (IOException f)
            {
                FillThumbnailsListview();
            }

        }

        private void SnapBouton_Click(object sender, EventArgs e)
        {
            Hide();
            NewSnap();
            Show();
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            //DisposeAllSnaps();
            var dirPath = Properties.Settings.Default.OutputDirPath;
            if (string.IsNullOrWhiteSpace(dirPath))
                dirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ScreenShots");
            Process.Start(dirPath);
        }

        private void SaveCompressCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CopyJpgButton_Click(object sender, EventArgs e)
        {
            if (SelectedSnapShot == null)
                return;

            Clipboard.SetImage(SelectedSnapShot.CompressedOutput.Img);
        }

        private void CopyBmpButton_Click(object sender, EventArgs e)
        {
            if (SelectedSnapShot == null || SelectedSnapShot.UncompressedOutput == null)
                return;

            Clipboard.SetImage(SelectedSnapShot.UncompressedOutput.Img);
        }

        private void BtnAddPathToClip_Click(object sender, EventArgs e)
        {
            if (SelectedSnapShot == null)
                return;

            Clipboard.SetText(SelectedSnapShot.CompressedOutput.File.FullName);
        }

        private void CopyBmpPathButton_Click(object sender, EventArgs e)
        {
            if (SelectedSnapShot == null || SelectedSnapShot.UncompressedOutput == null)
                return;

            Clipboard.SetText(SelectedSnapShot.UncompressedOutput.File.FullName);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            FillThumbnailsListview();
        }

        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            Hide();
            Thread.Sleep(200);
            _fullScreen = true;
            NewSnap();
            _fullScreen = false;
            Show();
        }

        private void CopyFileButton_Click(object sender, EventArgs e)
        {
            if (SelectedSnapShot == null)
                return;
            StringCollection temp = new StringCollection();           
            temp.Add(SelectedSnapShot.CompressedOutput.File.FullName);
            Clipboard.SetFileDropList(temp);
        }

        private void CopyBmpFileButton_Click(object sender, EventArgs e)
        {
            if (SelectedSnapShot == null)
                return;
            StringCollection temp = new StringCollection();
            temp.Add(SelectedSnapShot.UncompressedOutput.File.FullName);
            Clipboard.SetFileDropList(temp);
        }

        private void GetOcrButton_Click(object sender, EventArgs e)
        {
            if (SelectedSnapShot == null)
                return;

            OcrResultForm OcrInstance = OcrResultForm.Instance;
            OcrInstance.SetOcr(SelectedSnapShot);
            
        }

        private void VideoRecordButton_Click(object sender, EventArgs e)
        {
            Hide();
            // Using MotionJpeg as Avi encoder,
            // output to 'out.avi' at 10 Frames per second, 70% quality
            var rec = new Recorder(new VideoShot( _srv.OutputDirPath + string.Format("/Video_{0:yyyyMMdd_HHmmss}.avi", DateTime.Now), 24, SharpAvi.KnownFourCCs.Codecs.MotionJpeg, 90));

            Thread.Sleep(3000);

            // Finish Writing
            rec.Dispose();
            Show();
        }
    }
}
