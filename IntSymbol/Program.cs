using System;

namespace IntSymbol
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintSymbol(number);
        }

        static void PrintSymbol(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            } else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            } else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}