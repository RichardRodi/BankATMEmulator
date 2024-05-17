using BankATMEmulator.BankAccounts;

namespace BankATMEmulator
{
    internal class BankManager
    {
        public Banker SelectedBanker { get; set; }
        public List<Banker> AllBankers { get; set; } = new List<Banker>();
        public List<BaseAccount> BaseAccounts { get; set; } = new List<BaseAccount>();

        public BankManager(bool seedData = false)
        {
            if (seedData)
            {
                GenerateAllBankers();
                GenerateAllAccounts();
            }
        }

        private void GenerateAllBankers()
        {

            AllBankers.Add(new Banker(accountName: "Richard", balance: 500.21, pin: 1111, actualName: "Richard Too Cool for School"));

            AllBankers.Add(new Banker(accountName: "Rosa", balance: 1000.87, pin: 2222, actualName: "Rosa the Great"));

            AllBankers.Add(new Banker(accountName: "Remi", balance: 1200.22, pin: 3333, actualName: "Remi the Grand"));

        }

        private void GenerateAllAccounts()
        {
            var personalAcccount = new PersonalAccount(this);
            BaseAccounts.Add(personalAcccount);
        }

        public bool ValidateLogin(string accountName, int pin)
        {
            Banker banker = AllBankers.FirstOrDefault(b => b.AccountName == accountName && b.Pin == pin);
            if (banker != null)
            {
                Console.WriteLine($"\tWelcome,{banker.ActualName}!");
                SelectedBanker = banker;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RunATM()
        {
            AccountLoginScreen mainMenu = new AccountLoginScreen(this);
            mainMenu.RunATMLogin();

        }
    }
}
