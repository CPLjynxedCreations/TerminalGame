﻿using System;
using GameControllerSpace;
using UIDrawSpace;

namespace UITextSpace
{
	public class UITextClass
	{
        //make better void name for welcome
		static public void Header()
		{
            Console.SetCursorPosition(2, Console.CursorTop - 31);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"                      WELCOME                     ");
            Console.SetCursorPosition(52, Console.CursorTop - 1);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("+");
            Console.SetCursorPosition(3, Console.CursorTop + 28);
        }
    }
}
