// Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Linq;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] arr = new int[20] { 7, 2, 3, 4, 5, 6, 7, 8, 79, 1, 11, 12, 13, 14, 15, 0, 17, 18, 19, 20 };

        int count = 1;
        int maxCount = 1;
        int? number = null;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] + 1 == arr[i + 1])
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
            if (count == arr.Length)
            {
                maxCount = count;
                number = arr[i] + 1;
            }
            else if (i + 2 == arr.Length && count > maxCount)
            {
                maxCount = count;
                number = arr[i] + 1;
            }
        }

        number = number - maxCount + 1;
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(number);
            if (i == maxCount - 1) continue;
            Console.Write(',');
            number++;
        }
    }
}

