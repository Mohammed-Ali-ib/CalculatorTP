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
            int a = 1;
            int b = 2;
            int expected = 3;

            int actual = engine.Addition(a, b);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethodeSub()
        {
            int a = 5;
            int b = 4;
            int resultat = 1;
            int actual = engine.Substruction(a, b);
            Assert.AreEqual(resultat, actual);
        }

        [TestMethod]
        public void TEstMethodMul()
        {
            int a = 5;
            int b = 4;
            int resultat = 20;
            int actual = engine.Multiplication(a, b);
            Assert.AreEqual(resultat, actual);
        }
        [TestMethod]
        public void TEstMethodDiv()
        {
            int a = 20;
            int b = 4;
            int resultat = 5;
            int actual = engine.Division(a, b);
            Assert.AreEqual(resultat, actual);
        }

        [TestMethod]
        public void TEstMethodDivbByZero()
        {
            int a = 20;
            int b = 0;
            int resultat = Int32.MinValue;
            int actual = engine.Division(a, b);
            Assert.AreEqual(resultat, actual);

        }

    }

}
