// Write an expression that extracts from given integer n the value of given bit at index p

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Please enter integer");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter bit at index");
        int wantedBit = int.Parse(Console.ReadLine());

        int mask = 1 << wantedBit;
        int numberAndMask = number & mask;
        int result = numberAndMask >> wantedBit;
        Console.WriteLine(result);

    }
}

