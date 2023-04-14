using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsivecolorproject
{
    public static class Klibrary
    {
        //Use e.g (-0.1, 0.1) just decimals to change the color :D
        public static Color ChangeColorBrightness(Color color, double correctFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctFactor < 0) //Darker
            {
                correctFactor += 1;
                red *= correctFactor;
                green *= correctFactor;
                blue *= correctFactor;
            } 
            else  //More shiny :D
            {
                red = (255 - red) * correctFactor + red;
                green = (255 - green) * correctFactor + green;
                blue = (255 - blue) * correctFactor + blue;
            }

            return Color.FromArgb((byte)red, (byte)green, (byte)blue);
        }
    }
}
