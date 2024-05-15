namespace BankATMEmulator.BankAccounts
{
    internal abstract class BaseAccount
    {
        public double Balance { get; set; } 

        public string AccountName { get; set; } = string.Empty;

        public BaseAccount()
        {

        }

        public void Deposit(double moneyToAdd) => Balance += moneyToAdd;

        public double GetBalance() => Balance;

        public void Withdrawal(double moneyToAdd) => Balance -= moneyToAdd;
    }
}
