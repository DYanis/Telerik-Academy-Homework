//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several /        neighbour /elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

using System;
using System.Linq;

class SequenceNMatrix
{
    static void Main()
    {
        string[,] matrix =          
       { { "HI!", "SOS", "dsd", "SOS" },
         { "SOS", "C#!", "SOS", "DOS" },
         { "xxx", "SOS", "HI!", "SOS" },
         { "Hi!", "C#!", "SOS", "HI!" },
         { "tex", "C#!", "OK!", "SOS" },
         { "HI!", "HI!", "HI!", "HI!" } };

        // Print matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,6}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        int totalCount = 1;
        int countSameString = 1;
        string sameString = "";

        /// Scan Rows
        for (int row = 0; row < matrix.GetLongLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    countSameString++;

                    if (totalCount < countSameString)
                    {
                        totalCount = countSameString;
                        sameString = matrix[row, col];
                    }
                }
                else
                    countSameString = 1;
            }
            countSameString = 1;
        }

        /// Scan Cols
        int totalCountCol = 1;
        int countSameStringCol = 1;
        string sameStringCol = "";

        for (int col = 0; col < matrix.GetLongLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLongLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    countSameStringCol++;
                    if (totalCountCol < countSameStringCol)
                    {
                        totalCountCol = countSameStringCol;
                        sameStringCol = matrix[row, col];
                    }
                }
            }
            countSameStringCol = 1;
        }

        var diagonals = ScanDiagonals(matrix);

        if (totalCount > totalCountCol && totalCount > diagonals.Item1)
        {
            for (int i = 0; i < totalCount; i++)
            {
                Console.Write(sameString);
                if (totalCount - 1 == i) break;
                Console.Write(',');
            }
        }
        else if (totalCountCol > totalCount && totalCountCol > diagonals.Item1)
        {
            for (int i = 0; i < totalCountCol; i++)
            {
                Console.Write(sameStringCol);
                if (totalCountCol - 1 == i) break;
                Console.Write(',');
            }
        }
        else
        {
            for (int i = 0; i < diagonals.Item1; i++)
            {
                Console.Write(diagonals.Item2);
                if (diagonals.Item1 - 1 == i) break;
                Console.Write(',');
            }
        }
        Console.WriteLine();
    }

    static Tuple<int, string> ScanDiagonals(string[,] matrix)
    {
        int numberFirstDiagonals = matrix.GetLength(0) - 1;
        int totalCountDiag = 1;
        int countSameStringDiag = 1;
        string sameStringDiag = "";

        // first middle
        int startR = matrix.GetLength(0) - 2;
        int startC = 0;
        int elements = 2;

        for (int i = 0; i < numberFirstDiagonals; i++)
        {
            startR = matrix.GetLength(0) - 2 - i;
            for (int j = 0; j < elements - 1; j++)
            {
                if (startR + 1 > matrix.GetLength(0) - 1 || startC + 1 > matrix.GetLength(1) - 1)
                {
                    continue;
                }
                if (matrix[startR, startC] == matrix[startR + 1, startC + 1])
                {
                    countSameStringDiag++;
                    if (totalCountDiag < countSameStringDiag)
                    {
                        totalCountDiag = countSameStringDiag;
                        sameStringDiag = matrix[startR, startC];
                    }
                }
                startR++;
                startC++;
            }
            elements++;
            startC = 0;
            countSameStringDiag = 1;
        }

        // second middle
        int numberSecondDiagonals = matrix.GetLength(1) - 2;
        int totalCountDiag2 = 1;
        int countSameStringDiag2 = 1;
        string sameStringDiag2 = "";
        int startR2 = 0;
        int startC2 = 1;
        int elements2 = matrix.GetLength(1) - 1;

        for (int i = 0; i < numberSecondDiagonals; i++)
        {
            startC2 = (1 + i);
            for (int j = 0; j < elements2; j++)
            {
                if (startR2 + 1 > matrix.GetLength(0) - 1 || startC2 + 1 > matrix.GetLength(1) - 1)
                {
                    continue;
                }
                if (matrix[startR2, startC2] == matrix[startR2 + 1, startC2 + 1])
                {
                    countSameStringDiag2++;
                    if (totalCountDiag2 < countSameStringDiag2)
                    {
                        totalCountDiag2 = countSameStringDiag2;
                        sameStringDiag2 = matrix[startR2, startC2];
                    }
                }
                startR2++;
                startC2++;
            }
            elements2--;
            startR2 = 0;
            countSameStringDiag2 = 1;
        }

        int result;
        string resultStr = "";
        if (totalCountDiag2 > totalCountDiag)
        {
            result = totalCountDiag2;
            resultStr = sameStringDiag2;
        }
        else
        {
            result = totalCountDiag;
            resultStr = sameStringDiag;
        }

        var tuple2 = Tuple.Create(result, resultStr);
        return tuple2;
    }
}

