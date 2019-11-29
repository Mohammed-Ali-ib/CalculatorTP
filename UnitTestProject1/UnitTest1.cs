using System;
using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator engine = new Calculator();

        [TestMethod]
        public void TestMethodadd()
        {
            int val1 = 1;
            int val2 = 2;
            int expected = 3;

            int actual = engine.Addition(val1, val2);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethodeSub()
        {
            int val1 = 5;
            int val2 = 4;
            int resultat = 1;
            int actual = engine.Substruction(val1, val2);
            Assert.AreEqual(resultat, actual);
        }

        [TestMethod]
        public void TEstMethodMul()
        {
            int val1 = 5;
            int val2 = 4;
            int resultat = 20;
            int actual = engine.Multiplication(val1, val2);
            Assert.AreEqual(resultat, actual);
        }
        [TestMethod]
        public void TEstMethodDiv()
        {
            int val1 = 20;
            int val2 = 4;
            int resultat = 5;
            int actual = engine.Division(val1, val2);
            Assert.AreEqual(resultat, actual);
        }

        [TestMethod]
        public void TEstMethodDivbByZero()
        {
            int val1 = 20;
            int val2 = 0;
            int resultat = Int32.MinValue;
            int actual = engine.Division(val1, val2);
            Assert.AreEqual(resultat, actual);
        }

    }

}
