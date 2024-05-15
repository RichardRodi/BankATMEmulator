namespace BankATMEmulator
{
    internal class AccountScreen
    {
        private BankManager _bankManager;

        public AccountScreen(BankManager bankManager)
        {
            _bankManager = bankManager;
        }
        public void RunATMLogin()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine($"{ArtAssets.BankMenu}\n\n\n");
            Console.WriteLine("Please Enter Your Login");
            var accountName = Console.ReadLine();

            if (accountName == "Richard")
            {
                Console.WriteLine("This is a valid account");
                Console.ReadKey(true);
                Console.WriteLine("Please Enter Your PIN");
                string personalIdentificationNumber = Console.ReadLine();
                if (personalIdentificationNumber == "1111")
                {
                    Console.WriteLine("Validated PIN, Hello Richard!");
                    Console.ReadKey(true);
                    var selectedBanker = _bankManager.AllBankers.Where(x => x.AccountName == "Richard To Cool for School");

                    if (selectedBanker != null)
                    {
                        _bankManager.SelectedBanker = selectedBanker;
                    }
                    else
                    {
                        Console.WriteLine("Banker not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid PIN.");
                }
            }
            else
            {
                Console.WriteLine("Invalid account name.");
            }

        }
    }

}
