// Write a program that reverses the words in given sentence.

using System;
using System.Linq;

namespace ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            Console.WriteLine("Enter sentence");
            string text = Console.ReadLine();
            string[] arr = text.Split().Reverse().ToArray();
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
