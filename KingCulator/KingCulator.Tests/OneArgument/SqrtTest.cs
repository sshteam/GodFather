using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingCulator.OneArgument;
using KingCulator.TwoArgument;
using NUnit.Framework;

namespace KingCulator.Tests.OneArgument
{
    [TestFixture]
    class SqrtTest
    {
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        [TestCase(25, 5)]
        public void CalculateTest(double oneValue, double expected)
        {

            IOneArgumentCalculater calculater = new Sqrt();
            double result = calculater.Calculate(oneValue);
            Assert.AreEqual(expected, result);
        }

    }
}


