// 15.Write a program that finds all prime numbers in the range [1...10 000 000].
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] array = new bool[10000000];
        int length = array.Length;
        int sqrtLength = (int)Math.Sqrt(length);
        int counter = 1;
        for (int i = 2; i < sqrtLength; i++)
        {
            if (array[i] == false)
            {
                for (int j = i * i; j < length; j = j + i)
                {
                    array[j] = true;
                }
            }
        }
        // it is very slow because there are a lot of numbers to print on the console from 2...9 999 991 and alltogether 664580
        for (int i = 2; i < length; i++)
        {
            if (array[i] == false)
            {
                counter++;
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
        Console.WriteLine(counter);
    }
}
