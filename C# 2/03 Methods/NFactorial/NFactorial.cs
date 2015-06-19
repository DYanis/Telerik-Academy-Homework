// Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Linq;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger result = Factorial(n);
        Console.Write("{0}! = ", n);
        Console.WriteLine(result);
    }

    static BigInteger Factorial(BigInteger n)
    {
        BigInteger factorialN = 1;

        for (BigInteger i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        return factorialN;
    }
}

