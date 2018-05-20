using GymCoach.Content.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content
{
    public class Exercise
    {
        
        //A* data
        private int             dangerLevel;
        private int             gn;
        private int             numMuscles;
        private int             hn;
        private int             fn;
        //Exercise data
        private String exerciseName;
        private int exerciseID;
        private int[][] reps;
        private int sets;
        private double[][] weights;
        private String description;
        private String equipmentType;
        private String primaryMuscle;
        private String note;

        //Constructor
        public Exercise(string exerciseName, int exerciseID, string description, string equipmentType, string primaryMuscle, int gn, int hn)
        {
            this.exerciseName = exerciseName;
            this.exerciseID = exerciseID;
            this.description = description;
            this.equipmentType = equipmentType;
            this.primaryMuscle = primaryMuscle;
            this.gn = gn;
            this.hn = hn;
        }

        public Exercise()
        {
            this.exerciseName = "Default";
            this.exerciseID = -1;
            this.description = "Default";
            this.equipmentType = "N/A";
            this.primaryMuscle = "N/A";
            this.gn = 100;
            this.hn = 100;
        }

        //Test Constructor
        public Exercise(int numMuscles)
        {
            this.numMuscles = numMuscles;
        }

        public int getNumMuscles()
        {
            return this.numMuscles;
        }

        public void setNumMuscles(int numMuscles)
        {
            this.numMuscles = numMuscles;
        }

        public String getPrimaryMuscle()
        {
            return this.primaryMuscle;
        }

        public void setPrimaryMuscle(String primaryMuscle)
        {
            this.primaryMuscle = primaryMuscle;
        }

        public String getExerciseName()
        {
            return this.exerciseName;
        }

        public void setExerciseName(String exerciseName)
        {
            this.exerciseName = exerciseName;
        }

        public int getExerciseID()
        {
            return this.exerciseID;
        }

        public void setExerciseID(int exerciseID)
        {
            this.exerciseID = exerciseID;
        }

        public int[][] getReps()
        {
            return this.reps;
        }

        public void setReps(int[][] reps)
        {
            this.reps = reps;
        }

        public double[][] getWeight()
        {
            return this.weights;
        }

        public void setWeights(double[][] weights)
        {
            this.weights = weights;
        }

        public int getSets()
        {
            return this.sets;
        }

        public void setSets(int sets)
        {
            this.sets = sets;
        }

        public String getDescription()
        {
            return this.description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public String getNote()
        {
            return this.note;
        }

        public void setNote(String note)
        {
            this.note = note;
        }

        public String getEquipmentType()
        {
            return this.equipmentType;
        }

        public void setEquipmentType(String equipmentType)
        {
            this.equipmentType = equipmentType;
        }

        public int getDangerLevel()
        {
            return this.dangerLevel;
        }

        public void setDangerLevel(int dangerLevel)
        {
            this.dangerLevel = dangerLevel;
        }

        public int getGN()
        {
            return this.gn;
        }

        public void setGN(int gn)
        {
            this.gn = gn;
        }

        public int getFN()
        {
            return this.fn;
        }

        public void setFN(int fn)
        {
            this.fn = fn;
        }

        public int getHN()
        {
            return this.hn;
        }

        public void setHN(int hn)
        {
            this.hn = hn;
        }
    }
}