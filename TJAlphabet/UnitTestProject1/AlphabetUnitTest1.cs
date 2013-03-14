using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class AlphabetUnitTest1
    {
        [TestMethod]
        public void What_is_NextLetter_after_A()
        {
            ILearning a = new Alphabet();

            string expected = "B";
            string actual = a.Next();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void What_is_NextLetter_after_Z()
        {
            ILearning a = new Alphabet('Z');

            string expected = "A";
            string actual = a.Next();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void What_is_previous_value_of_A()
        {
            ILearning a = new Alphabet('A');

            string expected = "Z";
            string actual = a.Previous();

            Assert.AreEqual(expected, actual);
        }
    }
}
