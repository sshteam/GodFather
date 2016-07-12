using System;

namespace KingCulator.OneArgument
{
    class Exp : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Exp(oneValue);
        }
    }
}
