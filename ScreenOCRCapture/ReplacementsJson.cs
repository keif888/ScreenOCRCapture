using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenOCRCapture
{
    public class ColourText
    {
        public ColourText() { A = 0;R = 0;G = 0;B = 0; }
        public byte A { get; set; }
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
    }

    public class ReplacementsJson
    {
        public ReplacementsJson() {
            bitmapBase64 = string.Empty;
            colorToReplaceWith = new ColourText();
        }
        public string bitmapBase64 { get; set; }
        public ColourText colorToReplaceWith { get; set; }
    }
}
