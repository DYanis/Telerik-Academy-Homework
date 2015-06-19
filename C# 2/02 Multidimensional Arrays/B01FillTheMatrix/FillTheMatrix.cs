using System;
using System.Linq;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int count = 1;

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = count;
                    count++;
                }
            }
            else
                for (int row = n-1; row >= 0; row--)
                {
                    matrix[row, col] = count;
                    count++;
                }
        }

        // print matrix
        for (int row = 0; row < n; row++)
        {
            for (int coll = 0; coll < n; coll++)
            {
                Console.Write(matrix[row, coll] + "    ");
            }
            Console.WriteLine();
        }


    }
}

