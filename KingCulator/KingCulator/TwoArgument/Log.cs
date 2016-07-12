using System;

namespace KingCulator.TwoArgument
{
    public class Log : ITwoArgumentCalculater
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Log(firstValue, secondValue);
        }
    }
}
