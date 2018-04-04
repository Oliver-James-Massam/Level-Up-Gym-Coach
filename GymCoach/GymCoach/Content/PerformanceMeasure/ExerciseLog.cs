using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.PerformanceMeasure
{
    public class ExerciseLog : PerformanceMeasure
    {
        private const string MEASURE_NAME = "Measurements";
        private int logID;
        private int sets;
        private int[,] reps;
        private double[,] weight;
        private int exerciseID;
        //Constructor
        public ExerciseLog(int logID, int sets, int[,] reps, double[,] weight, int exerciseID)
        {

        }
        //Default Constructor
        public ExerciseLog()
        {

        }
        //Calculate the 1 rep max for each set
        public double[] calc1RM()
        {
            double[] repMax = new double[sets];
            return repMax;
        }
        //Get all exercise logs for a specific exercise
        public ExerciseLog getAllLogs()
        {
            return new ExerciseLog();
        }

        public override double[] calcLastMeasure()
        {
            throw new NotImplementedException();
        }

        public override double[] calcMeasure()
        {
            throw new NotImplementedException();
        }
        //------------ Getter and Setter Methods ------------
        public int getLogID()
        {
            return this.logID;
        }
        public void setLogID(int logID)
        {
            this.logID = logID;
        }
    }
}