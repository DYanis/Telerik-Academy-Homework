// Write a program that enters 3 real numbers and prints them sorted in descending order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        string output = "";

        if (a > b && a > c)
        {
            output += Convert.ToString(a);
            if (b>c)
            {
                output += " " + Convert.ToString(b) + " " + Convert.ToString(c);
            }
            else
                output += " " + Convert.ToString(c) + " " + Convert.ToString(b);
        }


        if (b > a && b > c)
        {
            output += Convert.ToString(b);
            if (a > c)
            {
                output += " " + Convert.ToString(a) + " " + Convert.ToString(c);
            }
            else
                output += " " + Convert.ToString(c) + " " + Convert.ToString(a);

        }
        if (c > a && c > b)
        {
            output += Convert.ToString(c);
            if (b > a)
            {
                output += " " + Convert.ToString(b) + " " + Convert.ToString(a);
            }
            else
                output += " " + Convert.ToString(a) + " " + Convert.ToString(b);
        }

        Console.WriteLine(output);
    }
}

