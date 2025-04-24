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
        }

        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(-10, Arithmetic.Sub(i, j));
        }

        [TestMethod]
        public void TestMul()
        {
            Assert.AreEqual(200, Arithmetic.Mul(i, j));
        }

        [TestMethod]
        public void TestDiv()
        {
            Assert.AreEqual(2, Arithmetic.Div(20, 10));
            Assert.IsTrue(true);
            Assert.AreNotEqual(11, Arithmetic.Div(20, 10));
            Assert.AreNotSame(12, Arithmetic.Div(20, 10));
        }
    }
}
