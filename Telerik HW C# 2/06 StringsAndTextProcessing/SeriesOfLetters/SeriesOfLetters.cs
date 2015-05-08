// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Linq;
using System.Text;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string text = Console.ReadLine() + " ";
            var result = new StringBuilder();
            
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i - 1])
                {
                    result.Append(text[i-1]);
                }
            }           
            Console.WriteLine(result.ToString());
        }
    }
}
