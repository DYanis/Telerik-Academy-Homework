//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even //elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
using System.Collections.Generic;

class OddAndEvenProduct
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int counter = 1;
        int oddProduct = 1;
        int evenProduck = 1;

        foreach (var item in numbers)
        {
            if (counter % 2 != 0)
            {
                oddProduct *= (int)Convert.ToInt32(item);

            }
            else
                evenProduck *= (int)Convert.ToInt32(item);

            counter++;
        }
        if (evenProduck == oddProduct)
        {
            Console.WriteLine("YES ! ");
        }
        else
            Console.WriteLine("NO ! ");
    }
}




