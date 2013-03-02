using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal expected = 2;
            decimal actual = 0;
            actual = Class1.Add(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PassStringsToAddMethod()
        {
            decimal expected = 5;
            decimal actual;

            actual = Class1.Add("2", "3");

            Assert.AreEqual(expected, actual);
        }
    }
}