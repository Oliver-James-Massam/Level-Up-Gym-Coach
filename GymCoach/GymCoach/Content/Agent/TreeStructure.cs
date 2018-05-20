using GymCoach.Content.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.Agent
{
    public static class TreeStructure
    {
        //All Exercises
        private static List<Exercise> exercises;
        //Tree
        private static List<Exercise> upperBody;
        private static List<Exercise> lowerBody;
        private static List<Exercise> push;
        private static List<Exercise> pull;
        
        //Muscles
        private static List<Exercise> chest;
        private static List<Exercise> shoulder;
        private static List<Exercise> tricep;
        private static List<Exercise> bicep;
        private static List<Exercise> back;
        private static List<Exercise> legs;
        private static List<Exercise> lowerLegs;
        private static List<Exercise> upperLegs;

        //Equipment
        private static List<Exercise> barbell;
        private static List<Exercise> dumbbell;
        private static List<Exercise> body;
        private static List<Exercise> machine;

        //Database
        private static DataAccess db = new DataAccess();

        public static List<Exercise> getExercises()
        {
            if(exercises == null)
            {
                exercises = db.getExercises();
            }
            return exercises;
        }
        // provide a category to minimize searching and return a smaller tree
        public static List<Exercise> getCategory(String category)
        {
            List<Exercise> categoryList = new List<Exercise>();
            if(exercises == null)
            {
                getExercises();
            }
            foreach (Exercise i in exercises)
            {
                if (i.getPrimaryMuscle().Equals(category))
                {
                    categoryList.Add(i);
                }
            }
            return categoryList;
        }

        public static List<Exercise> getUpperBody()
        {
            List<Exercise> temp = new List<Exercise>();
            if (upperBody == null)
            {
                upperBody = getPush();
                temp = getPull();
                upperBody.AddRange(temp);
            }
            return upperBody;
        }

        public static List<Exercise> getLowerBody()
        {
            if (lowerBody == null)
            {
                lowerBody = getLegs();
            }
            return lowerBody;
        }

        public static List<Exercise> getPush()
        {
            List<Exercise> temp = new List<Exercise>();
            if (push == null)
            {
                push = getChest();
                temp = getShoulder();
                push.AddRange(temp);
                temp = getTricep();
                push.AddRange(temp);
            }
            return push;
        }

        public static List<Exercise> getPull()
        {
            List<Exercise> temp = new List<Exercise>();
            if (pull == null)
            {
                pull = getBack();
                temp = getBicep();
                pull.AddRange(temp);
            }
            return pull;
        }

        public static List<Exercise> getLegs()
        {
            if (legs == null)
            {
                legs = new List<Exercise>();
                if(lowerLegs == null)
                {
                    lowerLegs = getLowerLegs();
                }

                if(upperLegs == null)
                {
                    upperLegs = getUpperLegs();
                }
                legs.AddRange(upperLegs);
                legs.AddRange(lowerLegs);
            }
            return legs;
        }

        public static List<Exercise> getLowerLegs()
        {
            if (lowerLegs == null)
            {
                lowerLegs = getCategory(TrainingType.CALF);
            }
            return lowerLegs;
        }

        public static List<Exercise> getUpperLegs()
        {
            List<Exercise> temp = new List<Exercise>();
            if (upperLegs == null)
            {
                upperLegs = getCategory(TrainingType.QUAD);
                temp = getCategory(TrainingType.HAMSTRING);
                upperLegs.AddRange(temp);
                temp = getCategory(TrainingType.GLUTE);
                upperLegs.AddRange(temp);
            }
            return upperLegs;
        }

        public static List<Exercise> getChest()
        {
            if (chest == null)
            {
                chest = getCategory(TrainingType.CHEST);
            }
            return chest;
        }

        public static List<Exercise> getShoulder()
        {
            if (shoulder == null)
            {
                shoulder = getCategory(TrainingType.SHOULDER);
            }
            return shoulder;
        }

        public static List<Exercise> getTricep()
        {
            if (tricep == null)
            {
                tricep = getCategory(TrainingType.TRICEP);
            }
            return tricep;
        }

        public static List<Exercise> getBicep()
        {
            if (bicep == null)
            {
                bicep = getCategory(TrainingType.BICEP);
            }
            return bicep;
        }

        public static List<Exercise> getBack()
        {
            if (back == null)
            {
                back = getCategory(TrainingType.BACK);
            }
            return back;
        }

        public static List<Exercise> getBarbell()
        {
            if (barbell == null)
            {
                barbell = getCategory(TrainingType.BARBELL);
            }
            return barbell;
        }

        public static List<Exercise> getDumbbell()
        {
            if (dumbbell == null)
            {
                dumbbell = getCategory(TrainingType.DUMBBELL);
            }
            return dumbbell;
        }

        public static List<Exercise> getBody()
        {
            if (body == null)
            {
                body = getCategory(TrainingType.BODY);
            }
            return body;
        }

        public static List<Exercise> getMachine()
        {
            if (machine == null)
            {
                machine = getCategory(TrainingType.MACHINE);
            }
            return machine;
        }
    }
}