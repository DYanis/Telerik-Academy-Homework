// Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found

using System;
using System.Linq;

namespace LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            char[] word = Console.ReadLine().ToArray();

            for (int i = 0; i < word.Length; i++)
            {
                int sameChar = word.Count(x => x == word[i]);
                Console.WriteLine("{0} - ({1})times",word[i],sameChar);
                word = word.Where(x => x != word[i]).ToArray();
                i--;
            }            
        }
    }
}
