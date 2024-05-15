using BankATMEmulator.BankAccounts;

namespace BankATMEmulator
{
    internal class BankManager
    {
        public Banker SelectedBanker { get; set; }

        public List<Banker> AllBankers { get; set; } = new List<Banker>();

        public BankManager(bool seedData = false)
        {
            GenerateAllBankers();
        }

        public void GenerateAllBankers()
        {

            AllBankers.Add(new Banker(accountName: "Richard To Cool for School", balance: 0));

            AllBankers.Add(new Banker(accountName: "Rosa the Great", balance: 0));

            AllBankers.Add(new Banker(accountName: "Remi the Grand", balance: 0));

        }


        public void RunATM()
        {
            AccountScreen mainMenu = new AccountScreen(this);

            mainMenu.RunATMLogin();

        }
    }
}
