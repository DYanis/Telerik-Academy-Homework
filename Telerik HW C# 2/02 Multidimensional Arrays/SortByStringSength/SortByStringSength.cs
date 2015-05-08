// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        string[] fruits = { "Apple", "Orange", "Peanapple", "Banana", "SS" };

        fruits = LenghtCompare(fruits);

        foreach (var item in fruits)
        {
            Console.WriteLine(item);
        }
    }

    static string[] LenghtCompare(string[] arr)
    {
        string[] res = arr.OrderBy(x => x.Length).ToArray();
        return res;
    }
}