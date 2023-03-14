using System;

namespace TemperatureConvert
{
    internal class Program
    {
        static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            //double celsius = Math.Round(FahrenheitToCelsius(fahrenheit), 2);

            Console.WriteLine($"{celsius:F2}");
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}