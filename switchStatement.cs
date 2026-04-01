using System;

class SwitchExample
{
    static void Main()
    {
        Console.Write("Enter a number (1-7) for the day of the week: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int dayNumber))
        {
            string dayName;
            switch (dayNumber)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }

            Console.WriteLine($"Day: {dayName}");
        }
        else
        {
            Console.WriteLine("Please enter a valid integer.");
        }
    }
}