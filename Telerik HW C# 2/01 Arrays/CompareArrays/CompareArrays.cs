// Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please add max elements in First array");
        int maxElementsFirst = int.Parse(Console.ReadLine());
        int[] firstArray = new int[maxElementsFirst];
           
        for (int i = 0; i < maxElementsFirst; i++)
        {
            int number = int.Parse(Console.ReadLine());
            firstArray[i] = number;
        }

        Console.WriteLine("Please add max elements in Second array");
        int maxElementsSecond = int.Parse(Console.ReadLine());
        int[] secondArray = new int[maxElementsSecond];

     
        for (int i = 0; i < maxElementsSecond; i++)
        {
            int number = int.Parse(Console.ReadLine());
            secondArray[i] = number;
        }

        
        bool result = true;
        if (maxElementsFirst != maxElementsSecond)
        {
            result = false;
        }
        
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                result = false;
            }
        }
        Console.WriteLine(result);
    }
}

