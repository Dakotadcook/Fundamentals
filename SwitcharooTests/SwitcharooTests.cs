using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void reverseintTest5()
        {
            Assert.AreEqual(5, Switcharoo.reverseint(-5));
        }
        public void reverseintTest10()
        {
            Assert.AreEqual(-10, Switcharoo.reverseint(10));
        }
        public void reverseintTest123()
        {
            Assert.AreEqual(123, Switcharoo.reverseint(-123));
        }
        public void reverseintTest567()
        {
            Assert.AreEqual(-567, Switcharoo.reverseint(567));
        }
        public void reverseintTest12865()
        {
            Assert.AreEqual(12865, Switcharoo.reverseint(-12865));
        }
    }
}