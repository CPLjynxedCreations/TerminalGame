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

        static public void UIHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n" + @"   ________________________________________________" + "\n" +
                                     @" //================================================\\" + "\n" +
                                     @" +                                                  +" + "\n" +
                                     @" \\================================================//" + "\n" +
                                     @"  |                                                |");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // VOID TO CHANGE HEADING TEXT
        // MOVE CURSOR TO POSITION

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
                              @" \\================================================//");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static public void UIFooter()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"  |                                                |" + "\n" +
                              @" //================================================\\" + "\n" +
                              @" +                                                  +" + "\n" +
                              @" \\================================================//");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // VOID TO CHANGE TEXT
        // CHANGE CURSOR POSTITION FOR TEXT
        // ONE FOR EACH LINE NUMBER? CHANGE LINE 1,2,3
        // CHANGE TEXT COLOR TO BOARDER AND ADD END
        // position 52, - 1 line fill ||
        // THEN RELATIVE MOVE POSITION BACK DOWN

        // VOID TO FILL END OF BOARDER
        // CHANGE TEXT COLOR TO BOARDER AND ADD END
        // position 52, - 1 line fill ||
    }
}
