using System;
using System.Linq;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int countCenter = n * n / 2 - n / 2 + 1;
        int middleDiag = (n * 2 - 4) / 2;

        for (int i = 0; i < n; i++)
        {
            matrix[i, i] = countCenter;
            countCenter++;
        }

        matrix[n - 1, 0] = 1;
        matrix[0, n - 1] = n * n;

        ////////////////////////////////////////////
        int startR = n - 2;
        int startC = 0;
        int count = 1;
        int elementsDiag = 2;
        for (int i = 0; i < middleDiag; i++)
        {
            startR = n - 2;
            startR -= i;
            for (int j = 0; j < elementsDiag; j++)
            {
                matrix[startR, startC] = ++count;
                startR++;
                startC++;
            }
            startC = 0;
            elementsDiag++;
        }

        ////////////////////////////////////////////
        count += n;
        startC = 1;
        for (int i = 0; i < middleDiag; i++)
        {
            elementsDiag--;
            startR = 0;
            for (int j = 0; j < elementsDiag; j++)
            {
                matrix[startR, startC] = ++count;
                startR++;
                startC++;
            }
            startC -= elementsDiag - 1;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

