// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool result = false;
        int[] arr = { 10, 1, 82, 32, 4, 53, 6, 8, 9, 104, 211, 12 };
        Array.Sort(arr);

        int start = 0;
        int end = arr.Length;
        while (true)
        {
            int middle = (start + end) / 2;
            if (arr[middle] == number)
            {
                result = true;
                break;
            }
            else
            {
                if (number < arr[middle])
                {
                    end = middle;
                }
                else
                {
                    start = middle;
                }
            }
        }
        Console.WriteLine(result);
    }
}

