using System;

namespace KingCulator.OneArgument
{
    class Tangens : IOneArgumentCalculater
    {
        public double Calculate(double oneValue)
        {
            return Math.Tan(oneValue);
        }
    }
}
