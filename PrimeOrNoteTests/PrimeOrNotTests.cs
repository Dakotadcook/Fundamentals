using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeOrNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrNote.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsPrimeTest2()
        {
            Assert.AreEqual(5, PrimeOrNot.IsPrime(1));
        }
        [TestMethod()]
        public void IsPrimeTest3()
        {
            Assert.AreEqual(3, PrimeOrNot.IsPrime(2));
        }
        [TestMethod()]
        public void IsPrimeTest4()
        {
            Assert.AreEqual(3, PrimeOrNot.IsPrime(3));
        }
        [TestMethod()]
        public void IsPrimeTest5()
        {
            Assert.AreEqual(3, PrimeOrNot.IsPrime(4));
        }
    }
}