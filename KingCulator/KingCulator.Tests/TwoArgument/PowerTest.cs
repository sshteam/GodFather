using KingCulator.TwoArgument;
using NUnit.Framework;

namespace KingCulator.Tests.TwoArgument
{
    [TestFixture]
    class PowerTest
    {
        [TestCase(4, 2, 16)]
        [TestCase(3, 2, 9)]
        [TestCase(5, 3, 125)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {

            ITwoArgumentCalculater calculater = new Power();
            double result = calculater.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }

}
