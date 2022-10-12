using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUniTests
{
    [TestFixture]
    public class AssertPart_Third
    {
        [Test]
        public void IsinstanceOf()
        {
            Assert.IsInstanceOf(typeof(object), "Car");
            Assert.IsNotInstanceOf(typeof(string), 5);
        }
    }
}
