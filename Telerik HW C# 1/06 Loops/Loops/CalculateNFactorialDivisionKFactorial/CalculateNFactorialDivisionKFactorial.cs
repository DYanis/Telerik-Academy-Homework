// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.

using System;

class CalculateNFactorialDivisionKFactorial
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());
        long factorialN = 1;
        long factorialK = 1;
        long result = 0;


        for (long i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i > k)
            {
                continue;
            }
            factorialK *= i;
        }
        result = factorialN / factorialK;
        Console.WriteLine(result);
    }
}

