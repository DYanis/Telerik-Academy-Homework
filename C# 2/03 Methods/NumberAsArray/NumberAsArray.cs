//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr/[i] /contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter Number : " );
        string number = Console.ReadLine();
        var result = ArrayNumber(number);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    static List<int> ArrayNumber(string input)
    {
        List<int> result = new List<int>();
        for (int i = input.Length-1; i >= 0; i--)
        {
            result.Add(input[i] - '0');
        }
        return result;
    }
}

