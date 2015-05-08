// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Linq;

namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main()
        {
            Random x = new Random();            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(x.Next(101)+100);
            }
        }
    }
}
