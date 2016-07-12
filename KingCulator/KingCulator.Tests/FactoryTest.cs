using System;
using KingCulator.TwoArgument;
using NUnit.Framework;

namespace KingCulator.Tests
{
    [TestFixture]
    class FactoryTest
    {
        [TestCase("summa", typeof(Summa))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentFactory.CreateCalculater(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }
}
