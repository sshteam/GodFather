using System;

namespace KingCulator.OneArgument
{
    public class Sinus : IOneArgumentCalculater    {
        public double Calculate(double oneValue)
        {
            return Math.Sin(oneValue);
        }
    }
}
