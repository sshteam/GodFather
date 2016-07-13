using System;

namespace KingCulator.OneArgument
{
    public class Fac : IOneArgumentCalculater
    {
        /// <summary>
        /// to count factorial
        /// </summary>
        /// <param name="oneValue">value of factorial</param>
        /// <returns>return factorial</returns>
        public double Calculate(double oneValue)
        {
            if (oneValue <= 0)
            {
                throw new Exception("меньше или равно 0");
            }
            int fact = 1;

            for (; oneValue > 0; fact *= (int)oneValue--);

            return fact;
        }
    }
}
