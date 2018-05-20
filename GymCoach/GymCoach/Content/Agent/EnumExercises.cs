using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.Agent
{
    //Mucles groups effected
    public enum EnumChest
    {
        BenchPress = 3,              /*https://wger.de/en/exercise/192/view/ */
        InclineBenchPress = 3,       /*https://wger.de/en/exercise/163/view/ */
        DeclineBenchPress = 2,       /*https://wger.de/en/exercise/100/view/ */
        MachinePress = 2,            /*https://www.bodybuilding.com/exercises/machine-bench-press */
        ChestDips = 3,               /*https://wger.de/en/exercise/82/view/ */
        BenchFly = 1,                /*https://wger.de/en/exercise/122/view/ */
        PeckDeck = 1                 /*https://www.livestrong.com/article/150637-the-muscles-used-in-a-pec-deck-machine/ */
    }

    public enum EnumShoulder
    {
        OHBarbellShoulderPress = 3, /*https://wger.de/en/exercise/119/view/shoulder-press-barbell */
        UprightRow = 3,             /*https://wger.de/en/exercise/127/view/ */
        ArnoldPress = 2,            /*https://www.bodybuilding.com/exercises/arnold-dumbbell-press */
        RearDeltFly = 1,            /*https://wger.de/en/exercise/124/view/ */
        LateralDumbbellRaise = 1,   /*https://wger.de/en/exercise/148/view/ */
        FrontDumbbellRaise = 1      /*https://wger.de/en/exercise/233/view/ */
    }
    //Top 10 Tricep - https://www.bodybuilding.com/fun/the-10-best-muscle-building-triceps-exercises
    public enum EnumTricep
    {
        Skullcrusher = 1,            /*https://wger.de/en/exercise/85/view/ */
        CloseGripBenchPress = 2,     /*https://wger.de/en/exercise/217/view/ */
        Dip = 3,                     /*https://wger.de/en/exercise/82/view/ */
        OHRopeExtension = 1,         /*https://wger.de/en/exercise/89/view/ */
        KickBack = 1                 /*https://wger.de/en/exercise/279/view/ */
    }
    //Top 10 Biceps - https://www.bodybuilding.com/content/10-best-muscle-building-biceps-exercises.html
    public enum EnumBicep
    {
        BarbellCurl = 1,            /*https://wger.de/en/exercise/74/view/ */
        CableCurl = 1,              /*https://wger.de/en/exercise/129/view/ */
        BicepCurl = 1,              /*https://wger.de/en/exercise/81/view/ */
        ChinUp = 2,                 /*https://wger.de/en/exercise/181/view/ */
        ReverseBarbellRow = 3,      /*https://wger.de/en/exercise/110/view/ */
        RopeHammerCurl = 1,         /*https://wger.de/en/exercise/138/view/ */
        InclineCurl = 1,            /*https://wger.de/en/exercise/298/view/ */
        ConcentrationCurl = 1,      /*https://wger.de/en/exercise/275/view/ */
        PreacherCurl = 1,           /*https://wger.de/en/exercise/193/view/ */
        BarbellDragCurl = 1         /*https://www.bodybuilding.com/exercises/drag-curl */
    }
    //Top 10 Back - https://www.bodybuilding.com/content/10-best-muscle-building-back-exercises.html
    public enum EnumBack
    {
        Deadlift = 3,               /*https://wger.de/en/exercise/105/view/ */
        PullUp = 4,                 /*https://wger.de/en/exercise/107/view/ */
        TBarRow = 3,                /*https://wger.de/en/exercise/106/view/ */
        CableRow = 1,               /*https://wger.de/en/exercise/108/view/ */
        BentOverRow = 3,            /*https://wger.de/en/exercise/109/view/ */
        CloseGripLatPullDown = 1,   /*https://wger.de/en/exercise/213/view/ */
        DumbbellRow = 1,            /*https://www.bodybuilding.com/exercises/bent-over-two-dumbbell-row */
        StraightArmPullDown = 2     /*https://wger.de/en/exercise/216/view/ */

    }

    //Top 10 Legs - https://www.bodybuilding.com/content/10-best-muscle-building-leg-exercises.html
    public enum EnumQuad
    {
        Squat = 3,                  /*https://wger.de/en/exercise/111/view/squats */
        PowerClean = 2,             /*https://wger.de/en/exercise/189/view/ */
        BulgarianSplitSquat = 2,    /*https://www.livestrong.com/article/551394-what-muscles-do-hungarian-split-squats-work/ */
        HackSquat = 2,              /*https://wger.de/en/exercise/407/view/ */
        DumbbellLunge = 2,          /*https://wger.de/en/exercise/112/view/ */
        LegPress = 2,               /*https://wger.de/en/exercise/115/view/ */
        LegPressHack = 1            /*https://wger.de/en/exercise/130/view/ */
    }

    public enum EnumCalf
    {
        SeatedCalfRaise = 1,        /*https://www.bodybuilding.com/fun/wotw50.htm */
        ReverseCalfRaise = 1,       /*https://www.bodybuilding.com/fun/wotw50.htm */
        StandingCalfRaise = 1       /*https://www.bodybuilding.com/fun/wotw50.htm */
    }

    public enum EnumHamstring
    {
        RomanianDeadlift = 2,       /*https://www.bodybuilding.com/fun/issa63.htm */
        LegCurls = 1,               /*https://wger.de/en/exercise/118/view/ */
    }

    public enum EnumGlute
    {
        FrontSquat = 2              /*https://wger.de/en/exercise/191/view/ */
    }
}