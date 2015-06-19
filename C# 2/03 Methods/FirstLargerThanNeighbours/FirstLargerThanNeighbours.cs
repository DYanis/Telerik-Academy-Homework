//Write a method that returns the index of the first element in array that is larger than its neighbours,  or /-1, /if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] arr = { 4, 1, 3, 23, 12, 41, 34, 52, 23, 32, 23 };
        int result = CheckNeighbours(arr);
        Console.WriteLine(result);
    }

    static int CheckNeighbours(int[] arr)
    {
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                return i;
            }
        }
        return -1;
    }
}

