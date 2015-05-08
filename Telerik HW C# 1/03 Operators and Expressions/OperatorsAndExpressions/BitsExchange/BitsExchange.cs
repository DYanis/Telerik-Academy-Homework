// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
using System.Numerics;


class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Please enter number");
        long number = long.Parse(Console.ReadLine());

        long firstAddtoMask = 1 << 24;
        long secondAddtoMask = 1 << 25;
        long thirdAddtoMask = 1 << 26;
        long mask = firstAddtoMask | secondAddtoMask | thirdAddtoMask;
        
        Console.WriteLine(mask);  //////

        long numberAndMask = number & mask;
        Console.WriteLine(Convert.ToString(numberAndMask, 2).PadLeft(32, '0'));

        //////////////////// Not Finished




    }
}

