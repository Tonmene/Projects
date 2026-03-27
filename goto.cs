using System;
namespace JumpStatementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st Statement: ");

            goto label1;
            
            Console.WriteLine("2nd Statement: ");

        label1:
            Console.WriteLine("3rd Statement: ");

            Console.WriteLine("End of Main Method Statement: ");
            Console.ReadKey();
        }
    }
}