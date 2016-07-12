using System;

namespace KingCulator.OneArgument
{
    class Arcsin : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Asin(oneValue);
        }
    }
}
