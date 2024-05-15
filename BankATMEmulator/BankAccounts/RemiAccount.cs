using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace BankATMEmulator.BankAccounts
{
    internal class RemiAccount : BaseAccount
    {
        public RemiAccount(string accountName, int balance)
        {
            AccountName = accountName;
            Balance = balance;
        }
        private int balance = 2400;
    }
}
