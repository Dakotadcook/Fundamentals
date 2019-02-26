using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumofOdds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofOdds.Tests
{
    [TestClass()]
    public class SumOddsTests
    {
        [TestMethod()]
        public void GetOddSumTest()
        {
            Assert.AreEqual(9, SumOdds.GetOddSum(5));
        }

        [TestMethod()]
        public void GetOddSumTest1()
        {
            Assert.AreEqual();
        }
    }
}