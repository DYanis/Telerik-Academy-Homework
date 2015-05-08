// Write a program that extracts from a given text all sentences containing given word.

using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            List<string> sentences = new List<string>(text.Split('.'));

            foreach (var item in sentences)
            {
                if (item.Contains(" in "))
                {
                    Console.WriteLine(item.Trim());
                }               
            }
        }
    }
}
