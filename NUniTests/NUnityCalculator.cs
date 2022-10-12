using CalculatorApplication;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUniTests
{
    [TestFixture]
    public class NUnityCalculator
    {
        [Test]
        public static void Testoperations()
        {
            Calculator _c = new Calculator();
            Assert.AreEqual(8, _c.Add(3, 5));
            Assert.AreEqual(4, _c.Sub(6, 2));
            Assert.AreEqual(24, _c.Mul(3, 8));
            Assert.AreEqual(2, _c.Div(6, 3));
            Assert.AreNotEqual(1546, _c.Div(20, 4));

        }
    }
}
