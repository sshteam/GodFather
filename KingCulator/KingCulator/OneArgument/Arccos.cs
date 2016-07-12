using System;

namespace KingCulator.OneArgument
{
    class Arccos : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Acos(oneValue);
        }
    }
}
