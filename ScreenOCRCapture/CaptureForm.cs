using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenOCRCapture
{
    public partial class CaptureForm : Form
    {
        private Point mdown = new Point();
        public Bitmap image { get; set; }
        public Rectangle captureArea { get; set; }

        public CaptureForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            captureArea = new Rectangle();
            image = new Bitmap(1, 1);
        }

        public void LoadImage(Bitmap screenshot)
        {
            this.Width = screenshot.Width;
            this.Height = screenshot.Height;
            this.Top = 0;
            this.Left = 0;
            pbCapture.Image = screenshot;
            if (image != null)
                image.Dispose();
            image = new Bitmap(screenshot);
            mdown.X = 0;
            mdown.Y = 0;
            captureArea = new Rectangle(0, 0, 1, 1);
        }

        static public Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
        }

        private void pbCapture_MouseDown(object sender, MouseEventArgs e)
        {
            mdown = e.Location;
        }

        private void pbCapture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pbCapture.Refresh();
                using (Graphics g = pbCapture.CreateGraphics())
                {
                    captureArea = GetRectangle(mdown, e.Location);
                    g.DrawRectangle(Pens.Red, captureArea);
                }
            }
        }

        private void pbCapture_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
