// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        int[] arr = { 2, 4, 1, 72, 12, 15, 11, 66, 34, 4, 3, 53, 22, 3, 8 };
        Console.WriteLine("Please enter index");
        int index = int.Parse(Console.ReadLine());
        int result = BiggestNumber(arr, index);
        Console.WriteLine(result);
    }

    static int BiggestNumber(int[] arr, int index)
    {
        int biggestNum = arr[index];
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] > biggestNum)
            {
                biggestNum = arr[i];
            }
        }
        return biggestNum;
    }
}

