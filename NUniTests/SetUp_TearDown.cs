using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUniTests
{
    public class SetUp_TearDown
    {
        static List<string> _myCollection = new List<string>();

        [SetUp]
        //budet vipolnyatsya pr zapuske kajdovo novovo testa.
        //kak Constructor
        public static void TestDefault()
        {
            _myCollection.Add("First");  
            _myCollection.Add("Second");
            _myCollection.Add("Third");
        }

        [Test]
        public static void TestAdd()
        {
            _myCollection.Add("Fopurth");

            Assert.AreEqual(4, _myCollection.Count);
        }
   
        [TearDown] 
        //budet vipolnyatsya posle kajdovo okoncheniya metoda
        public static void voidTearDownTest()
        {
            _myCollection = null;
        }
    }
}
