// Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;
using System.Linq;

namespace D01FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            recursionMatrix(n, 0, 0, 0, matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void recursionMatrix(int n, int counter, int startPointR, int startPointC, int[,] matrix)
        {
            if (counter == matrix.GetLength(0) * matrix.GetLength(1))
            {
                return;
            }

            // lqva stena
            for (int row = 0; row < n; row++)
            {
                counter++;
                matrix[startPointR, startPointC] = counter;
                startPointR++;
            }

            // dolna stena
            startPointR--;
            for (int i = 0; i < n - 1; i++)
            {
                startPointC++;
                counter++;
                matrix[startPointR, startPointC] = counter;
            }

            // dqsna stena
            for (int i = 0; i < n - 1; i++)
            {
                startPointR--;
                counter++;
                matrix[startPointR, startPointC] = counter;
            }

            // goorna stena              
            for (int i = 0; i < n - 2; i++)
            {
                startPointC--;
                counter++;
                matrix[startPointR, startPointC] = counter;
            }

            startPointR++;
            n -= 2;
            recursionMatrix(n, counter, startPointR, startPointC, matrix);
        }
    }
}
