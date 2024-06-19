using System;
using PlayerLogInSpace;
using PlayerDetailSpace;
using PlayerNavigationSpace;
using UIDrawSpace;
using UITextSpace;


namespace GameControllerSpace
{
    //RUNS THE MAINFRAME OF THE GAME
    public class GameControllerClass
    {
        
        static void Main()
        {
            Console.Clear();
            UIDrawClass.UIHeading();
            UITextClass.Header();
            UIDrawClass.UIBoarder();
            Console.ReadLine();
            //Console.Clear();
            //UIDrawClass.UIBoarder();
            //Console.SetCursorPosition(0, Console.CursorTop - 4);
            //Console.SetCursorPosition(0, Console.CursorTop + 2);
        }
    }
}
