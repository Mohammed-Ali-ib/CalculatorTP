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

            int actual = engine.add(a, b);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethodeSub()
        {
            int a = 5;
            int b = 4;
            int resultat = 1;
            int actual = engine.Sub(a, b);
            Assert.AreEqual(resultat, actual);
        }

        [TestMethod]
        public void TEstMethodMul()
        {
            int a = 5;
            int b = 4;
            int resultat = 20;
            int actual = engine.Mul(a, b);
            Assert.AreEqual(resultat, actual);
        }
        [TestMethod]
        public void TEstMethodDiv()
        {
            int a = 20;
            int b = 4;
            int resultat = 5;
            int actual = engine.Div(a, b);
            Assert.AreEqual(resultat, actual);
        }

        [TestMethod]
        public void TEstMethodDivbByZero()
        {
            int a = 20;
            int b = 0;
            int resultat = Int32.MinValue;
            int actual = engine.Div(a, b);
            Assert.AreEqual(resultat, actual);

        }

    }

}
