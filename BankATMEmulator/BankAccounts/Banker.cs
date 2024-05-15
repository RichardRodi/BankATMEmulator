
namespace BankATMEmulator.BankAccounts
{
    internal class Banker : BaseAccount
    {
        public Banker()
        {

        }
        public Banker(string accountName, double balance, int pin, string actualName)
        {

            AccountName = accountName;
            Balance = balance;
            Pin = pin;
            ActualName = actualName;
        }

        public override void ChooseAccount(Type account)
        {
            throw new NotImplementedException();
        }

        public override void RunCurrentAccountMenu()
        {
            throw new NotImplementedException();
        }
    }
}
