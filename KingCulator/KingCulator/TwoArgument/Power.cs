﻿using System;

namespace KingCulator.TwoArgument
{
    public class Power:ITwoArgumentCalculater
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, secondValue);
        }
    }
}
