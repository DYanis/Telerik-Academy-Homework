//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
       

        Random rnd = new Random();
        for (int ctr = 0; ctr < n; ctr++)
        {
            Console.WriteLine(rnd.Next(0, n+1));
        }
    }
}






