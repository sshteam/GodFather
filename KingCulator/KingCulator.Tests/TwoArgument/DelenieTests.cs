using KingCulator.TwoArgument;
using NUnit.Framework;

namespace KingCulator.Tests.TwoArgument
{
    [TestFixture]
    class DelenieTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentCalculater calculater = new Delenie();
            double result = calculater.Calculate(5, 1);
            Assert.AreEqual(5, result);
        }
    }
}
