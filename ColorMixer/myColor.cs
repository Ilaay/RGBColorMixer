using System;
using System.Drawing;
using Console = Colorful.Console;

namespace ColorMixer
{
    class myColor
    {
        byte R;
        byte G;
        byte B;

        public myColor(byte r, byte g, byte b)
        {
           R = r;
           G = g;
           B = b;
        }
        public myColor()
        {
            R = 0;
            G = 0;
            B = 0;
        }

        public void ShowUp()
        {
            Console.Write("This Color", Color.FromArgb(R, G, B));
        }

        public static void MixResult(myColor resultColor, myColor firstColor, myColor secondColor)
        {
            resultColor.R = Convert.ToByte((firstColor.R + secondColor.R) / 2);
            resultColor.G = Convert.ToByte((firstColor.G + secondColor.G) / 2);
            resultColor.B = Convert.ToByte((firstColor.B + secondColor.B) / 2);
            resultColor.ShowUp();
        }

    }
}
