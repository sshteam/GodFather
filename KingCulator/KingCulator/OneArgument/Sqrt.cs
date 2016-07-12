using System;

namespace KingCulator.OneArgument
{
    class Sqrt : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Sqrt(oneValue);
        }
    }
}
