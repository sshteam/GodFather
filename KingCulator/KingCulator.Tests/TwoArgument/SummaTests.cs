﻿using KingCulator.TwoArgument;
using NUnit.Framework;

namespace KingCulator.Tests.TwoArgument
{
    [TestFixture]
    public class SummaTests
    {
        [TestCase(6, 2, 8)]
        [TestCase(8, 2, 10)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {

            ITwoArgumentCalculater calculater=new Summa();
            double result = calculater.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }

    }
}
