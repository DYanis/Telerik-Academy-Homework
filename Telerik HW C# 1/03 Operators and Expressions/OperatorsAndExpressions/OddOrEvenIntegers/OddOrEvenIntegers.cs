// Problem 1. Odd or Even Integers
// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("{0} = Odd? False",number);
        else
            Console.WriteLine("{0} = Odd? True",number);
    }
}

