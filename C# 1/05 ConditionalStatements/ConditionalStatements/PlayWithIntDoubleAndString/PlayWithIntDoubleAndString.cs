// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//     If the variable is int or double, the program increases it by one.
//     If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n1 --> int \n2 --> double \n3 --> string");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1: Console.Write("Please enter a int:");
                int inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine(inputInt + 1); break;

            case 2: Console.Write("Please enter a double:");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputDouble + 1); break;

            case 3: Console.Write("Please enter a string:");
                string inputStringe = Console.ReadLine();
                Console.WriteLine(inputStringe + "*"); break;
        }
    }
}

