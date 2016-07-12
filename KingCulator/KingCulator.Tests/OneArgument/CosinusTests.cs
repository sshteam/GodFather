using KingCulator.OneArgument;
using NUnit.Framework;

namespace KingCulator.Tests.OneArgument
{
    [TestFixture]
    class CosinusTests
    {
        [TestCase(0, 1)]
        [TestCase(4, -0.653)]
        [TestCase(10, -0.839)]
        public void CalculateTest(double oneValue, double expected)
        {

            IOneArgumentCalculater calculater = new Cosinus();
            double result = calculater.Calculate(oneValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
