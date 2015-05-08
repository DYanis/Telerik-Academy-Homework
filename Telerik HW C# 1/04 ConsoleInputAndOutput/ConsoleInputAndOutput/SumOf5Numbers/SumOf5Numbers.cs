//  Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum

using System;

class Program
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        double sum = 0;
        
        string[] items = numbers.Split(' ');
        foreach (string word in items)
        {
            sum += double.Parse(word);
        }
        Console.WriteLine(sum);
  
    }   
}


