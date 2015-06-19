// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("enter side a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("enter side b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("enter side h");
        double h = double.Parse(Console.ReadLine());

        double S = ((a + b) * h) / 2;
        Console.WriteLine("S = " + S);
    }
}

