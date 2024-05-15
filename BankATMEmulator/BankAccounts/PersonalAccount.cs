using BankATMEmulator.Print;

namespace BankATMEmulator.BankAccounts
{
    internal class PersonalAccount : BaseAccount
    {
        
        private BankManager _bankManager;

        public PersonalAccount(BankManager bankManager)
        {
            _bankManager = bankManager;
        }
        public override void ChooseAccount(Type account)
        {
            throw new NotImplementedException();
        }

        public override void RunCurrentAccountMenu()

        {
            AccountLoginScreen mainMenu = new AccountLoginScreen(this);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine($"{ArtAssets.BankMenu}\n\n\n");
            string prompt = ($"{ArtAssets.BankMenu}\n\n\n\tHello {_bankManager.SelectedBanker.ActualName}!\n\n\n\tPlease make a selection using the arrow keys and enter.\n\n\n");

            string[] options = { $"1.Check Account Balance", "2.Make a Deposit ", "3.Make a Withdrawal", "4.Exit to Main Menu" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n\n\n\tHello {_bankManager.SelectedBanker.AccountName}! Your current balance is:\n\t${_bankManager.SelectedBanker.Balance}");
                    Console.ReadKey();
                    string response = PrinterClass.IndentAndReadLine("Is there anything else you want to do today? Y/N", 8);
                    if (response == "y" || response == "Y" || response == "yes" || response == "Yes")
                    {
                        Console.WriteLine("\tGreat What else can I help with?");
                        Console.ReadKey();
                        RunCurrentAccountMenu();
                    }
                    if (response == "n" || response == "N" || response == "no" || response == "NO")
                    {
                        Console.WriteLine("\tHave a great day!");
                        Console.ReadKey(true);
                        mainMenu.RunATMLogin();
                        
                    }
                    else
                    {
                        Console.WriteLine("\tSorry Please make another selection") ;
                    }
                    break;

                case 1:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    var amountToDeposit =  PrinterClass.IndentAndReadLine("\n\n\n\tHow much would like to deposit?", 8);
                    if (!string.IsNullOrEmpty(amountToDeposit))
                    {
                         double deposit = double.Parse(amountToDeposit);
                        _bankManager.SelectedBanker.Balance += deposit;
                    }
                    else
                    {
                        Console.WriteLine("\tNot a valid amount of money");
                        Console.ReadKey();
                        RunCurrentAccountMenu();
                    }
                    Console.WriteLine($"\tYour new Balance is {_bankManager.SelectedBanker.Balance}");
                    Console.ReadKey();
                    RunCurrentAccountMenu();
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    var amountToWithDraw = PrinterClass.IndentAndReadLine("\n\n\n\tHow much would like to withdraw?\n", 8);
                    if (!string.IsNullOrEmpty(amountToWithDraw))
                    {
                         double withdrawal = double.Parse(amountToWithDraw);
                        _bankManager.SelectedBanker.Balance -= withdrawal;
                    }
                    else
                    {
                        Console.WriteLine("\tNot a valid amount of money\n");
                        Console.ReadKey();
                        RunCurrentAccountMenu();
                    }

                    if (_bankManager.SelectedBanker.Balance >= 0)
                    { 
                    Console.WriteLine($"\tYour new Balance is {_bankManager.SelectedBanker.Balance}");
                    Console.ReadKey();
                    RunCurrentAccountMenu();
                    }

                    else
                    {
                        Console.WriteLine("\tYou over drafted on your Account!\n" +
                            "\tAdd money soon of fees will incur!");
                        Console.WriteLine($"\tYour new Balance is {_bankManager.SelectedBanker.Balance}");
                        Console.ReadKey();
                        RunCurrentAccountMenu();
                    }

                    break;
                case 3:
                    Console.WriteLine("\tThanking you for banking with us!");
                    Console.ReadKey(true);
                    mainMenu.RunATMLogin();
                    break;

            }
        }

    }
}

