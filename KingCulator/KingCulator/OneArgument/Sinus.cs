using System;

namespace KingCulator.OneArgument
{
    class Sinus : IOneArgumentCalculater    {
        public double Calculate(double oneValue)
        {
            return Math.Sin(oneValue);
        }
    }
}
