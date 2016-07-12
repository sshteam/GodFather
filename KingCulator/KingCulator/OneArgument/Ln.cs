using System;

namespace KingCulator.OneArgument
{
    public class Ln : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Log10(oneValue);
        }
    }
}
