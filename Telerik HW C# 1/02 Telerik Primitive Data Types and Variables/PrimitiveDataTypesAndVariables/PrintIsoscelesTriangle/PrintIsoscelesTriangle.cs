//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

using System;

class PrintIsoscelesTriangle
{
    static void Main()

    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char x = '\u00A9';
        Console.WriteLine("   " + x + "\n" + "\n" + "  " + x + " " + x + "\n" + "\n" + " " + x + "   " + x + "\n" + "\n" + 
            x + " " + x + " " + x + " " + x);
    }
}

