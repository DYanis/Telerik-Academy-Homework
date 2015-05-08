//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNull = null;
        double? doubleNull = null;    
        Console.WriteLine(intNull);
        Console.WriteLine(doubleNull);

        intNull = 15;
        doubleNull = 0;
        Console.WriteLine(intNull);
        Console.WriteLine(doubleNull); 
    }
}
