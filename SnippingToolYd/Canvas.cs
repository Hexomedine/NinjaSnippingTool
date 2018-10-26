using System;
using System.Drawing;
using System.Windows.Forms;

namespace NinjaSnippingTool
{
    public partial class Canvas : Form
    {
        Point startPos;      // mouse-down position
        Point currentPos;    // current mouse position
        bool drawing;
        bool dual;
        Point oldLoc = new Point();
        private bool _leftClick;
        private bool _rightClick;
        
        
        private Rectangle _lastDrawnRectangle;

        public Rectangle LastDrawnRectangle
        {
            get { return _lastDrawnRectangle; }
        }

        //private Screen[] src = Screen.AllScreens;
        //Point rec = Cursor.Position;



        public Canvas()
        {
            //foreach (Screen s in src)
            //{
            //    if (s.Bounds.Contains(rec)) {
            //        StartPosition = FormStartPosition.Manual;
            //        Location = s.Bounds.Location; break; }
            //}

            Size = SystemInformation.VirtualScreen.Size;
            Location = SystemInformation.VirtualScreen.Location;
            Width = SystemInformation.VirtualScreen.Width;
            
            SetBounds(SystemInformation.VirtualScreen.X, SystemInformation.VirtualScreen.Y, SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
            StartPosition = FormStartPosition.CenterScreen;
            //this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.White;
            this.Opacity = 0.75;
            this.Cursor = Cursors.Cross;
            this.MouseDown += Canvas_MouseDown;
            this.MouseMove += Canvas_MouseMove;
            this.MouseUp += Canvas_MouseUp;
            this.Paint += Canvas_Paint;
            this.KeyDown += Canvas_KeyDown;
            this.DoubleBuffered = true;
            

        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private Rectangle GetNewRectangleToDraw()
        {

            // LastDrawnRectangle
            if (dual)
            {
                // la position courante est le coin inférieur droit
                // décalage = ajuster le coin sup gauche avec la position actuelle
                var deltaX = currentPos.X - (_lastDrawnRectangle.X + _lastDrawnRectangle.Width);
                var deltaY = currentPos.Y - (_lastDrawnRectangle.Y + _lastDrawnRectangle.Height);
                _lastDrawnRectangle.X = _lastDrawnRectangle.X + deltaX;
                _lastDrawnRectangle.Y = _lastDrawnRectangle.Y + deltaY;
                return LastDrawnRectangle;
            }

            // Mode "normal" : redimentionnement du rectangle
            return new Rectangle(
                    Math.Min(startPos.X, currentPos.X),
                    Math.Min(startPos.Y, currentPos.Y),
                    Math.Abs(startPos.X - currentPos.X),
                    Math.Abs(startPos.Y - currentPos.Y));
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _leftClick = true;
            if (e.Button == MouseButtons.Right)
                _rightClick = true;

            if ((_leftClick == true && _rightClick == false) || (_rightClick == true && _leftClick == false))
            {
                currentPos = startPos = e.Location;
                drawing = true;
                dual = false;
            }
            else if (_leftClick == true && _rightClick == true)
            {
                dual = true;
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            currentPos = e.Location;
            if (drawing) this.Invalidate();
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _leftClick = false;
            if (e.Button == MouseButtons.Right)
                _rightClick = false;

            dual = false;

            if ((_leftClick == true && _rightClick == false) || (_rightClick == true && _leftClick == false))
            {
                startPos =_lastDrawnRectangle.Location;
            }

            if (_leftClick == false && _rightClick == false)
            {
                if(_lastDrawnRectangle.Width>0 && _lastDrawnRectangle.Height>0)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else if (_lastDrawnRectangle.Width == 0 && _lastDrawnRectangle.Height == 0)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    this.Close();
                }
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (drawing)
            {
                _lastDrawnRectangle = GetNewRectangleToDraw();
                e.Graphics.DrawRectangle(Pens.Red, LastDrawnRectangle);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Canvas";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
        }
    }
}

