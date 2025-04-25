using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticOperations;

namespace UnitTestProject1
{
    [TestClass]
    public class M_UNIT_UnitTest1
    {
        public int i = 10, j = 20;

        [TestMethod]
        public void TestSum()
        {
            Assert.AreEqual(30, Arithmetic.Sum(i, j));
            Assert.AreEqual(0, Arithmetic.Sum(0, 0));
            Assert.AreEqual(-10, Arithmetic.Sum(-5, -5));
        }

        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(-10, Arithmetic.Sub(i, j));
            Assert.AreEqual(0, Arithmetic.Sub(5, 5));
            Assert.AreEqual(10, Arithmetic.Sub(5, -5));
        }

        [TestMethod]
        public void TestMul()
        {
            Assert.AreEqual(200, Arithmetic.Mul(i, j));
            Assert.AreEqual(0, Arithmetic.Mul(0, 5));
            Assert.AreEqual(-25, Arithmetic.Mul(5, -5));
        }

        [TestMethod]
        public void TestDiv()
        {
            Assert.AreEqual(2, Arithmetic.Div(20, 10));
            Assert.ThrowsException<DivideByZeroException>(() => Arithmetic.Div(20, 0));
            Assert.AreEqual(-4, Arithmetic.Div(20, -5));
        }
    }
}
