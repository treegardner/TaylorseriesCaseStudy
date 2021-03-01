using System;
using System.Collections.Generic;

namespace TaylorseriesCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int LnValue;
            int NmbrOfIteration;
            double LnRealValue;
            Calculus calc = new Calculus();
            
            Console.WriteLine("Willkommen in der Case Study zur Taylor Reihe");
            Console.WriteLine("Bitte gib mir deinen LN echt Wert zur Berechnung an: ");
            LnValue = Convert.ToInt32(Console.ReadLine());
            LnRealValue = calc.calcLN(LnValue);
            Console.WriteLine(""+LnRealValue); //delete

            Console.WriteLine("Bitte gib mir die Anzahl Iterationen an:");
            NmbrOfIteration = Convert.ToInt32(Console.ReadLine());

            List<String> ItList = Calculus.CreateTaylorFormula(NmbrOfIteration);

            foreach (string formula in ItList)
            {
              Console.WriteLine(formula);   
            }

            Calculus.CalculateTaylorSeries(ItList, LnRealValue);

        }
    }
}
