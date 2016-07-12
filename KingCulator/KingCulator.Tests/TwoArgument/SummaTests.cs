using KingCulator.TwoArgument;
using NUnit.Framework;

namespace KingCulator.Tests.TwoArgument
{
    [TestFixture]
    public class SummaTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentCalculater calculater=new Summa();
            double result = calculater.Calculate(3, 5);
            Assert.AreEqual(8, result);
        }

    }
}
