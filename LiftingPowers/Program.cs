using System;

namespace LiftingPowers
{
    internal class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPowers(number,power));
        }

        static double RaiseToPowers(double number, int power)
        {
            return Math.Pow(number,power);
        }
    }
}