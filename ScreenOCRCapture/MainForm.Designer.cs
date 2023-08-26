namespace ScreenOCRCapture
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            captureToolStripMenuItem = new ToolStripMenuItem();
            replacementsToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            colourToolStripMenuItem = new ToolStripMenuItem();
            addToListToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            executeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            clearListToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            stripLineEndingsToolStripMenuItem = new ToolStripMenuItem();
            oCRToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            chineseToolStripMenuItem = new ToolStripMenuItem();
            koreanToolStripMenuItem = new ToolStripMenuItem();
            japaneseToolStripMenuItem = new ToolStripMenuItem();
            detectionToolStripMenuItem = new ToolStripMenuItem();
            oSDOnlyToolStripMenuItem = new ToolStripMenuItem();
            autoPageWithOSDToolStripMenuItem = new ToolStripMenuItem();
            autoPageToolStripMenuItem = new ToolStripMenuItem();
            autoNoOSDOCRToolStripMenuItem = new ToolStripMenuItem();
            singleColumnToolStripMenuItem = new ToolStripMenuItem();
            singleBlockVertToolStripMenuItem = new ToolStripMenuItem();
            singleBlockToolStripMenuItem = new ToolStripMenuItem();
            singleLineToolStripMenuItem = new ToolStripMenuItem();
            singleWordToolStripMenuItem = new ToolStripMenuItem();
            wordInCircleToolStripMenuItem = new ToolStripMenuItem();
            singleCharacterToolStripMenuItem = new ToolStripMenuItem();
            sparseTextToolStripMenuItem = new ToolStripMenuItem();
            sparseTextWithOSDToolStripMenuItem = new ToolStripMenuItem();
            rawLineToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tssLabel = new ToolStripStatusLabel();
            tbCapturedText = new TextBox();
            splitContainer1 = new SplitContainer();
            pbCapturedImage = new PictureBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCapturedImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, captureToolStripMenuItem, replacementsToolStripMenuItem, oCRToolStripMenuItem, languageToolStripMenuItem, detectionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(98, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(98, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(95, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(98, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // captureToolStripMenuItem
            // 
            captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            captureToolStripMenuItem.Size = new Size(61, 20);
            captureToolStripMenuItem.Text = "&Capture";
            captureToolStripMenuItem.Click += captureToolStripMenuItem_Click;
            // 
            // replacementsToolStripMenuItem
            // 
            replacementsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageToolStripMenuItem, colourToolStripMenuItem, addToListToolStripMenuItem, toolStripMenuItem2, executeToolStripMenuItem, toolStripMenuItem3, clearListToolStripMenuItem, toolStripMenuItem4, stripLineEndingsToolStripMenuItem });
            replacementsToolStripMenuItem.Name = "replacementsToolStripMenuItem";
            replacementsToolStripMenuItem.Size = new Size(63, 20);
            replacementsToolStripMenuItem.Text = "&Cleanup";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(180, 22);
            imageToolStripMenuItem.Text = "&Image";
            imageToolStripMenuItem.Click += imageToolStripMenuItem_Click;
            // 
            // colourToolStripMenuItem
            // 
            colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            colourToolStripMenuItem.Size = new Size(180, 22);
            colourToolStripMenuItem.Text = "&Colour";
            colourToolStripMenuItem.Click += colourToolStripMenuItem_Click;
            // 
            // addToListToolStripMenuItem
            // 
            addToListToolStripMenuItem.Name = "addToListToolStripMenuItem";
            addToListToolStripMenuItem.Size = new Size(180, 22);
            addToListToolStripMenuItem.Text = "&Add To List";
            addToListToolStripMenuItem.Click += addToListToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // executeToolStripMenuItem
            // 
            executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            executeToolStripMenuItem.Size = new Size(180, 22);
            executeToolStripMenuItem.Text = "&Execute";
            executeToolStripMenuItem.Click += executeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(177, 6);
            // 
            // clearListToolStripMenuItem
            // 
            clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            clearListToolStripMenuItem.Size = new Size(180, 22);
            clearListToolStripMenuItem.Text = "Clear &List";
            clearListToolStripMenuItem.Click += clearListToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(177, 6);
            // 
            // stripLineEndingsToolStripMenuItem
            // 
            stripLineEndingsToolStripMenuItem.CheckOnClick = true;
            stripLineEndingsToolStripMenuItem.Name = "stripLineEndingsToolStripMenuItem";
            stripLineEndingsToolStripMenuItem.Size = new Size(180, 22);
            stripLineEndingsToolStripMenuItem.Text = "Strip Line Endings?";
            // 
            // oCRToolStripMenuItem
            // 
            oCRToolStripMenuItem.Name = "oCRToolStripMenuItem";
            oCRToolStripMenuItem.Size = new Size(43, 20);
            oCRToolStripMenuItem.Text = "&OCR";
            oCRToolStripMenuItem.Click += oCRToolStripMenuItem_Click;
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, chineseToolStripMenuItem, koreanToolStripMenuItem, japaneseToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(71, 20);
            languageToolStripMenuItem.Text = "&Language";
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Checked = true;
            englishToolStripMenuItem.CheckOnClick = true;
            englishToolStripMenuItem.CheckState = CheckState.Checked;
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(121, 22);
            englishToolStripMenuItem.Text = "&English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // chineseToolStripMenuItem
            // 
            chineseToolStripMenuItem.CheckOnClick = true;
            chineseToolStripMenuItem.Name = "chineseToolStripMenuItem";
            chineseToolStripMenuItem.Size = new Size(121, 22);
            chineseToolStripMenuItem.Text = "&Chinese";
            chineseToolStripMenuItem.Click += chineseToolStripMenuItem_Click;
            // 
            // koreanToolStripMenuItem
            // 
            koreanToolStripMenuItem.CheckOnClick = true;
            koreanToolStripMenuItem.Name = "koreanToolStripMenuItem";
            koreanToolStripMenuItem.Size = new Size(121, 22);
            koreanToolStripMenuItem.Text = "&Korean";
            koreanToolStripMenuItem.Click += koreanToolStripMenuItem_Click;
            // 
            // japaneseToolStripMenuItem
            // 
            japaneseToolStripMenuItem.CheckOnClick = true;
            japaneseToolStripMenuItem.Name = "japaneseToolStripMenuItem";
            japaneseToolStripMenuItem.Size = new Size(121, 22);
            japaneseToolStripMenuItem.Text = "&Japanese";
            japaneseToolStripMenuItem.Click += japaneseToolStripMenuItem_Click;
            // 
            // detectionToolStripMenuItem
            // 
            detectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oSDOnlyToolStripMenuItem, autoPageWithOSDToolStripMenuItem, autoPageToolStripMenuItem, autoNoOSDOCRToolStripMenuItem, singleColumnToolStripMenuItem, singleBlockVertToolStripMenuItem, singleBlockToolStripMenuItem, singleLineToolStripMenuItem, singleWordToolStripMenuItem, wordInCircleToolStripMenuItem, singleCharacterToolStripMenuItem, sparseTextToolStripMenuItem, sparseTextWithOSDToolStripMenuItem, rawLineToolStripMenuItem });
            detectionToolStripMenuItem.Name = "detectionToolStripMenuItem";
            detectionToolStripMenuItem.Size = new Size(122, 20);
            detectionToolStripMenuItem.Text = "&Page Segmentation";
            // 
            // oSDOnlyToolStripMenuItem
            // 
            oSDOnlyToolStripMenuItem.CheckOnClick = true;
            oSDOnlyToolStripMenuItem.Name = "oSDOnlyToolStripMenuItem";
            oSDOnlyToolStripMenuItem.Size = new Size(184, 22);
            oSDOnlyToolStripMenuItem.Text = "OSD Only";
            oSDOnlyToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // autoPageWithOSDToolStripMenuItem
            // 
            autoPageWithOSDToolStripMenuItem.CheckOnClick = true;
            autoPageWithOSDToolStripMenuItem.Name = "autoPageWithOSDToolStripMenuItem";
            autoPageWithOSDToolStripMenuItem.Size = new Size(184, 22);
            autoPageWithOSDToolStripMenuItem.Text = "Auto Page with OSD";
            autoPageWithOSDToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // autoPageToolStripMenuItem
            // 
            autoPageToolStripMenuItem.CheckOnClick = true;
            autoPageToolStripMenuItem.Name = "autoPageToolStripMenuItem";
            autoPageToolStripMenuItem.Size = new Size(184, 22);
            autoPageToolStripMenuItem.Text = "Auto Page";
            autoPageToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // autoNoOSDOCRToolStripMenuItem
            // 
            autoNoOSDOCRToolStripMenuItem.CheckOnClick = true;
            autoNoOSDOCRToolStripMenuItem.Name = "autoNoOSDOCRToolStripMenuItem";
            autoNoOSDOCRToolStripMenuItem.Size = new Size(184, 22);
            autoNoOSDOCRToolStripMenuItem.Text = "Auto No OSD OCR";
            autoNoOSDOCRToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // singleColumnToolStripMenuItem
            // 
            singleColumnToolStripMenuItem.CheckOnClick = true;
            singleColumnToolStripMenuItem.Name = "singleColumnToolStripMenuItem";
            singleColumnToolStripMenuItem.Size = new Size(184, 22);
            singleColumnToolStripMenuItem.Text = "Single Column";
            singleColumnToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // singleBlockVertToolStripMenuItem
            // 
            singleBlockVertToolStripMenuItem.CheckOnClick = true;
            singleBlockVertToolStripMenuItem.Name = "singleBlockVertToolStripMenuItem";
            singleBlockVertToolStripMenuItem.Size = new Size(184, 22);
            singleBlockVertToolStripMenuItem.Text = "Single Block Vert";
            singleBlockVertToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // singleBlockToolStripMenuItem
            // 
            singleBlockToolStripMenuItem.CheckOnClick = true;
            singleBlockToolStripMenuItem.Name = "singleBlockToolStripMenuItem";
            singleBlockToolStripMenuItem.Size = new Size(184, 22);
            singleBlockToolStripMenuItem.Text = "Single Block";
            singleBlockToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // singleLineToolStripMenuItem
            // 
            singleLineToolStripMenuItem.CheckOnClick = true;
            singleLineToolStripMenuItem.Name = "singleLineToolStripMenuItem";
            singleLineToolStripMenuItem.Size = new Size(184, 22);
            singleLineToolStripMenuItem.Text = "Single Line";
            singleLineToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // singleWordToolStripMenuItem
            // 
            singleWordToolStripMenuItem.CheckOnClick = true;
            singleWordToolStripMenuItem.Name = "singleWordToolStripMenuItem";
            singleWordToolStripMenuItem.Size = new Size(184, 22);
            singleWordToolStripMenuItem.Text = "Single Word";
            singleWordToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // wordInCircleToolStripMenuItem
            // 
            wordInCircleToolStripMenuItem.CheckOnClick = true;
            wordInCircleToolStripMenuItem.Name = "wordInCircleToolStripMenuItem";
            wordInCircleToolStripMenuItem.Size = new Size(184, 22);
            wordInCircleToolStripMenuItem.Text = "Word in Circle";
            wordInCircleToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // singleCharacterToolStripMenuItem
            // 
            singleCharacterToolStripMenuItem.CheckOnClick = true;
            singleCharacterToolStripMenuItem.Name = "singleCharacterToolStripMenuItem";
            singleCharacterToolStripMenuItem.Size = new Size(184, 22);
            singleCharacterToolStripMenuItem.Text = "Single Character";
            singleCharacterToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // sparseTextToolStripMenuItem
            // 
            sparseTextToolStripMenuItem.CheckOnClick = true;
            sparseTextToolStripMenuItem.Name = "sparseTextToolStripMenuItem";
            sparseTextToolStripMenuItem.Size = new Size(184, 22);
            sparseTextToolStripMenuItem.Text = "Sparse Text";
            sparseTextToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // sparseTextWithOSDToolStripMenuItem
            // 
            sparseTextWithOSDToolStripMenuItem.Checked = true;
            sparseTextWithOSDToolStripMenuItem.CheckOnClick = true;
            sparseTextWithOSDToolStripMenuItem.CheckState = CheckState.Checked;
            sparseTextWithOSDToolStripMenuItem.Name = "sparseTextWithOSDToolStripMenuItem";
            sparseTextWithOSDToolStripMenuItem.Size = new Size(184, 22);
            sparseTextWithOSDToolStripMenuItem.Text = "Sparse Text with OSD";
            sparseTextWithOSDToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // rawLineToolStripMenuItem
            // 
            rawLineToolStripMenuItem.CheckOnClick = true;
            rawLineToolStripMenuItem.Name = "rawLineToolStripMenuItem";
            rawLineToolStripMenuItem.Size = new Size(184, 22);
            rawLineToolStripMenuItem.Text = "Raw Line";
            rawLineToolStripMenuItem.Click += pageSegModeToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssLabel
            // 
            tssLabel.Name = "tssLabel";
            tssLabel.Size = new Size(103, 17);
            tssLabel.Text = "Nothing to Report";
            // 
            // tbCapturedText
            // 
            tbCapturedText.Dock = DockStyle.Fill;
            tbCapturedText.Location = new Point(0, 0);
            tbCapturedText.Multiline = true;
            tbCapturedText.Name = "tbCapturedText";
            tbCapturedText.ScrollBars = ScrollBars.Both;
            tbCapturedText.Size = new Size(345, 404);
            tbCapturedText.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tbCapturedText);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(pbCapturedImage);
            splitContainer1.Size = new Size(800, 404);
            splitContainer1.SplitterDistance = 345;
            splitContainer1.TabIndex = 3;
            // 
            // pbCapturedImage
            // 
            pbCapturedImage.Location = new Point(2, 3);
            pbCapturedImage.Name = "pbCapturedImage";
            pbCapturedImage.Size = new Size(30, 30);
            pbCapturedImage.SizeMode = PictureBoxSizeMode.AutoSize;
            pbCapturedImage.TabIndex = 0;
            pbCapturedImage.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Location = new Point(60, 60);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Capture and OCR";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCapturedImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem captureToolStripMenuItem;
        private StatusStrip statusStrip1;
        private TextBox tbCapturedText;
        private ToolStripMenuItem oCRToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem chineseToolStripMenuItem;
        private ToolStripMenuItem koreanToolStripMenuItem;
        private ToolStripMenuItem japaneseToolStripMenuItem;
        private SplitContainer splitContainer1;
        private PictureBox pbCapturedImage;
        private ToolStripMenuItem replacementsToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem colourToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem executeToolStripMenuItem;
        private ToolStripStatusLabel tssLabel;
        private ToolStripMenuItem addToListToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem clearListToolStripMenuItem;
        private ToolStripMenuItem detectionToolStripMenuItem;
        private ToolStripMenuItem oSDOnlyToolStripMenuItem;
        private ToolStripMenuItem autoPageWithOSDToolStripMenuItem;
        private ToolStripMenuItem autoPageToolStripMenuItem;
        private ToolStripMenuItem autoNoOSDOCRToolStripMenuItem;
        private ToolStripMenuItem singleColumnToolStripMenuItem;
        private ToolStripMenuItem singleBlockVertToolStripMenuItem;
        private ToolStripMenuItem singleBlockToolStripMenuItem;
        private ToolStripMenuItem singleLineToolStripMenuItem;
        private ToolStripMenuItem singleWordToolStripMenuItem;
        private ToolStripMenuItem wordInCircleToolStripMenuItem;
        private ToolStripMenuItem singleCharacterToolStripMenuItem;
        private ToolStripMenuItem sparseTextToolStripMenuItem;
        private ToolStripMenuItem sparseTextWithOSDToolStripMenuItem;
        private ToolStripMenuItem rawLineToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem stripLineEndingsToolStripMenuItem;
    }
}