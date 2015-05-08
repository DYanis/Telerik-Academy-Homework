//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;
using System.Linq;

class SortByStringSength
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter array size");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter K");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("enter number");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);     
        arr = arr.Where(x => x <= k ).ToArray();
        Console.WriteLine(arr.Max());
    }
}
