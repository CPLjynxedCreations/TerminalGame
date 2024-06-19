using System;
using GameControllerSpace;
using UIDrawSpace;
using ColorManagerSpace;

namespace UITextSpace
{
	public class UITextClass
	{
        static int intHeaderTextLine = 3;
        static int intFooterTextLine = 32;
        static int intWriteText = 7;
        static int intBoarder = 2;
        //make better void name for welcome
		static public void Header()
		{
            Console.SetCursorPosition(23, intHeaderTextLine);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("WELCOME");
            //Console.SetCursorPosition(52, Console.CursorTop - 1);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(intBoarder + 1, intFooterTextLine);

            // re adjust for easier use and more generic
            // create ints for line and character numbers
        }

        static public void PlayerReadLine()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ReadLine();
            Console.SetCursorPosition(3, Console.CursorTop + 0);
        }
    }
}
