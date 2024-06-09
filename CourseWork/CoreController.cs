using System;

namespace CourseWork
{
    internal class CoreController
    {
        /// <summary>
        /// Основная функция интегрального уравнения (ядро)
        /// </summary>
        public static double Core(double time, double tau, double x0, double NumberOfElements)
        {
            double x0Function = x0 * (time - tau);
            double SummaryFunction = 0.0;
            for (int i = 1; i < NumberOfElements + 1; i++)
            {
                double FirstMulti = (Math.Pow((-1), i) * Math.Sin(Math.PI * i * x0)) / (Math.Pow((Math.PI * i), 3));
                double SecondMulti = (1 - Math.Exp(-Math.Pow((Math.PI * i), 2) * (time - tau)));
                SummaryFunction += FirstMulti * SecondMulti;
            }
            return (x0Function + (2 * SummaryFunction));
        }
    }
}
