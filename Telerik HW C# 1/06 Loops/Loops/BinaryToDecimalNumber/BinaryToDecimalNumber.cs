// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        long result = 0;
        int[] theList = new int[binaryNumber.Length];

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            theList[i] = (binaryNumber[i] - '0');
        }

        for (int i = 0; i < theList.Length; i++)
        {
            result = (result * 2) + theList[i];
        }
        

        Console.WriteLine(result);
    }
}

