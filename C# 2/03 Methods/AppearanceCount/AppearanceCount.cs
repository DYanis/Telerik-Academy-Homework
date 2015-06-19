// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.

using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        int[] array = { 4, 2, 4, 2, 3, 1, 2, 5, 7, 6, 5, 9, 0 };
        Console.WriteLine("enter number");
        int number = int.Parse(Console.ReadLine());
        int result = CountTheNumber(array, number);      
        Console.WriteLine(result);
    }

    static int CountTheNumber(int[] arr, int number)
    {
        int count = 0;
        foreach (var item in arr)
        {
            if (item == number)
            {
                count++;
            }
        }
        return count;
    }
}

