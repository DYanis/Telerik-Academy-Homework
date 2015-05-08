//Which of the following values can be assigned to a variable of type float and which to a variable 
//of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        float shortNumber = 12.345F;
        float shortFloatNumber = 3456.091F;
        double longNumber = 34.567839023;
        double longDoubleNumber = 8923.1234857;

        Console.WriteLine(shortNumber);
        Console.WriteLine(shortFloatNumber);
        Console.WriteLine(longNumber);
        Console.WriteLine(longDoubleNumber);
    }
}

