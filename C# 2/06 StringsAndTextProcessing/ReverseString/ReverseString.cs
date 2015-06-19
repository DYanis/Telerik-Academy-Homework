// Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Linq;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Enter word");
            var reverseWord = Console.ReadLine().ToArray().Reverse();
            foreach (var item in reverseWord) Console.Write(item);
        }
    }
}
