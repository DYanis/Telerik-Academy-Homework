using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];
        int count = 1;

        /// Generate Matrix        
        for (int i = 0; i < matrix.GetLongLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLongLength(1); j++)
            {
                matrix[i, j] = count;
                count++;
            }
        }
        matrix[0, m - 1] = 900;

        /// Search Max sum of 3x3 matrix
        int sum = 0;
        int maxSum = 0;
        
        for (int i = 0; i < matrix.GetLongLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLongLength(1) - 2; j++)
            {
                sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    sum = 0;
                }
            }
        }

        ///// Print Matrix
        for (int i = 0; i < matrix.GetLongLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLongLength(1); j++)
            {
                Console.Write("{0,5}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine(maxSum);
    }
}

