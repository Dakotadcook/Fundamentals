using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdd.Tests
{
    [TestClass()]
    public class SumOddTests
    {
        [TestMethod()]
        public void SumOfOddTest5()
        {
            Assert.AreEqual(9, SumOdd.SumOfOdd(5));
        }
        [TestMethod()]
        public void SumOfOddTest4()
        {
            Assert.AreEqual(4, SumOdd.SumOfOdd(4));
        }
        [TestMethod()]
        public void SumOfOddTest6()
        {
            Assert.AreEqual(9, SumOdd.SumOfOdd(6));
        }
        [TestMethod()]
        public void SumOfOddTest0()
        {
            Assert.AreEqual(0, SumOdd.SumOfOdd(0));
        }
        [TestMethod()]
        public void SumOfOddTest1()
        {
            Assert.AreEqual(1, SumOdd.SumOfOdd(1));
        }

    }
}