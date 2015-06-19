//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double result = firstNumber - secondNumber;


        if (result < 0.0)
        {
            if (result < (-eps))
            { 
                Console.WriteLine("False");
            }
            if (result > (-eps))
            {
                Console.WriteLine("True");
            } 
        }

       
        if (result > 0.0)
        {
            if (result > eps)
            {
                Console.WriteLine("False");               
            }
            if (result < eps)
            {
                Console.WriteLine("True");
            }            
        }
    }
}

