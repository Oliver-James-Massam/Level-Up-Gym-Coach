using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.PerformanceMeasure
{
    public class VO2Max : PerformanceMeasure
    {
        private const double DISTANCE_RUN_KM = 2.4;
        private const string MEASURE_NAME = "VO2Max";
        private int minutes;
        private int seconds;

        //Constructor
        public VO2Max(int minutes, int seconds)
        {
            this.minutes = minutes;
            this.seconds = seconds;
            this.setMeasureName(MEASURE_NAME);
        }

        //Default Constructor
        public VO2Max()
        {
            this.minutes = 0;
            this.seconds = 0;
            this.setMeasureName(MEASURE_NAME);
        }

        public override double[] calcMeasure()
        {
            throw new NotImplementedException();
        }

        public override double[] calcLastMeasure()
        {
            throw new NotImplementedException();
        }
        //------------ Getter and Setter Methods ------------
        public int getMinutes()
        {
            return this.minutes;
        }

        public void setMinutes(int minutes)
        {
            this.minutes = minutes;
        }

        public int getSeconds()
        {
            return this.seconds;
        }

        public void setSeconds(int seconds)
        {
            this.seconds = seconds;
        }
    }
}