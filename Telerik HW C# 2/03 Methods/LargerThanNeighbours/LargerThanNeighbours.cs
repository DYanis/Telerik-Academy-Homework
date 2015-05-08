// Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] arr = { 3, 7, 54, 23, 12, 41, 34, 52, 23, 32, 23 };
        Console.WriteLine("Enter index");
        int index = int.Parse(Console.ReadLine());
        bool result = CheckNeighbours(arr, index);
        Console.WriteLine(result);
    }

    static bool CheckNeighbours(int[] arr, int index)
    {
        if (index <= 0 || index > arr.Length - 1)
        {
            return false;
        }

        if (arr[index - 1] < arr[index] && arr[index + 1] < arr[index])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

