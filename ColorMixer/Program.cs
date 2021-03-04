using System;
using System.Drawing;
using Console = Colorful.Console;

namespace ColorMixer
{
    class Program
    {
        static void NewColorMixing()
        {
            Console.WriteLine("  First Color: ");
            System.Console.Write("R: ");
            byte x = Convert.ToByte(Console.ReadLine());
            System.Console.Write("G: ");
            byte y = Convert.ToByte(Console.ReadLine());
            System.Console.Write("B: ");
            byte z = Convert.ToByte(Console.ReadLine());
            myColor firstColor = new myColor(x, y, z);


            Console.WriteLine("  Second Color: ");
            System.Console.Write("R: ");
            byte x2 = Convert.ToByte(Console.ReadLine());
            System.Console.Write("G: ");
            byte y2 = Convert.ToByte(Console.ReadLine());
            System.Console.Write("B: ");
            byte z2 = Convert.ToByte(Console.ReadLine());
            myColor secondColor = new myColor(x2, y2, z2);
            firstColor.ShowUp();
            System.Console.Write(" + ");
            secondColor.ShowUp();
            System.Console.Write(" = ");


            myColor resultColor = new myColor();
            myColor.MixResult(resultColor, firstColor, secondColor);
            System.Console.WriteLine("\n");
        }
        static void Main(string[] args) //rgb color mixer
        {
            Console.ForegroundColor = Color.White;
            Console.WriteLine("Programm to mix the RGB colors \n");
            while (true)
            {
                NewColorMixing();
            }
        }
    }
}
