// Write a program that can solve these tasks:
//     Reverses the digits of a number
//     Calculates the average of a sequence of integers
//     Solves a linear equation a * x + b = 0
// Create appropriate methods.
// Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data:
//     The decimal number should be non-negative
//     The sequence should not be empty
//     a should not be equal to 0

using System;
using System.Linq;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine(
@"Choose one of those
Press 1 for Reverses the digits of a number :
Press 2 for Calculates the average of a sequence of integers : ");

        int type = int.Parse(Console.ReadLine());
        
        if (type == 1)
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber.RevertNumber(number));
        }

        if (type == 2)
        {
            Console.WriteLine("Enter number");
            string number = Console.ReadLine();
            double result  = (AverageOfASequenceOfIntegers.Average(number));
            Console.WriteLine(result);            
        }
    }
}