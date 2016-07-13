using System;

namespace KingCulator.TwoArgument
{
    public class Delenie:ITwoArgumentCalculater
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if(secondValue == 0)
                {
	                throw new Exception("Деление на 0");
                }
            return firstValue / secondValue;
        }
    }
}
