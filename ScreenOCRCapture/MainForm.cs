using System.Text;
using TesseractOCR;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace ScreenOCRCapture
{
    public partial class MainForm : Form
    {
        private CaptureForm cf;
        private TesseractOCR.Enums.Language language;
        private Bitmap imageToRemove;
        private Color colourToReplaceWith;
        private List<Replacements> imagesToReplace = new List<Replacements>();
        private System.Drawing.Point mdown = new System.Drawing.Point();
        public Rectangle captureArea = new Rectangle();
        public MainForm()
        {
            InitializeComponent();
            cf = new CaptureForm();
            language = TesseractOCR.Enums.Language.English;
            imageToRemove = new Bitmap(1, 1);
            colourToReplaceWith = Color.White;
        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Remove any text in the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbCapturedText.Text = String.Empty;
        }

        /// <summary>
        /// Grab a screen shot and OCR it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void captureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bm))
                {
                    g.CopyFromScreen(0, 0, 0, 0, bm.Size);

                    cf.LoadImage(bm);
                    cf.ShowDialog();
                    if (cf.image != null)
                    {
                        this.pbCapturedImage.Image = cf.image.Clone(cf.captureArea, System.Drawing.Imaging.PixelFormat.DontCare);
                    }
                    this.Show();
                }
            }
        }

        /// <summary>
        /// Convert a passed in bitmap into a byte array
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public static byte[] ImageToByte(System.Drawing.Image img)
        {
            ImageConverter converter = new ImageConverter();
            object? returnValue = converter.ConvertTo(img, typeof(byte[]));
            if (returnValue != null)
                return (byte[])returnValue;
            else
                return (byte[])new byte[0];
        }

        private void oCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cf.Hide();
            //using Bitmap bm = cf.image.Clone(cf.captureArea, System.Drawing.Imaging.PixelFormat.DontCare);
            Bitmap bm = (Bitmap)pbCapturedImage.Image;

            //string templateFileName = @"D:\Temp\AllianceMembers_Crown.png";
            //if (1 == 1)
            //{
            //    using (System.Drawing.Bitmap templateImage = new Bitmap(templateFileName))
            //    {
            //        using (Bitmap greySource = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(bm))
            //        {
            //            using (Bitmap greyTemplate = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(templateImage))
            //            {
            //                var tm = new ExhaustiveTemplateMatching(0.9f);
            //                TemplateMatch[] matchings = tm.ProcessImage(greySource, greyTemplate);

            //                // remove found matchings
            //                Rectangle rectangle = new Rectangle(0, 0, bm.Width, bm.Height);
            //                BitmapData data = bm.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
            //                Color clear = System.Drawing.ColorTranslator.FromHtml("#EFEFEF");

            //                foreach (TemplateMatch m in matchings)
            //                {
            //                    Drawing.FillRectangle(data, m.Rectangle, clear);
            //                }
            //                bm.UnlockBits(data);
            //            }
            //        }
            //    }
            //}

            //pbCapturedImage.Image = new Bitmap(bm);

            // bm.Save(@"D:\Temp\Testing.png");

            //Microsoft.Extensions.Logging.ILogger logger = new TesseractOCR.Loggers.File("tesseract.log");
            //using var tEngine = new Engine("./tessdata", TesseractOCR.Enums.Language.ChineseSimplified, TesseractOCR.Enums.EngineMode.Default, null, null, false, logger);

            // OCR the rectangle's text.
            //using var tEngine = new Engine("./tessdata", "eng+chi_sim+jpn+kor", TesseractOCR.Enums.EngineMode.Default);
            using var tEngine = new Engine("./tessdata", language, TesseractOCR.Enums.EngineMode.Default);
            using var img = TesseractOCR.Pix.Image.LoadFromMemory(ImageToByte(bm));
            using var page = tEngine.Process(img, TesseractOCR.Enums.PageSegMode.SparseTextOsd);

            StringBuilder result = new StringBuilder();
            result.Append(tbCapturedText.Text);

            foreach (var block in page.Layout)
            {
                int Length = block.Text.ReplaceLineEndings().Trim().Length;
                if (Length != 0)
                    result.AppendLine(block.Text.ReplaceLineEndings());
            }
            tbCapturedText.Text = result.ToString();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chineseToolStripMenuItem.Checked = false;
            japaneseToolStripMenuItem.Checked = false;
            koreanToolStripMenuItem.Checked = false;
            language = TesseractOCR.Enums.Language.English;
        }

        private void chineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = false;
            japaneseToolStripMenuItem.Checked = false;
            koreanToolStripMenuItem.Checked = false;
            language = TesseractOCR.Enums.Language.ChineseSimplified;
        }

        private void koreanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = false;
            japaneseToolStripMenuItem.Checked = false;
            chineseToolStripMenuItem.Checked = false;
            language = TesseractOCR.Enums.Language.Korean;
        }

        private void japaneseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.Checked = false;
            koreanToolStripMenuItem.Checked = false;
            chineseToolStripMenuItem.Checked = false;
            language = TesseractOCR.Enums.Language.Japanese;
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bm = (Bitmap)pbCapturedImage.Image;
            using (Bitmap greySource = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(bm))
            {
                foreach (Replacements replacement in imagesToReplace)
                {
                    using (System.Drawing.Bitmap templateImage = new System.Drawing.Bitmap(replacement.ImageToRemove))
                    {
                        using (Bitmap greyTemplate = AForge.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply(templateImage))
                        {
                            var tm = new ExhaustiveTemplateMatching(0.9f);
                            TemplateMatch[] matchings = tm.ProcessImage(greySource, greyTemplate);

                            // remove found matchings
                            Rectangle rectangle = new Rectangle(0, 0, bm.Width, bm.Height);
                            BitmapData data = bm.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);

                            foreach (TemplateMatch m in matchings)
                            {
                                Drawing.FillRectangle(data, m.Rectangle, colourToReplaceWith);
                            }
                            bm.UnlockBits(data);
                        }
                    }
                }
            }
            pbCapturedImage.Image = (System.Drawing.Image)bm;
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssLabel.Text = "Drag a box on the Image to select image to replace";
            pbCapturedImage.Cursor = Cursors.Cross;
            pbCapturedImage.MouseDown += PbCapturedImage_MouseDown;
            pbCapturedImage.MouseUp += PbCapturedImage_MouseUp;
            pbCapturedImage.MouseMove += PbCapturedImage_MouseMove;
        }

        static public Rectangle GetRectangle(System.Drawing.Point p1, System.Drawing.Point p2)
        {
            return new Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
        }

        private void PbCapturedImage_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pbCapturedImage.Refresh();
                using (Graphics g = pbCapturedImage.CreateGraphics())
                {
                    captureArea = GetRectangle(mdown, e.Location);
                    g.DrawRectangle(Pens.Red, captureArea);
                }
            }
        }

        private void PbCapturedImage_MouseUp(object? sender, MouseEventArgs e)
        {
            pbCapturedImage.MouseDown -= PbCapturedImage_MouseDown;
            pbCapturedImage.MouseUp -= PbCapturedImage_MouseUp;
            pbCapturedImage.MouseMove -= PbCapturedImage_MouseMove;
            if (imageToRemove != null)
            {
                imageToRemove.Dispose();
            }
            imageToRemove = ((Bitmap)pbCapturedImage.Image).Clone(captureArea, System.Drawing.Imaging.PixelFormat.DontCare);
            pbCapturedImage.Cursor = Cursors.Default;
        }

        private void PbCapturedImage_MouseDown(object? sender, MouseEventArgs e)
        {
            mdown = e.Location;
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tssLabel.Text = "Click on the Image to select replacement colour";
            pbCapturedImage.Cursor = Cursors.Cross;
            pbCapturedImage.Click += PbCapturedImage_Click;
        }

        private void PbCapturedImage_Click(object? sender, EventArgs e)
        {
            if (e != null)
            {
                if (e is MouseEventArgs args)
                {
                    Bitmap bm = (Bitmap)pbCapturedImage.Image;
                    colourToReplaceWith = bm.GetPixel(args.X, args.Y);
                }

                tssLabel.Text = String.Format("Colour Selected is {0}", colourToReplaceWith.ToString());
                pbCapturedImage.Click -= PbCapturedImage_Click;
                pbCapturedImage.Cursor = Cursors.Default;
            }
        }

        private void addToListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replacements replacement = new Replacements
            {
                ColorToReplaceWith = colourToReplaceWith,
                ImageToRemove = new Bitmap(imageToRemove)
            };
            imagesToReplace.Add(replacement);
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagesToReplace.Clear();
        }

    }
}