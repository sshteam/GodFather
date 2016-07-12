using System;

namespace KingCulator.OneArgument
{
    class Cosinus : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Cos(oneValue);
        }
    }
}
