using BankATMEmulator.BankAccounts;
using BankATMEmulator.Print;

namespace BankATMEmulator
{
    internal class AccountLoginScreen : BaseAccount
    {
        private BankManager _bankManager;
        private PersonalAccount personalAccount;

        public AccountLoginScreen(BankManager bankManager)
        {
            _bankManager = bankManager;
        }

        public AccountLoginScreen(PersonalAccount personalAccount)
        {
            this.personalAccount = personalAccount;
        }

        public override void ChooseAccount(Type accountType)
        {
            _bankManager.BaseAccounts.Where(x => x.GetType() == accountType).FirstOrDefault().RunCurrentAccountMenu();
        }


        public void RunATMLogin()
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine($"{ArtAssets.BankMenu}\n\n\n");

            string accountName = PrinterClass.IndentAndReadLine("Please Enter Your Login:", 8);
            int pin;

            while (!int.TryParse(PrinterClass.IndentAndReadLine("Please Enter Your PIN:", 8), out pin))
            {
                Console.WriteLine("\tInvalid PIN. Please enter a valid number:");
                Console.ReadKey();
                RunATMLogin();
            }

            if (_bankManager.ValidateLogin(accountName, pin))
            {
                ChooseAccount(typeof(PersonalAccount));
            }
            else
            {
                Console.WriteLine("\tInvalid Credentials, Please Enter Valid Login Information");
                Console.ReadKey();
                RunATMLogin();
            }

        }

        public override void RunCurrentAccountMenu()
        {
            throw new NotImplementedException();
        }
    }

}
