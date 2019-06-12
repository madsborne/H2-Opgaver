using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SolidColorPicker
{
    class ColorHandler
    {
        public SolidColorBrush SliderColor(byte rColor, byte gColor, byte bColor)
        {
            SolidColorBrush newColor = new SolidColorBrush(Color.FromRgb(bColor, gColor, rColor));

            return newColor;
        }

        public string RGBtoHex(byte rColor, byte gColor, byte bColor)
        {
            Color currentColor = Color.FromRgb(bColor, gColor, rColor);
            return "#" + currentColor.R.ToString("X2") + currentColor.G.ToString("X2") + currentColor.B.ToString("X2");
        }
    }
}
