// Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int firsNumber = int.Parse(Console.ReadLine());
        int lastNumber = int.Parse(Console.ReadLine());

        for (int i = firsNumber; i < lastNumber; i++)
        {
            if (i % 5 == 0 && i % 7 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

