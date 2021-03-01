using System;
using System.Collections.Generic;
using System.Text;

namespace TaylorseriesCaseStudy
{
    class TaylorSeries
    {
        public int iteration { get;  set; }
        public double calculatedValue { get;  set; }
        public double differenceRealValue { get;  set; }
        public double absDiffRealValue { get;  set; }
        public double lnIterationValue { get; set; }
        public double lnDifferenceRealValue { get;  set; }

        public TaylorSeries(int iteration,double calcval,double diffrealval,double absdiffrealval,double lniterationval,double lndiffrealvalue)
        {
            this.iteration = iteration;
            this.calculatedValue = calcval;
            this.differenceRealValue = diffrealval;
            this.absDiffRealValue = absdiffrealval;
            this.lnIterationValue = lniterationval;
            this.lnDifferenceRealValue = lndiffrealvalue;

        }

    }
}
