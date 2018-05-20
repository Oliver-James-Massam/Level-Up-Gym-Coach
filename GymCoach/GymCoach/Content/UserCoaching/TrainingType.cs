using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content
{
    public static class TrainingType
    {
        //Constants - Groups
        public const String FULLBODY = "FullBody";
        public const String UPPERBODY = "UpperBody";
        public const String LOWERBODY = "LowerBody";
        public const String PUSH = "Push";
        public const String PULL = "Pull";
        public const String UPPERLEG = "UpperLeg";
        public const String LOWERLEG = "LowerLeg";
        
        //Constants - Equipment
        public const String BARBELL = "Barbell";
        public const String DUMBBELL = "Dumbbell";
        public const String BODY = "Body";
        public const String MACHINE = "Machine";
        //Constants - Muscles
        public const String CHEST = "Chest";
        public const String SHOULDER = "Shoulder";
        public const String TRICEP = "Tricep";
        public const String BICEP = "Bicep";
        public const String BACK = "Back";
        public const String QUAD = "Quad";
        public const String GLUTE = "Glute";
        public const String CALF = "Calf";
        public const String HAMSTRING = "Hamstring";
        public const String NOT_APPLICABLE = "N/A";
        //Training Name
        public const String NAME_ENDURANCE = "Endurance";
        public const String NAME_STRENGTH = "Strength";
        public const String NAME_HYPERTROPHY = "Hypertrophy";
        //Endurance reps and sets
        public const int REPS_NORMAL_ENDURANCE = 15;
        public const int REPS_LIGHT_ENDURANCE = 11;
        public const int REPS_HEAVY_ENDURANCE = 20;
        public const int SETS_ENDURANCE = 2;
        public const int REST_SECONDS_NORMAL_ENDURANCE = 30;
        public const int REST_SECONDS_EXTENDED_ENDURANCE = 60;
        //Strength reps and sets
        public const int REPS_NORMAL_STRENGTH = 5;
        public const int REPS_LIGHT_STRENGTH = 2;
        public const int REPS_HEAVY_STRENGTH = 8;
        public const int SETS_STRENGTH = 5;
        public const int REST_SECONDS_NORMAL_STRENGTH = 180;
        public const int REST_SECONDS_EXTENDED_STRENGTH = 450;
        //Hypertrophy reps and sets
        public const int REPS_NORMAL_HYPERTROPHY = 8;
        public const int REPS_LIGHT_HYPERTROPHY = 4;
        public const int REPS_HEAVY_HYPERTROPHY = 12;
        public const int SETS_HYPERTROPHY = 3;
        public const int REST_SECONDS_NORMAL_HYPERTROPHY = 90;
        public const int REST_SECONDS_EXTENDED_HYPERTROPHY = 120;
        //Type Data
        private static String trainingName = NAME_HYPERTROPHY;
        private static double freeWeightIncrement = 2;
        private static double plateWeightIncrement = 2.5;
        private static double machineWeightIncrement = 2;

        public static String getTrainingName()
        {
            return trainingName;
        }

        public static void setTrainingName(String name)
        {
            trainingName = name;
        }

        public static double getFreeWeightIncrement()
        {
            return freeWeightIncrement;
        }

        public static void setFreeWeightIncrement(double freeWeight)
        {
            freeWeightIncrement = freeWeight;
        }

        public static double getPlateWeightIncrement()
        {
            return plateWeightIncrement;
        }

        public static void setPlateWeightIncrement(double plateWeight)
        {
            plateWeightIncrement = plateWeight;
        }

        public static double getMachineWeightIncrement()
        {
            return machineWeightIncrement;
        }

        public static void setMachineWeightIncrement(double machineWeight)
        {
            machineWeightIncrement = machineWeight;
        }
    }
}