// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.// 

using System;
using System.Linq;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int sum = 0;
            
            foreach (var item in arr)
            {
                sum += int.Parse(item);
            }
            Console.WriteLine(sum);
        }   
    }
}
