using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
            ParameterizedConstructor obj2 = new ParameterizedConstructor(20);
            Console.ReadKey();
        }
    }

    public class ParameterizedConstructor
    {
        public ParameterizedConstructor(int i)
        {
            Console.WriteLine($"Parameterized Constructor is Called : {i}");
        }
    }
}