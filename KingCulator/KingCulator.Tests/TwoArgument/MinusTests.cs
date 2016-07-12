using KingCulator.TwoArgument;
using NUnit.Framework;

namespace KingCulator.Tests.TwoArgument
{
    [TestFixture]
    public class MinusTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentCalculater calculater = new Minus();
            double result = calculater.Calculate(3, 5);
            Assert.AreEqual(-2, result);
        }
    }
}
