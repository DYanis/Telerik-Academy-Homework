using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger nProduct2 = n * 2;
        BigInteger nSumBy1 = n + 1;

        BigInteger factorialN = 1;
        BigInteger factorialNProduct2 = 1;
        BigInteger factorialNSumBy1 = 1;

        for (BigInteger i = 1; i <= nProduct2; i++)
        {
            if (i <= n)
            {
                factorialN *= i;
            }

            if (i <= nSumBy1)
            {
                factorialNSumBy1 *= i;
            }

            factorialNProduct2 *= i;
        }
        BigInteger result = factorialNProduct2 / (factorialN * factorialNSumBy1);
        Console.WriteLine(result);


    }
}

