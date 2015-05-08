// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;
using System.Linq;
using System.Collections.Generic;

class IntegerCalculations
{
    static void Main()
    {
        List<int> theList = new List<int>();
        theList.Add(42);
        theList.Add(63);
        theList.Add(75);
        Calculate(theList);
    }

    static void Calculate(List<int> theList)
    {
        int min = theList.Min();
        int max = theList.Max();
        int sum = 0;
        int product = 1;
        for (int i = 0; i < theList.Count; i++)
        {
            sum += theList[i];
            product *= theList[i];
        }
        int average = sum / theList.Count;

        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("product = " + product);
        Console.WriteLine("average = " + average);
    }
}

