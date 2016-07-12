using System;

namespace KingCulator.OneArgument
{
    public class Sqrt : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Sqrt(oneValue);
        }
    }
}
