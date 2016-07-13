using System;
using KingCulator.TwoArgument;
using NUnit.Framework;

namespace KingCulator.Tests
{
    [TestFixture]
    class DivisionByZeroTest
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentCalculater calculater = new Delenie();
            Assert.Throws<Exception>(() => calculater.Calculate(5, 0));
        }
    }
}
