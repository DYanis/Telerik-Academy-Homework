using System;
using System.Linq;

class AverageOfASequenceOfIntegers
{
    public double Average(string number)
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

