﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using MathParser;
//test
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;



namespace TaylorseriesCaseStudy
{
     class Calculus
    {


        public double calcLN(int Value)
        {
            // calc ln(value)
            double LogVal = Math.Log(Value);
            return LogVal;
        }

        public static List<String> CreateTaylorFormula(int IterationNmbr)
        {
            var taylorFormulaList = new List<String>();
            // got to use Stringbuilder otherwise issues with EOF when Elevate in NCalc.
            //string Formula = "1";
            StringBuilder sb = new StringBuilder("1");

            for (int i = 2; i <= IterationNmbr+1; i++)
            {
                string baseFormula = "(1^ "+i+") / "+i;

                if ((i % 2)== 0)
                {
                    sb.Append(" - " + baseFormula);
                }
                else
                {
                    sb.Append(" + " + baseFormula);
                }
                
                taylorFormulaList.Add(sb.ToString());
                    
                
            }
            
            return taylorFormulaList;

        }


        public static List<TaylorSeries> CalculateTaylorSeries(List<String> TaylorFormula, double lnrealvalue)
        {
            var TaylorValueList = new List<TaylorSeries>();
            double LNRealValue = lnrealvalue;

            Parallel.ForEach(TaylorFormula, i =>
                {
                    string form = i.ToString();
                    //var TaylorCalced = new DataTable().Compute(i,"");
                   // Expression e = new Expression
                   //Expression expr = new Expression(i.ToString());
                  // expr.Parameters["x"] = 1;
                  
                     //  expr.Evaluate();
                     int itera = i.Count(x => x == '/');
                     double calcvalue;
                   
                     
                     
                     //lock (TaylorFormula)
                    // {
                        //https://github.com/einsteinsci/math-plus and https://github.com/einsteinsci/math-parser
                        calcvalue = Evaluator.Evaluate(form).ToDouble();
                    // }


                     double diffrealvalue = lnrealvalue - calcvalue;
                     double absdiffrealval = Math.Abs(diffrealvalue);
                     double lnitera = Math.Log(itera);
                     double lniteradiff = Math.Log(diffrealvalue);
                     TaylorSeries ts = new TaylorSeries(itera, calcvalue,diffrealvalue,absdiffrealval,lnitera,lniteradiff);

                    TaylorValueList.Add(ts);



                }
            );


            return TaylorValueList;
        }


    }
}
