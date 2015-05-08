// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        int last = 0;
        int back = 1;
        int newSum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write(last + ", ");
            newSum = last + back;
            last = back;
            back = newSum;
        }
    }
}

