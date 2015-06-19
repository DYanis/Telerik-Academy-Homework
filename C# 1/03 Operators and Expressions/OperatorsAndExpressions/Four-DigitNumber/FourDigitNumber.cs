// Problem 6. Four-Digit Number
// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
// Prints on the console the number in reversed order: dcba (in our example 1102).
// Puts the last digit in the first position: dabc (in our example 1201).
// Exchanges the second and the third digits: acbd (in our example 2101).

using System;

class FourDigitNumber
{
    static void Main()
    {
        string number = Console.ReadLine();

        int SumOfDigits = (int)Char.GetNumericValue(number[0]) + (int)Char.GetNumericValue(number[1]) +
            (int)Char.GetNumericValue(number[2]) + (int)Char.GetNumericValue(number[3]);

        char a = number[0];
        char b = number[1];
        char c = number[2];
        char d = number[3];
        
        Console.WriteLine("sum of digits = " + SumOfDigits);
        Console.WriteLine("reversed = {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("last digit in front = {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("second and third digits exchanged = {0}{1}{2}{3}", a, c, b, d);
    }
}
