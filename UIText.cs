using System;
using GameControllerSpace;
using UIDrawSpace;
using ColorManagerSpace;

namespace UITextSpace
{
    public class UITextClass
    {
        static string strClearSpace = "                                                ";
        static public string strPlayerTextInput;
        static int intHeaderTextLine = 3;
        static int intPlayerReplyLine = 30;
        static int intFooterTextLine = 32;
        //static int intWriteText = 7;
        static int intTextStart = 4;
        static int intBoarder = 3;

        static public void HeaderWelcome()
        {
            Console.SetCursorPosition(23, intHeaderTextLine);
            ColorManagerClass.ColorCyan();
            Console.WriteLine("WELCOME");
            ColorManagerClass.ColorReset();

            // re adjust for easier use and more generic
            // create ints for line and character numbers
        }

        static public void Join()
        {
            Console.SetCursorPosition(intBoarder, 7); // line 1
            Console.WriteLine("Join us");
        }

        static public void PlayerReadLine()
        {
            Console.CursorVisible = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(intTextStart, intFooterTextLine);
            strPlayerTextInput = Console.ReadLine();
            Console.SetCursorPosition(3, intFooterTextLine);
            Console.WriteLine(strClearSpace);
            Console.SetCursorPosition(3, intPlayerReplyLine);
            Console.WriteLine(strClearSpace);
            Console.SetCursorPosition(intTextStart, intPlayerReplyLine);
            Console.WriteLine(strPlayerTextInput);
            Console.SetCursorPosition(intTextStart, intFooterTextLine);
            Console.CursorVisible = false;
        }
    }
}
