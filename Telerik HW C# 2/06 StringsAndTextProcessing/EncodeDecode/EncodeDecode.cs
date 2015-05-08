//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string /with/ the first of the key, the second – with the second, etc. When the last key character is reached, the next/ is /the first.

using System;
using System.Linq;
using System.Text;

namespace EncodeDecode
{
    class EncodeDecode
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.Write("Enter keyword: ");
            char[] keyword = Console.ReadLine().ToArray();
            var result = new StringBuilder();

            string[] arr = text.Split();

            foreach (var item in arr)
            {
                var charArr = item.ToArray();
                int keyIter = 0;
                for (int i = 0; i < charArr.Length; i++)
                {
                    result.Append(charArr[i] ^ keyword[keyIter]);
                    keyIter++;
                    if (keyIter == keyword.Length) keyIter = 0;
                }
                result.Append(" ");
            }
            Console.WriteLine(result);

        }
    }
}
