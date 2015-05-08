// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

using System;
using System.Collections.Generic;
using System.Linq;

namespace ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            List<string> forbiddenWords = new List<string> { "PHP", "CLR", "Microsoft" };

            foreach (var item in forbiddenWords)
            {
                text = text.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(text);
        }
    }
}
