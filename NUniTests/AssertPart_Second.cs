using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUniTests
{
    [TestFixture]
    public class AssertPart_Second
    {
        int a, b;
        [SetUp] // constructor rolunu oynayir. Her method-dan evvel ise dusur.
        public void Init()
        {
            a = 10;
            b = 20;
        }

        [Test]
        public void Greater()
        {
            Assert.Greater(b,a); //b > a
        }

        public void Less()
        {
            Assert.Less(a, b);  //a < b
        }
    }
}
