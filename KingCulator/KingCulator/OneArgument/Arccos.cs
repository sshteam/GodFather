using System;

namespace KingCulator.OneArgument
{
    public class Arccos : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Acos(oneValue);
        }
    }
}
