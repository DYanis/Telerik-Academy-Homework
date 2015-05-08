// Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
using System.Collections.Generic;
using System.Linq;

class FindSumInArray
{
    static void Main()
    {
        Console.WriteLine("please enter S");
        int s = int.Parse(Console.ReadLine());
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        int sum = 0;
        List<int> resultList = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                resultList.Add(arr[j]);
                if (sum == s)
                {
                    Console.WriteLine(string.Join(",", resultList));
                }
            }
            resultList.Clear();
            sum = 0;
        }
    }
}

