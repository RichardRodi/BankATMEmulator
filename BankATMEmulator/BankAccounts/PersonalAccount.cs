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
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            string prompt = ($"{ArtAssets.BankMenu}\n\n\n\tHello {_bankManager.SelectedBanker.ActualName}!\n\tPlease make a selection using the arrow keys and enter.\n");

            string[] options = { $"1.Check Account Balance.", "2.Make a Deposit. ", "3.Make a Withdrawal.", "4.Exit to Main Menu." };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine($"\n\n\n\tHello {_bankManager.SelectedBanker.AccountName}! Your current balance is:\n\t${_bankManager.SelectedBanker.Balance}");
                    Console.ReadKey();
                    string response = PrinterClass.IndentAndReadLine("\n\n\tIs there anything else you want to do today? Y/N", 8);
                    if (response == "y" || response == "Y" || response == "yes" || response == "Yes" || response == "YES")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\tGreat What else can I help with?");
                        Console.ReadKey();
                        RunCurrentAccountMenu();
                    }
                    if (response == "n" || response == "N" || response == "no" || response == "No" || response == "NO")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\tHave a great day!");
                        Console.ReadKey(true);
                        _bankManager.RunATM();
                       
                        
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\tSorry not a valid input returning to account login screen.");
                        Console.ReadKey();
                        _bankManager.RunATM();
                    }
                    break;

                case 1:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    var amountToDeposit =  PrinterClass.IndentAndReadLine("\n\n\tHow much would like to deposit? :", 8);
                    if (!string.IsNullOrEmpty(amountToDeposit))
                    {
                        if (double.TryParse(amountToDeposit, out double deposit))
                        { 
                        _bankManager.SelectedBanker.Balance = Math.Round(_bankManager.SelectedBanker.Balance + deposit, 2); 
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\n\tNot a valid amount of money.");
                        Console.ReadKey();
                        RunCurrentAccountMenu();
                    }
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n\n\tThank you for your Deposit! Your new Balance is:\n\n\t${_bankManager.SelectedBanker.Balance} dollars.");
                    string responseForDeposit = PrinterClass.IndentAndReadLine("\n\n\tIs there anything else you want to do today? Y/N", 8);
                    if (responseForDeposit == "y" || responseForDeposit == "Y" || responseForDeposit == "yes" || responseForDeposit == "Yes" || responseForDeposit == "YES")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\tGreat what else can I help with?");
                        Console.ReadKey();
                        RunCurrentAccountMenu();
                    }
                    if (responseForDeposit == "n" || responseForDeposit == "N" || responseForDeposit == "no" || responseForDeposit == "No" || responseForDeposit == "NO")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\tHave a great day!");
                        Console.ReadKey(true);
                        _bankManager.RunATM();


                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\tSorry not a valid input returning to account login screen.");
                        Console.ReadKey();
                        _bankManager.RunATM();
                    }
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    var amountToWithDraw = PrinterClass.IndentAndReadLine("\n\n\tHow much would like to withdraw? :", 8);
                    if (!string.IsNullOrEmpty(amountToWithDraw))
                    {
                        if (double.TryParse(amountToWithDraw, out double withdrawal))
                        {
                            _bankManager.SelectedBanker.Balance = Math.Round(_bankManager.SelectedBanker.Balance - withdrawal, 2);
                        }
                       
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\n\tNot a valid amount of money.\n");
                        Console.ReadKey();
                        RunCurrentAccountMenu();
                    }

                    if (_bankManager.SelectedBanker.Balance >= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"\n\n\tYou withdrew ${amountToWithDraw} dollars. Your new Balance is:\n\n\t${_bankManager.SelectedBanker.Balance} dollars.");
                        string responseForWithdrawal = PrinterClass.IndentAndReadLine("\n\n\tIs there anything else you want to do today? Y/N", 8);
                        if (responseForWithdrawal == "y" || responseForWithdrawal == "Y" || responseForWithdrawal == "yes" || responseForWithdrawal == "Yes" || responseForWithdrawal == "YES")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\tGreat what else can I help with?");
                            Console.ReadKey();
                            RunCurrentAccountMenu();
                        }
                        if (responseForWithdrawal == "n" || responseForWithdrawal == "N" || responseForWithdrawal == "no" || responseForWithdrawal == "No" || responseForWithdrawal == "NO")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\tHave a great day!");
                            Console.ReadKey(true);
                            _bankManager.RunATM();


                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\tSorry not a valid input returning to account login screen.");
                            Console.ReadKey();
                            _bankManager.RunATM();
                        }

                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n\n\tYou over drafted on your Account!" +
                            "\n\tAdd money soon or fees will incur!");
                        Console.WriteLine($"\n\n\tYour new Balance is ${_bankManager.SelectedBanker.Balance} dollars.");
                        Console.ReadKey();
                        string responseForWithdrawal = PrinterClass.IndentAndReadLine("\n\n\tIs there anything else you want to do today? Y/N", 8);
                        if (responseForWithdrawal == "y" || responseForWithdrawal == "Y" || responseForWithdrawal == "yes" || responseForWithdrawal == "Yes" || responseForWithdrawal == "YES")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\tGreat what else can I help with?");
                            Console.ReadKey();
                            RunCurrentAccountMenu();
                        }
                        if (responseForWithdrawal == "n" || responseForWithdrawal == "N" || responseForWithdrawal == "No" || responseForWithdrawal == "NO")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\tHave a great day!");
                            Console.ReadKey(true);
                            _bankManager.RunATM();


                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\tSorry not a valid input returning to account login screen.");
                            Console.ReadKey();
                            _bankManager.RunATM();
                        }
                    }

                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\tThank you for banking with us!");
                    Console.ReadKey(true);
                    _bankManager.RunATM();
                    break;

            }
        }

    }
}

