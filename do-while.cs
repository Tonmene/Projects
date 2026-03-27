using System;

class DoWhileExample
{
    static void Main()
    {
        int secretNumber = 7;
        int guess;

        Console.WriteLine("Guess the secret number (1-10). Enter 0 to quit.");

        do
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                if (guess == secretNumber)
                {
                    Console.WriteLine("Correct! The secret number is 7.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high. Try a smaller number.");
                }
                else if (guess < secretNumber && guess != 0)
                {
                    Console.WriteLine("Too low. Try a bigger number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
                guess = -1;
            }

            if (guess == 0)
            {
                Console.WriteLine("Quitting. The secret number was 7.");
            }

        } while (guess != secretNumber && guess != 0);

        Console.WriteLine("Done.");
    }
}