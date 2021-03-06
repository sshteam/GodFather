﻿using KingCulator.OneArgument;
using NUnit.Framework;

namespace KingCulator.Tests.OneArgument
{
    [TestFixture]
    class SinusTest
    {
        [TestCase(0, 0)]
        [TestCase(4, -0.756)]
        [TestCase(10, -0.544)]
        public void CalculateTest(double oneValue, double expected)
        {

            IOneArgumentCalculater calculater = new Sinus();
            double result = calculater.Calculate(oneValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
