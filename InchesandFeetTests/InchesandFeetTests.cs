using Microsoft.VisualStudio.TestTools.UnitTesting;
using InchesandFeet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesandFeet.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GetfeetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InchesToFeetTest()
        {
            Assert.AreEqual(1, InchesandFeet.InchesToFeet(12));
        }
    }
}