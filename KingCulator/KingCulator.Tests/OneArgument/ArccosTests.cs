using KingCulator.OneArgument;
using NUnit.Framework;

namespace KingCulator.Tests.OneArgument
{
    [TestFixture]
    class ArccosTests
    {
        [TestCase(0, 1.570)]
        [TestCase(1, 0)]
        [TestCase(0.5, 1.047)]
        public void CalculateTest(double oneValue, double expected)
        {

            IOneArgumentCalculater calculater = new Arccos();
            double result = calculater.Calculate(oneValue);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
