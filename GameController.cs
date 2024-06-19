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
            Console.Clear();
            Console.WriteLine("Please press Alt + Enter to enable fullscreen before continuing");
            //readline "yes"
            Console.ReadLine();
            Console.Clear();
            Console.SetWindowSize(54, 41);
            UIDrawClass.UIHeader();
            UIDrawClass.UIBoarder();
            UIDrawClass.UIFooter();
            UITextClass.Header();
            UITextClass.PlayerReadLine();
        }
    }
}
