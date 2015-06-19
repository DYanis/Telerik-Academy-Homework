// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Linq;

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y = ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("z = ");
        int z = int.Parse(Console.ReadLine());
        int biggerNumber = GetMax(x, y);
        
        biggerNumber = GetMax(biggerNumber, z);
        Console.Write("result = ");
        Console.WriteLine(biggerNumber);
    }

    static int GetMax(int number1,int number2)
    {
        if (number1 < number2)
        {
            number1 = number2;
        }
        return number1;
    }
}

