using Microsoft.VisualStudio.TestTools.UnitTesting;
using EpicChainAPI.v2.Cryptography;
using System;

namespace EpicChainAPI.v2.UnitTests.FSClient
{
    [TestClass]
    public class UT_Accounting
    {
        [TestMethod]
        public void TestBalance()
        {
            var host = "localhost:8080";
            var key = "KxDgvEKzgSBPPfuVfw67oPQBSjidEiqTHURKSDL1R7yGaGYAeYnr".LoadWif();
            var client = new Client.Client(key, host);
            var balance = client.GetSelfBalance();
            Assert.AreEqual(0, balance.Value);
        }
    }
}
