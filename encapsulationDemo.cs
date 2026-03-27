namespace EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.AccountNumber = 12345678;
            bank.Name = "Pranata";
            bank.GetBalance();
            bank.WithdrawAmount();
        }
    }
}