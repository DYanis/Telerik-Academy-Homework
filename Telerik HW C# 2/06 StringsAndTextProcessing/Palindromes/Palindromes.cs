// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            Console.WriteLine("Enter words separete by space");
            string text = Console.ReadLine();
            List<string> words = new List<string>(text.Split());

            foreach (var item in words)
            {
                char[] intemToReverseArr = item.ToArray().Reverse().ToArray();
                string revesedItem = string.Join("", intemToReverseArr);

                if (item == revesedItem)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
