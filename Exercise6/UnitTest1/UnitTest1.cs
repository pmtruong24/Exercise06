using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestAccount
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Account money = new Account(200000);

            Assert.IsNotNull(money);
            Assert.IsInstanceOfType(money, typeof(Account));
            Assert.AreEqual(200000, money.Balance());
        }


    }
}