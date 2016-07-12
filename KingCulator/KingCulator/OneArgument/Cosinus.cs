using System;

namespace KingCulator.OneArgument
{
    public class Cosinus : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Cos(oneValue);
        }
    }
}
