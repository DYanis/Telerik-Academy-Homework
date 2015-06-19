//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Linq;

namespace OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(' ');
            Array.Sort(arr);            
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
