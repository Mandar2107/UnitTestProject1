using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using ArthamitcOpertions;
using System.Runtime.CompilerServices;

namespace UnitTestProject1
{
    [TestClass]
    public class M_UNIT_UnitTest1
    {
        public int i = 10, j = 20;
        Arthmatic ar = new Arthmatic();

        [TestMethod]
        public void TestSum()
        {
           
            Assert.AreEqual(30, ar.Sum(i, j));
        }

        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(-10 ,ar.Sub(i, j));
        }

        [TestMethod]

        public void TestMul()
        {
            Assert.AreEqual(200 ,ar.mul(i, j));
        }

        /* this is Mtest tesing theree are inuld method that we useed 
         * N-unit for .Net Fremwork 
         * X-Unit For .Net core
         */
        

        [TestMethod]
        public  void TestDiv()
        {
            Assert.AreEqual(2, ar.Div(20, 10));
            Assert.IsTrue(true);
            Assert.AreNotEqual(11 ,ar.Div(20, 10));
            Assert.AreNotSame(ar, ar.Div(20, 10));
        }
    }
}
