// We are given an array of integers and a number S.
// Write a program to find if there exists a subset of the elements of the array that has a sum S.

using System;
using System.Linq;

    class SubsetWithSumS
    {
        static void Main()
        {
            Console.WriteLine("Please enter leng of the array");
            int arrayLenght = int.Parse(Console.ReadLine());

            int[] arr = new int[arrayLenght];

            for (int i = 0; i < arrayLenght; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter S");
            int s = int.Parse(Console.ReadLine());
            
            int sum = 0;

            for (int i = 0; i < arrayLenght; i++)
            {
                sum = arr[i];
                for (int j = 0; j < arrayLenght; j++)
                {
                    if (j == i) continue;
                    if (sum + arr[j]== s)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                    for (int k = 0; k < arrayLenght; k++)
                    {
                        
                    }
                }                             
                sum = 0;
            }
        }
    }

