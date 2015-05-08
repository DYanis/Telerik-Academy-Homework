// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        int counter = 0;
        double sumOfNumbers = 0;
        Console.Write("Please enter n: ");
        double n = double.Parse(Console.ReadLine());
        
        while (n > counter)
        {
            Console.Write("Please enters more numbers: ");
            double moreNumbers = double.Parse(Console.ReadLine());
            sumOfNumbers += moreNumbers;
            counter++;
        }
        Console.WriteLine(sumOfNumbers);
    }
}

