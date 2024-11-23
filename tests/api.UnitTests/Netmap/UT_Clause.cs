using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpicChain.API.v2.Netmap;
using System;

namespace EpicChain.API.v2.UnitTests.TestNetmap
{
    [TestClass]
    public class UT_Clause
    {
        [TestMethod]
        public void TestString()
        {
            var c = EpicChain.API.v2.Netmap.Clause.Same;
            Assert.AreEqual("Same", c.ToString());
        }
    }
}