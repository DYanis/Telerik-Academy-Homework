// Write a program to check if in a given expression the brackets are put correctly.

using System;
using System.Linq;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            Console.WriteLine("Enter expresion");
            string expresion = Console.ReadLine();
            int countFirstBrackets = 0;
            int countSecondBrackets = 0;

            if (expresion[0] == ')' || expresion[expresion.Length - 1] == '(')
            {
                Console.WriteLine(false);
                return;
            }

            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i] == '(') countFirstBrackets++;
                if (expresion[i] == ')') countSecondBrackets++;

                if (expresion[i] == '(' && expresion[i + 1] == ')')
                {
                    Console.WriteLine(false);
                    return;
                }

                if (countSecondBrackets > countFirstBrackets)
                {
                    Console.WriteLine(false);
                    return;
                }
            }

            if (countFirstBrackets != countSecondBrackets)
            {
                Console.WriteLine(false);
                return;
            }
        }
    }
}
