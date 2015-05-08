// 11.Write a method that adds two polynomials.
// Represent them as arrays of their coefficients as in the example below:
// x2 + 5 = 1x2 + 0x + 5  5 0 1
// 12.Extend the program to support also subtraction and multiplication of polynomials.

using System;
class SumSubstrAndMultiPlicationOfPolinomials
{
    static decimal[] SumOfPolinomials(decimal[] firstArray, decimal[] secondArray)
    {
        int longArray = firstArray.Length;
        int shortArray = secondArray.Length;
        if (firstArray.Length < secondArray.Length)
        {
            longArray = secondArray.Length;
            shortArray = firstArray.Length;
        }
        decimal[] result = new decimal[longArray];
        for (int i = 0; i < shortArray; i++)
        {
            result[i] = (firstArray[i] + secondArray[i]);
        }
        for (int i = shortArray; i < longArray; i++)
        {
            result[i] = (firstArray.Length > secondArray.Length ? firstArray[i] : secondArray[i]);
        }
        return result;
    }
    static decimal[] SubstractOfPolinomials(decimal[] firsArray, decimal[] secondArray)
    {
        int longArray = firsArray.Length;
        int shortArray = secondArray.Length;
        if (secondArray.Length > firsArray.Length)
        {
            longArray = secondArray.Length;
            shortArray = firsArray.Length;
        }
        decimal[] result = new decimal[longArray];
        for (int i = 0; i < longArray; i++)
        {
            if (i > shortArray - 1)
            {
                result[i] = firsArray.Length > secondArray.Length ? firsArray[i] : secondArray[i];
            }
            else
            {
                result[i] = firsArray[i] - secondArray[i];
            }
        }
        return result;
    }
    static decimal[] MultiplyPolinomials(decimal[] firstArray, decimal[] secondArray)
    {
        decimal[] result = new decimal[firstArray.Length + secondArray.Length - 1];
        for (int i = 0; i < firstArray.Length; i++)
        {
            for (int j = 0; j < secondArray.Length; j++)
            {
                result[i + j] += firstArray[i] * secondArray[j];
            }
        }
        return result;
    }
    static void PrintP(decimal[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    static void Main()
    {
        decimal[] firstArray = { 9, 5, 9, 9, 5 };
        decimal[] secondArray = { 9, 9, 9, 4 };
        Console.WriteLine("This is a test with 9x^4+5x^3+9x^2+9x+5 and 9x^3+9x^2+9x+4 !");
        Console.WriteLine("Sum of Polinomials");
        PrintP(SumOfPolinomials(firstArray, secondArray));
        Console.WriteLine("Substraction of Polinomials");
        PrintP(SubstractOfPolinomials(firstArray, secondArray));
        Console.WriteLine("Multiplication of Polinomials");
        PrintP(MultiplyPolinomials(firstArray, secondArray));
    }
}