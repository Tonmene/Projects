using System;
namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing First Bank");
            First first = new First();
            first.ValidateCard();
            first.WithdrawMoney();
            first.CheckBalanace();
            first.BankTransfer();
            first.MiniStatement();

            Console.WriteLine("\nTransaction doing Hera Bank");
            Hera hera = new Hera();
            hera.ValidateCard();
            hera.WithdrawMoney();
            hera.CheckBalanace();
            hera.BankTransfer();
            hera.MiniStatement();

            Console.Read();
        }
    }
    
    public class First
    {
        public void BankTransfer()
        {
            Console.WriteLine("First Bank Bank Transfer");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("First Bank Check Balanace");
        }

        public void MiniStatement()
        {
            Console.WriteLine("First Bank Mini Statement");
        }

        public void ValidateCard()
        {
            Console.WriteLine("First Bank Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("First Bank Withdraw Money");
        }
    }

    public class Hera
    {
        public void BankTransfer()
        {
            Console.WriteLine("Hera Bank Bank Transfer");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("Hera Bank Check Balanace");
        }

        public void MiniStatement()
        {
            Console.WriteLine("Hera Bank Mini Statement");
        }

        public void ValidateCard()
        {
            Console.WriteLine("Hera Bank Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Hera Bank Withdraw Money");
        }
    }
}