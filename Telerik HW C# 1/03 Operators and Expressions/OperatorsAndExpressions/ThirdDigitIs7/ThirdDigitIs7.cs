// Problem 5. Third Digit is 7?
// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        string Number = Console.ReadLine();
        int lenghtOfNumber = Number.Length;

        if (lenghtOfNumber > 2)
        {
            char theChar = Number[lenghtOfNumber - 3];
            
            if (theChar == '7')
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
        }
        else
            Console.WriteLine("false");
    }
}

