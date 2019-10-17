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
            Account acc = new Account(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.Balance());
        }
        [TestMethod]

        public void TestMethodDeposit()
        {
            Account acc = new Account(500000);
            acc.Deposit(100000);
            Assert.AreEqual(600000, acc.Balance());
            acc.Deposit(100000);
            Assert.AreEqual(700000, acc.Balance());
        }
        [TestMethod]

        public void TestMethodWithdraw()
        {
            Account acc = new Account(300000);
            acc.Deposit(100000);
            Assert.AreEqual(400000, acc.Balance());
            acc.Deposit(100000);
            Assert.AreEqual(500000, acc.Balance());
        }
        [TestMethod]

        public void TestMethod()
        {
            Account acc = new Account(300000);
            acc.Deposit(100000);
            Assert.AreEqual(400000, acc.Balance());
            acc.Deposit(100000);
            Assert.AreEqual(500000, acc.Balance());
        }
    }
}
