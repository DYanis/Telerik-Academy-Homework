// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        string word = Console.ReadLine();

        char[] alphabet = {'1','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

        foreach (var item in word)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (item == alphabet[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

