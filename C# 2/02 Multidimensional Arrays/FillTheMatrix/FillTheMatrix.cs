using System;
using System.Linq;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        int count = 1;

        for (int coll = 0; coll < n; coll++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, coll] = count;
                count++;               
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int coll = 0; coll < n; coll++)
            {
                Console.Write("{0,4}", matrix[row, coll]);
            }
            Console.WriteLine();
        }

    }
}

