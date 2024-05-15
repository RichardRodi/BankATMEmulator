namespace BankATMEmulator
{
    internal class BankMainMenu
    {
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
                        Console.WriteLine("Check Account Balance");
                        break;

                    case 1:
                        Console.WriteLine("Make a Deposit");
                        break;
                    case 2:
                        Console.WriteLine("Make a Withdrawal");
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
