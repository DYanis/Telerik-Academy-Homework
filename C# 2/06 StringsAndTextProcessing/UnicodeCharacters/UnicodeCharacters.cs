// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.

using System;
using System.Linq;


class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        foreach (var item in text)
        {
            string hexadecimalPresent = ((int)item).ToString("X");
            Console.Write("\\u00" + hexadecimalPresent);
        }
    }
}

