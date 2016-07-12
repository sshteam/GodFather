using System;

namespace KingCulator.TwoArgument
{
    class Log : ITwoArgumentCalculater
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Log(firstValue, secondValue);
        }
    }
}
