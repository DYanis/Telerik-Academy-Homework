// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter bit position");
        int bitPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter bit value");
        int bitValue = int.Parse(Console.ReadLine());

        if (bitValue == 1)
        {
            int mask = 1 << bitPosition;
            int numberOrMask = number | mask;
            Console.WriteLine(numberOrMask);
        }

        if (bitValue == 0)
        {
            int mask = ~(1 << bitPosition);
            int numberAndMask = number & mask;
            Console.WriteLine(numberAndMask);
        }
    }

}

