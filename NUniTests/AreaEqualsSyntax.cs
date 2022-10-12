using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUniTests
{
    public class AreaEqualsSyntax : AssertionHelper
    {
        [Test]
        public void ClassicContains()
        {
            int[] _array = new int[] { 1, 2, 3 };
            string[] _str = new string[] { "a", "b", "c" };
            Assert.Contains(3, _array);
            Assert.Contains("a", _str);
        }

        [Test]
        public void HelperContains()
        {
            int[] _array = new int[] { 1, 2, 3 };
            string[] _str = new string[] { "a", "b", "c" };

            Expect(_array, Contains(3));
            Expect(_str, Contains("a"));
        }

        [Test]
        public void HasMember()
        {
            int[] _array = new int[] { 1, 2, 3 };
            string[] _str = new string[] { "a", "b", "c" };
            Assert.That(_array, Has.Member(3));
            Assert.That(_str, Has.Member("a"));

            Assert.Contains("a", _str);
        }

        [Test]
        public void NoMember()
        {
            int[] _array = new int[] { 1, 2, 3 };
            string[] _str = new string[] { "a", "b", "c" };
            Assert.That(_array, No.Member(30));
            Assert.That(_str, No.Member("avs"));

            Assert.Contains("a", _str);
        }

        [Test]
        public void ClassicAreaEqual()
        {
            Assert.AreEqual(typeof(string), "Selamin Eleykum".GetType());
            Assert.AreEqual("System.String", "Selamin Eleykum".GetType().FullName);

            Assert.AreNotEqual(typeof(int), "Sehv".GetType());
            Assert.AreNotEqual("System.Int32.", "Sehv".GetType());
        }

        [Test]
        public void HelperAreaEqual()
        {
            Assert.That("Selamin Eleykum", Is.TypeOf(typeof(string)));
            Assert.That("Selamin Eleykum", Is.Not.TypeOf(typeof(int)));
        }

        [Test]

        public void InheritedAreaEqual()
        {
            Expect("Selamin Eleykum", TypeOf(typeof(string)));
            Expect("Selamin Eleykum", Not.TypeOf(typeof(int)));
        }
    }
}
