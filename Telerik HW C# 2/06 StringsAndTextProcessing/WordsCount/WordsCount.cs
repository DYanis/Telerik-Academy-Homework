// Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;

namespace WordsCount
{
    class WordsCount
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            List<string> theList = new List<string>(words.ToList<string>());

            for (int i = 0; i < theList.Count; i++)
            {
                int sameCount = theList.Count(x => x == theList[i]);
                Console.WriteLine("{0} - ({1})times",theList[i] , sameCount);

                theList = theList.Where(x => x != theList[i]).ToList<string>();
                i -= 1;
            }
        }
    }
}
