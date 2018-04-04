using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymCoach.Content.PerformanceMeasure
{
    public abstract class PerformanceMeasure
    {
        private string measureName;

        public string getMeasureName()
        {
            return this.measureName;
        }

        public void setMeasureName(string measureName)
        {
            this.measureName = measureName;
        }

        abstract public double[] calcMeasure();
        abstract public double[] calcLastMeasure();
    }
}