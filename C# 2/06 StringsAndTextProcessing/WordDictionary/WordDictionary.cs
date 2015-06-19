// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;
using System.Linq;

namespace WordDictionary
{
    class WordDictionary
    {
        static void Main()
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add(".NET", "platform for applications from Microsoft");
                dic.Add("CLR", "execmanaged execution environment for .NETution");
                dic.Add("namespace", "hierarchical organization of classes");

                Console.WriteLine("Enter word");
                string key = Console.ReadLine();
                Console.WriteLine(dic[key]);
            }
            catch (Exception)
            {
                Console.WriteLine("This word isn't in dictionary");                
            }            
        }
    }
}
