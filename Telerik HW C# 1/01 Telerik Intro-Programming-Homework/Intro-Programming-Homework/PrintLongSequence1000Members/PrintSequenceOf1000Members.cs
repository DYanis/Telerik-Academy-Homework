//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).

using System;

class PrintLongSequence1000Members
{
    static void Main()
    {
        int count = 0;
        int even = 0;
        int odd = -1;


        while (true)
        {
            if (count % 2 == 0)
            {
                even += 2;
                Console.WriteLine(even);
            }

            if (count % 2 != 0)
            {
                odd -= 2;
                Console.WriteLine(odd);
            }

            if (even == 1000)
            {
                break;
            }

            count++;
        }

    }
}
