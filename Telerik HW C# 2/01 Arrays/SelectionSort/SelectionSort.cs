//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        int[] arr = new int[10] { 7, -2, 13, 14, 5, 6, 8, 0, 1, 9 };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int change = arr[i];
                    arr[i] = arr[j];
                    arr[j] = change;
                }
            }
        }

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
}

