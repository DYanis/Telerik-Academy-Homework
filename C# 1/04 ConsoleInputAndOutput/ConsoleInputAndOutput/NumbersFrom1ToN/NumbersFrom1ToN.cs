// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        
        while (counter < n + 1)
        {
            Console.WriteLine(counter++);
        }
    }
}

