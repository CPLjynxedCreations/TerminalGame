using System;
using GameControllerSpace;
using UIDrawSpace;

namespace UITextSpace
{
	public class UITextClass
	{
		static public void Header()
		{
            Console.SetCursorPosition(2, Console.CursorTop - 3);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"                      WELCOME                     ");
            Console.SetCursorPosition(52, Console.CursorTop - 1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("+");
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            //Console.SetCursorPosition(0, Console.CursorTop + 2);
        }
    }
}
