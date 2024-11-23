using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpicChainAPI.v2.Netmap;
using System;

namespace EpicChainAPI.v2.UnitTests.TestNetmap
{
    [TestClass]
    public class UT_Clause
    {
        [TestMethod]
        public void TestString()
        {
            var c = EpicChainAPI.v2.Netmap.Clause.Same;
            Assert.AreEqual("Same", c.ToString());
        }
    }
}