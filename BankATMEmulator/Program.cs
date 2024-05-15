namespace BankATMEmulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankManager bankManager = new BankManager(true);
            bankManager.RunATM();
        }
    }
}
