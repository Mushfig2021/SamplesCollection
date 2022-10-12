using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NUniTests
{
    [TestFixture]
    public class AssertPart_First
    {
        [Test]
        public void AareSameTest()
        {
            string _baku = "Baki";
            string _sameText = "Same Text";

            Assert.AreNotEqual(_baku, _sameText);
        }

        [Test]
        public void ContainsTest()
        {
            ArrayList _array = new ArrayList();
            _array.Add("Hp"); _array.Add("Dell"); _array.Add("Toshiba");
            Assert.Contains("Hp", _array);
        }
    }
}
