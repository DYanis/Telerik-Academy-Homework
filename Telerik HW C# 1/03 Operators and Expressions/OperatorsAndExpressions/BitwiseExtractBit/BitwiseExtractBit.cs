﻿// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

using System;

class BitwiseExtractBit
{
    static void Main()
    {
        Console.WriteLine("Please enter unsigned integer");
        int number = Int32.Parse(Console.ReadLine());

        int mask = 1 << 3;
        int numberAndMask = number & mask;
        int result = numberAndMask >> 3;
        Console.WriteLine(result);
    }
}

