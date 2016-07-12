using KingCulator.TwoArgument;
using NUnit.Framework;

namespace KingCulator.Tests.TwoArgument
{
    [TestFixture]
    class UmnozenieTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentCalculater calculater = new Umnozenie();
            double result = calculater.Calculate(3, 5);
            Assert.AreEqual(15, result);
        }
    }
}
