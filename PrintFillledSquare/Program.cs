using System;

namespace PrintFillledSquare
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintHeaderRow(number);
            PrintMiddleRow(number);
            PrintMiddleRow(number); // To looks like in the example
            PrintFooterRow(number);

        }

        static void PrintFooterRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        static void PrintMiddleRow(int number)
        {
            Console.Write('-');
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static void PrintHeaderRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
    }
}