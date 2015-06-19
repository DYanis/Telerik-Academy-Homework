// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;
using System.Linq;

class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("enter N");
        int countNumbers = int.Parse(Console.ReadLine());
        Console.WriteLine("enter K");
        int maxSum = int.Parse(Console.ReadLine());
        int[] arr = new int[countNumbers];
        int? result = 0;

        for (int i = 0; i < countNumbers; i++)
        {
            int number = int.Parse(Console.ReadLine());
            arr[i] = number;
        }

        foreach (var item in arr)
        {
            if (item == maxSum)
            {
                result += item;
            }
        }
        Console.WriteLine(result);
    }
}

