// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.

using System;
using System.Linq;

class SayHello
{
    static void Main()
    {
        PrintName();
    }

    static void PrintName()
    {
        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}",name);
      
    }
}

