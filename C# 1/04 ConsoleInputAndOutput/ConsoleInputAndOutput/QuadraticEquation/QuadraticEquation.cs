﻿using System;

public class Program
{
    public static void Main()
    {

        double coefA = double.Parse(Console.ReadLine());
        double coefB = double.Parse(Console.ReadLine());
        double coefC = double.Parse(Console.ReadLine());
        double determinant = (coefB * coefB) - (4 * coefA * coefC);

        if (determinant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (determinant > 0)
        {
            Console.WriteLine("SOLUTION 1 - {0}", (-coefB - Math.Sqrt(determinant)) / (2 * coefA));
            Console.WriteLine("SOLUTION 2 - {0}", (-coefB + Math.Sqrt(determinant)) / (2 * coefA));
        }
        else
        {
            Console.WriteLine("DETERMINANT = 0 - > SOLUTION: {0}", (-coefB / (2 * coefA)));
        }

    }
}
