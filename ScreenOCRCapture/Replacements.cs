using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenOCRCapture
{
    internal class Replacements
    {
        public Replacements()
        {
            imageToRemove = new Bitmap(1, 1);
            colourToReplaceWith = Color.White;
        }


        private Bitmap imageToRemove;

        public Bitmap ImageToRemove
        {
            get { return imageToRemove; }
            set { imageToRemove = value; }
        }

        private Color colourToReplaceWith;

        public Color ColorToReplaceWith
        {
            get { return colourToReplaceWith; }
            set { colourToReplaceWith = value; }
        }


    }
}
