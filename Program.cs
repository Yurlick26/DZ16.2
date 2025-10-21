using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine(); // читаем строку от пользователя

        if (double.TryParse(input, out double number))
        {
            Console.WriteLine($"You entered a number: {number}");
        }
        else
        {
            Console.WriteLine("Error: The entered value is not a number!");
        }
    }
}
