using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingCulator.OneArgument;
using NUnit.Framework;

namespace KingCulator.Tests.OneArgument
{
    [TestFixture]
    class SinusTest
    {
        [TestCase(0, 0)]
        [TestCase(45, 1)]
        [TestCase(5, 120)]
        public void CalculateTest(double oneValue, double expected)
        {

            IOneArgumentCalculater calculater = new Sinus();
            double result = calculater.Calculate(oneValue);
            Assert.AreEqual(expected, result);
        }
    }
}
