public class BaseClass
{
      public void Greetings()
      {
            Console.WriteLine("BaseClass Hello!");
      }
}

public class DerivedClass : BaseClass
{
      public new void Greetings()
      {
            Console.WriteLine("DerivedClass Hello");
      }
}