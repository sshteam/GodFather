using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingCulator.TwoArgument;
using NUnit.Framework;

namespace KingCulator.Tests.TwoArgument
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(9, 3, 2)]
        [TestCase(25, 5, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {

            ITwoArgumentCalculater calculater = new Log();
            double result = calculater.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }

    }
}
