using CalculatorApplication;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUniTests
{
    [TestFixture]
    public class AsserPart_Condition
    {
        Calculator _calc = new Calculator();

        [Test]
        public void IsTrue()
        {
            Assert.IsTrue(_calc.Add(3, 5) == 8);
            Assert.IsFalse(_calc.Add(3, 5) == 1098);

        }

        [Test]
        public void IsNan()
        {
            double price = double.NaN;
            Assert.IsNaN(price);
        }

        [Test]
        public void IsEmpty()
        {
            string fin = "";
            Assert.IsEmpty(fin);
            Assert.IsNotEmpty("123456");
        }
    }
}
