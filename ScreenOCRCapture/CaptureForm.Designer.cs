namespace ScreenOCRCapture
{
    partial class CaptureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCapture
            // 
            this.pbCapture.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCapture.Location = new System.Drawing.Point(0, 0);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.Size = new System.Drawing.Size(800, 450);
            this.pbCapture.TabIndex = 0;
            this.pbCapture.TabStop = false;
            this.pbCapture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCapture_MouseDown);
            this.pbCapture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCapture_MouseMove);
            this.pbCapture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbCapture_MouseUp);
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCapture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CaptureForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbCapture;
    }
}