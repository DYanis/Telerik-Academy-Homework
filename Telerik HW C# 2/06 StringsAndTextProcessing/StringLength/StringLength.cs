//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is //less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Linq;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            if (text.Length > 20) { Console.WriteLine("ERORR !!!"); return; }
            int needChar = 0;
            if (text.Length < 20)
            {
                needChar = 20 - text.Length;
            }
            Console.WriteLine(text + (new string('*', needChar)));
        }
    }
}
