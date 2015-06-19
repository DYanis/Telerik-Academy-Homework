// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
// 
//     If the score is between 1 and 3, the program multiplies it by 10.
//     If the score is between 4 and 6, the program multiplies it by 100.
//     If the score is between 7 and 9, the program multiplies it by 1000.
//     If the score is 0 or more than 9, the program prints “invalid score”.

using System;

class BonusScore
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        if (input >= 1 && input <= 3)
        {
            Console.WriteLine(input * 10);
        }
        else if (input >= 4 && input <= 6)
        {
            Console.WriteLine(input * 100);
        }
        else if (input >= 7 && input <= 9)
        {
            Console.WriteLine(input * 1000);
        }
        else
            Console.WriteLine("invalid score");
    }
}

