using System;
using KingCulator.OneArgument;
using NUnit.Framework;

namespace KingCulator.Tests.OneArgument
{
    [TestFixture]
    class FacTest
    {
        /// <summary>
        /// test of calculator
        /// </summary>
        /// <param name="oneValue">name of one argument</param>
        /// <param name="expected">name of expected</param>
        [TestCase(4, 24)]
        [TestCase(3, 6)]
        [TestCase(5, 120)]
        public void CalculateTest(double oneValue, double expected)
        {

            IOneArgumentCalculater calculater = new Fac();
            double result = calculater.Calculate(oneValue);
            Assert.AreEqual(expected, result);
        }

    [Test]
        public void NegativeFactor()
        {

            IOneArgumentCalculater calculater = new Fac();
            Assert.Throws<Exception>(() => calculater.Calculate(-6));
        }
    }
}
