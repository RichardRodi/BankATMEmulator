namespace BankATMEmulator.BankAccounts
{
    internal class Banker : BaseAccount
    {
        public Banker()
        {

        }
        public Banker(string accountName, double balance)
        {

            AccountName = accountName;
            Balance = balance;

        }
    }
}
