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
    class FacTest
    {
        [TestCase(4, 24)]
        [TestCase(3, 6)]
        [TestCase(5, 120)]
        public void CalculateTest(double oneValue, double expected)
        {

            IOneArgumentCalculater calculater = new Fac();
            double result = calculater.Calculate(oneValue);
            Assert.AreEqual(expected, result);
        }
    }
}
