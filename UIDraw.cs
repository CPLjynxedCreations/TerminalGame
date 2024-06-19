using System;
using GameControllerSpace;
//NOT SURE WHAT SPACES TO USE YET

namespace UIDrawSpace
{
    //DRAWS ANY UI FROM BOARDERS TO TEXT
    public class UIDrawClass
    {
        static public void UIWelcome()
        {
            //WELCOME MESSAGE
        }

        static public void UIHeading()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + @"   ________________________________________________" + "\n" +
                                     @" //================================================\\" + "\n" +
                                     @" +                                                  +" + "\n" +
                                     @" \\================================================//" + "\n" +
                                     @"  |                                                |");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static public void UIBoarder()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@" //================================================\\" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @"||                                                  ||" + "\n" +
                                     @" \\================================================//" + "\n");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
