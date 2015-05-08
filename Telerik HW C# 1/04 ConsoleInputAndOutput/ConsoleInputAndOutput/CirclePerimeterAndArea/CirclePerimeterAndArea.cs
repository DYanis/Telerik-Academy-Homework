// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter radius: ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = r * 2 * 3.14;
        double area = r * r * 3.14;
        Console.WriteLine("Perimeter: {0}",perimeter);
        Console.WriteLine("Area: {0}",area);
    }
}

