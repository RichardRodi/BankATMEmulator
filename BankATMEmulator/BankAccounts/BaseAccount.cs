namespace BankATMEmulator.BankAccounts
{
    internal abstract class BaseAccount
    {
        public double Balance { get; set; } 

        public string AccountName { get; set; } = string.Empty;

        public int Pin { get; set; }

        public string ActualName { get; set; } = string.Empty;
        public BaseAccount()
        {

        }
        public abstract void RunCurrentAccountMenu();
        public abstract void ChooseAccount(Type account);
        public void Deposit(double moneyToAdd) => Balance += moneyToAdd;

        public double GetBalance() => Balance;
        public void Withdrawal(double moneyToAdd) => Balance -= moneyToAdd;
    }
}
