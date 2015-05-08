// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int startNumber = 1;
        int lastNumber = n;


        for (int row = 0; row < n; row++)
        {
            for (int col = startNumber; col <= lastNumber; col++)
            {
                Console.Write(col);
            }

            Console.WriteLine();
            startNumber++;
            lastNumber++;
        }
    }
}

