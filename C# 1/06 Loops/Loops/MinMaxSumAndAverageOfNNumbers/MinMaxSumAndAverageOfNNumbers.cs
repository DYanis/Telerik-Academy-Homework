//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the // aximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        double nNumbers = double.Parse(Console.ReadLine());
        double minNumber = 0;
        double maxNumber = 0;
        double sum = 0;
        double avg = 0;


        for (int i = 0; i < nNumbers; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;


            if (i == 0)
            {
                minNumber = number;
                maxNumber = number;
                continue;
            }

            if (number < minNumber)
            {
                minNumber = number;
                continue;
            }

            if (number > maxNumber)
            {
                maxNumber = number;
                continue;
            }

        }
        avg = sum / nNumbers;

        Console.WriteLine("min = {0}", minNumber);
        Console.WriteLine("max = {0}", maxNumber);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:0.00}", avg);






















    }
}

