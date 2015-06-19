// Write a program that finds the sequence of maximal sum in given array.

using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        int maxSum = 0;
        int start = 0;
        int end = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            if (sum > maxSum)
            {
                maxSum = sum;
                end = i;
            }
            if (sum < 0)
            {
                sum = 0;
                start = i + 1;
            }
        }
        for (int i = start; i <= end; i++)
        {
            Console.Write(arr[i]);

            if (i == end)
            {
                break;
            }
            Console.Write(", ");
        }
        Console.WriteLine();      
    }
}