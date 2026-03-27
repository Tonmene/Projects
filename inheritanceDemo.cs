using System;
namespace InheritanceDemo
{
    class A
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
    class B : A
    {
        static void Main()
        {
            B obj = new B();
            obj.Method1();
            obj.Method2();
            Console.ReadKey();
        }
    }
}