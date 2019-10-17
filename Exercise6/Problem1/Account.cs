using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Account
    {
        int i;
        public Account(int money)
        {
            i = money;
        }
        public void Deposit(int money)
        {
            i += money;
        }
        public void Withdraw(int money)
        {
            i -= money;
        }
        public int Balance()
        {
            return i;
        }

    }
}
