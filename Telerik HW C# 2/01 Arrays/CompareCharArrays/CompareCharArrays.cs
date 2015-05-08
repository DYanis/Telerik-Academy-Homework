// Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        char[] arr1 = { 's', 'o', 'S', 'e', 'z', 'R', 'm', 'm', };
        char[] arr2 = { 'S', 'o', '0', 'E', '3', 'R', '2', 'm', };

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] == arr2[i])
            {
                Console.WriteLine(arr1[i]);
            }
        }
    }
}

