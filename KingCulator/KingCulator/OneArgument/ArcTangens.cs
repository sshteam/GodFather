using System;

namespace KingCulator.OneArgument
{
    class ArcTangens : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Atan(oneValue);
        }
    }
}
