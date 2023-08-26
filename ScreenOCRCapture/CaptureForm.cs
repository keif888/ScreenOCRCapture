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
        // Mouse Down Point
        private Point mdown = new Point();
        
        // The image that was captured
        public Bitmap image { get; set; }

        // The rectangle that has been drawn with the mouse
        public Rectangle captureArea { get; set; }

        public CaptureForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            captureArea = new Rectangle();
            image = new Bitmap(1, 1);
        }

        /// <summary>
        /// Load a bitmap into the form and put a transparent mask over it.
        /// </summary>
        /// <param name="screenshot">The image that you want to be able to select a rectangular region on</param>
        public void LoadImage(Bitmap screenshot)
        {
            // Initialise the size of the form based on the image received
            this.Width = screenshot.Width;
            this.Height = screenshot.Height;
            this.Top = 0;
            this.Left = 0;
            // Get rid of the previous image.
            if (image != null)
                image.Dispose();
            // Create a backup of the provided image
            image = new Bitmap(screenshot);
            // Put a transparent light grey mask over the bitmap.
            Graphics g = Graphics.FromImage(screenshot);
            SolidBrush transparentGray = new SolidBrush(Color.FromArgb(125, Color.DimGray));
            g.FillRectangle(transparentGray, new Rectangle(0, 0, this.Width, this.Height));
            // Put the updated bitmap onto the form.
            pbCapture.Image = screenshot;
            // Initialise the other globals.
            mdown.X = 0;
            mdown.Y = 0;
            captureArea = new Rectangle(0, 0, 1, 1);
        }

        /// <summary>
        /// Calculate the size of a rectangle from 2 points
        /// </summary>
        /// <param name="p1">1st corner for the rectangle</param>
        /// <param name="p2">2nd diagonal corner for the rectangle</param>
        /// <returns></returns>
        static public Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
        }

        /// <summary>
        /// Save the location of the mouse when it is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbCapture_MouseDown(object sender, MouseEventArgs e)
        {
            mdown = e.Location;
        }


        /// <summary>
        /// Whilst the mouse is moving, update the rectangle to show region that is to be captured, 
        /// and remove the transparency over it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbCapture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pbCapture.Refresh();
                using (Graphics g = pbCapture.CreateGraphics())
                {
                    captureArea = GetRectangle(mdown, e.Location);
                    g.DrawImage(image, captureArea, captureArea, GraphicsUnit.Pixel);
                    g.DrawRectangle(Pens.Red, captureArea);
                }
            }
        }

        /// <summary>
        /// Mouse Up, close dialog with ok.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbCapture_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
