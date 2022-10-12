using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUniTests
{
    [TestFixture]
    public class Assert_Ignore_Fail
    {
        [Test]
        public void Fail()
        {
            //Method sozdat test, kotoriy ne budet proyden s soobseniem Fail;
            Assert.Fail("Fail");
        }

        [Test]
        //[Ignore]
        public void Ignore()
        {
            //throw new Exception();
            //Etod method pomechaet test, kotoriy budet iqnorirovat pri zapuske vsex testov
            //i ne budet vipolnen
            Assert.Ignore("Ignore");
        }
    }
}
