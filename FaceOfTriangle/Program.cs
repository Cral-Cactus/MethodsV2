﻿using System;

namespace FaceOfTriangle
{
    internal class Program
    {
        static void Main()
        {
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(widht, height);

            Console.WriteLine(area);
        }

        static double GetTriangleArea(double widht, double height)
        {
            return widht * height / 2;
        }
    }
}