using System;
using UIDrawSpace;
using UITextSpace;

namespace ColorManagerSpace
{

    public class ColorManagerClass
    {
        static public void ColorCyan()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        static public void ColorDarkCyan()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }

        static public void ColorReset()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}