// Write a program that finds the most frequent number in an array.

using System;
using System.Linq;

class FrequentNumber
{
    static void Main()
    {
        int[] arr = new int[13] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int count = 0;
        int maxCout = 0;
        int? number = null; 

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == arr[i])
                {
                    count++;
                }
            }

            if (maxCout < count)
            {
                maxCout = count;
                number = arr[i];

            }
            count = 0;
        }
        Console.WriteLine("{0} ({1} times)",number,maxCout);
    }
}

