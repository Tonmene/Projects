//exception = is an error tht occurs during execution

//try = try some code that is considered "dangerous"
//catch = catches and handles exceptions when they occur
//finally = always executes regardless if exception is caught or not

using System;
namespace exceptionHandlingDemo
{
      class program
      {
            static void main(string[] args)
            {

                  double x;
                  double y;
                  double result;

                  try
                  {
                        Console.Write("Enter a number 1: ");
                        x = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter a number 2: ");
                        y = Convert.ToInt32(Console.ReadLine());

                        result = x / y;

                        Console.WriteLine("result: " + result);

                  
                  }

                  catch (FormatException e)
                  {
                        Console.WriteLine("Enter ONLY numbers please!");
                  }

                  catch (DivideByZeroException e)
                  {
                        Console.WriteLine("Division not possible");
                  }

                  catch (Exception e)
                  {
                        Console.WriteLine("Something went wrong");
                  }

                  finally
                  {
                        Console.WriteLine("Thanks for visiting");
                  }

                  Console.ReadKey();
            }
      }
}