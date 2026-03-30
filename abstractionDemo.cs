//Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
//Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).

using System;
namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing First Bank");
            IBank first = BankFactory.GetBankObject("First");
            first.ValidateCard();
            first.WithdrawMoney();
            first.CheckBalanace();
            first.BankTransfer();
            first.MiniStatement();

            Console.WriteLine("\nTransaction doing Hera Bank");
            IBank hera = BankFactory.GetBankObject("Hera");
            hera.ValidateCard();
            hera.WithdrawMoney();
            hera.CheckBalanace();
            hera.BankTransfer();
            hera.MiniStatement();

            Console.Read();
        }
    }

    public interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();
    }

    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if (bankType == "First")
            {
                BankObject = new first();
            }
            else if (bankType == "Hera")
            {
                BankObject = new hera();
            }
            return BankObject;
        }
    }

    public class First : IBank
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

    public class Hera : IBank
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