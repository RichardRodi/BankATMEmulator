namespace BankATMEmulator.BankAccounts
{
    internal class RichardAccount 

    {
        private BankManager _bankManager;

        public RichardAccount(BankManager gameManager)
        {
            _bankManager = gameManager;
        }

        private double balance = 10.01;
        
        public void RunBankMenu()
        {
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine($"{ArtAssets.BankMenu}\n\n\n");
                string prompt = ($"{ArtAssets.BankMenu}\n\n\nPlease make a selection using the arrow keys and enter.\n\n\n");

                string[] options = { $"1.Check Account Balance", "2.Make a Deposit ", "3.Make a Withdrawal" };
                Menu menu = new Menu(prompt, options);
                int selectedIndex = menu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Console.WriteLine($"Hello{_bankManager.SelectedBanker.AccountName}! Your current balance is {balance}");
                        Console.ReadKey();
                        RunBankMenu();
                        break;

                    case 1:
                        Console.WriteLine("How much would like to deposit?");
                        Console.ReadLine();
                        var amountToDeposit = Console.ReadLine();
                        if (!string.IsNullOrEmpty(amountToDeposit))
                        {
                            double deposit = double.Parse(amountToDeposit);
                            balance += deposit;
                        }
                        Console.WriteLine($"Your new Balance is {balance}");
                        Console.ReadKey();
                        RunBankMenu();
                        break;
                    case 2:
                        Console.WriteLine("Make a Withdrawal");
                        Console.WriteLine("How much would like to withdraw?");
                        Console.ReadLine();
                        var amountToWithDraw = Console.ReadLine();
                        if (!string.IsNullOrEmpty(amountToWithDraw))
                        {
                            double withdrawal = double.Parse(amountToWithDraw);
                            balance -= withdrawal;
                        }
                        Console.WriteLine($"Your new Balance is {balance}");
                        Console.ReadKey();
                        RunBankMenu();

                        break;
                    case 3:

                        break;
                    case 4:
                        break;

                }
            }
        }

    }
}
