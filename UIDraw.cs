using System;
using GameControllerSpace;
using ColorManagerSpace;
using System.Diagnostics;
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
                              @"|7                                                  ||" + "\n" +
                              @"|8                                                  ||" + "\n" +
                              @"|9                                                  ||" + "\n" +
                              @"10                                                  ||" + "\n" +
                              @"11                                                  ||" + "\n" +
                              @"12                                                  ||" + "\n" +
                              @"13                                                  ||" + "\n" +
                              @"14                                                  ||" + "\n" +
                              @"15                                                  ||" + "\n" +
                              @"16                                                  ||" + "\n" +
                              @"17                                                  ||" + "\n" +
                              @"18                                                  ||" + "\n" +
                              @"19                                                  ||" + "\n" +
                              @"20                                                  ||" + "\n" +
                              @"21                                                  ||" + "\n" +
                              @"22                                                  ||" + "\n" +
                              @"23                                                  ||" + "\n" +
                              @"24                                                  ||" + "\n" +
                              @"25                                                  ||" + "\n" +
                              @"26                                                  ||" + "\n" +
                              @"27                                                  ||" + "\n" +
                              @"28                                                  ||" + "\n" +
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

        //SHOP UI WITH COLUMN

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
