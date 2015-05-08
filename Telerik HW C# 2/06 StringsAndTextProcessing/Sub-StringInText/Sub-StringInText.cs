// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Linq;

namespace Sub_StringInText
{
    class SubStr
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            int startIndex = 0;
            int count = 0;
            while (true)
            {
                int index = text.ToLower().IndexOf("in", startIndex);
                if (index > -1)
                {
                    count++;
                }
                else break;

                startIndex = index;
                startIndex += 2;
            }
            Console.WriteLine(count);
        }
    }
}
