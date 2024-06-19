using System;
using PlayerLogInSpace;
using PlayerDetailSpace;
using PlayerNavigationSpace;
using ColorManagerSpace;
using UIDrawSpace;
using UITextSpace;


namespace GameControllerSpace
{
    //RUNS THE MAINFRAME OF THE GAME
    public class GameControllerClass
    {

        static void Main()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine("Please press Alt + Enter to enable fullscreen before continuing");
            //readline "yes"
                //read == yes?
            Console.ReadLine();
            Console.Clear();
            UIDrawClass.UIHeader();
            UIDrawClass.UIBoarder();
            UIDrawClass.UIFooter();
            UITextClass.HeaderWelcome();
            UITextClass.Join();
            //hey
            UITextClass.PlayerReadLine();
        }
    }
}
