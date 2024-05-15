using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankATMEmulator.BankAccounts
{
    internal class RosaAccount : BaseAccount
    {
        public RosaAccount(string accountName, int balance)
        {
            AccountName = accountName;
            Balance = balance;
        }
        private int balance = 42;
    }
}
