// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter number");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter bit position");
        int bitPostion = int.Parse(Console.ReadLine());

        bool result = false;

        int mask = 1 << bitPostion;
        int numberAndBitPosition = number & mask;
        int nextNumber = numberAndBitPosition >> bitPostion;
        
        if (nextNumber == 1)
        {
            result = true;
        }
        Console.WriteLine(result);
    }
}

