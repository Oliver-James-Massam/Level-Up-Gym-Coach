using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.PerformanceMeasure
{
    public class Measurements : PerformanceMeasure
    {
        private const string MEASURE_NAME = "Measurements";
        private const string UNIT_MEASURE = "cm";
        //Measurements are in cm
        private double waist;
        private double chest;
        private double shoulders;
        private double[] arms;
        private double[] thighs;
        private double[] calves;

        //Constructor
        public Measurements(double waist, double chest, double shoulders, double[] arms, double[] thighs, double[] calves)
        {
            this.waist = waist;
            this.chest = chest;
            this.shoulders = shoulders;

            if (arms.Length == 2)
            {
                this.arms = arms;
            }
            else
            {
                this.arms = new double[2] { 0, 0 };
            }

            if (thighs.Length == 2)
            {
                this.thighs = thighs;
            }
            else
            {
                this.thighs = new double[2] { 0, 0 };
            }

            if (calves.Length == 2)
            {
                this.calves = calves;
            }
            else
            {
                this.calves = new double[2] { 0, 0 };
            }
            this.setMeasureName(MEASURE_NAME);
        }
        
        //Default Constructor
        public Measurements()
        {
            this.waist = 0;
            this.chest = 0;
            this.shoulders = 0;
            this.arms = new double[2] { 0, 0 };
            this.thighs = new double[2] { 0, 0 };
            this.calves = new double[2] { 0, 0 };
            this.setMeasureName(MEASURE_NAME);
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
        public double getWaist()
        {
            return this.waist;
        }
        public void setWaist(double waist)
        {
            this.waist = waist;
        }
        public double getChest()
        {
            return this.chest;
        }
        public void setChest(double chest)
        {
            this.chest = chest;
        }
        public double getShoulders()
        {
            return this.shoulders;
        }
        public void setShoulders(double shoulders)
        {
            this.shoulders = shoulders;
        }

        public double[] getArms()
        {
            return this.arms;
        }
        public void setArms(double[] arms)
        {
            if (arms.Length == 2)
            {
                this.arms = arms;
            }
        }
        public double[] getThighs()
        {
            return this.thighs;
        }
        public void setThighs(double[] thighs)
        {
            if (thighs.Length == 2)
            {
                this.thighs = thighs;
            }
        }
        public double[] getCalves()
        {
            return this.calves;
        }
        public void setCalves(double[] calves)
        {
            if (calves.Length == 2)
            {
                this.calves = calves;
            }
        }
    }
}