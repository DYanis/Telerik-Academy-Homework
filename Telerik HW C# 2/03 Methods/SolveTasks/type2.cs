using System;
using System.Linq;

public static class AverageOfASequenceOfIntegers
{
    public static double Average(string number)
    {
        double sum = 0;
        foreach (var item in number)
        {
            sum += item-'0';
        }
        double result = sum / number.Length;
        return result;
    }
}

