using KingCulator.OneArgument;
using NUnit.Framework;

namespace KingCulator.Tests.OneArgument
{
    [TestFixture]
    class Lntest
    {
        [TestCase(1, 0)]
        [TestCase(100,2)]
        [TestCase(1000, 3)]
        public void CalculateTest(double oneValue, double expected)
        {

            IOneArgumentCalculater calculater = new Ln();
            double result = calculater.Calculate(oneValue);
            Assert.AreEqual(expected, result);
        }
    }
}
