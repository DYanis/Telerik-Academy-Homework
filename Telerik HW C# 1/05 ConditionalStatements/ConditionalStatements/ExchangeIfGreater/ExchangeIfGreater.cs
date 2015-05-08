// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the value

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c;
        
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine(a + " " + b);
    }
}

