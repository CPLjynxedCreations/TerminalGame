using System;
using GameControllerSpace;
using ColorManagerSpace;
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
            ColorManagerClass.ColorDarkCyan();
            Console.WriteLine("\n" + @"   ________________________________________________" + "\n" +
                                     @" //================================================\\" + "\n" +
                                     @" +                                                  +" + "\n" +
                                     @" \\================================================//" + "\n" +
                                     @"  |                                                |");
            ColorManagerClass.ColorReset();
        }

        // VOID TO CHANGE HEADING TEXT

        static public void UIBoarder()
        {
            ColorManagerClass.ColorDarkCyan();
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
            ColorManagerClass.ColorReset();
        }

        static public void UIFooter()
        {
            ColorManagerClass.ColorDarkCyan();
            Console.WriteLine(@"  |                                                |" + "\n" +
                              @" //================================================\\" + "\n" +
                              @" +                                                  +" + "\n" +
                              @" \\================================================//");
            ColorManagerClass.ColorReset();
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
