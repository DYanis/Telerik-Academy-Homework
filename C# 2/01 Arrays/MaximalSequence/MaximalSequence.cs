// Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        int[] arr = new int[20] { 2, 3, 4, 5, 2, 2, 7, 7, 7, 7, 7, 2, 3, 7, 7, 0, 0, 3, 3, 3 };

        int count = 1;
        int maxCount = 1;
        int? number = null;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                count++;
            }
            else
            {
                if (maxCount < count)
                {
                    maxCount = count;
                    number = arr[i];
                }
                count = 1;
            }
        }

        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(number);
            if (i == maxCount - 1) continue;
            Console.Write(',');
        }
    }
}

