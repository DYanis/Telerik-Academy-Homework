// 3. Divide by 7 and 5
// Write a Boolean expression that checks for given integer if it can be divided
// (without remainder)by 7 and 5 at the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        if (number != 0)
        {
            if (number % 5 == 0)
            {
                if (number % 7 == 0)
                {
                    Console.WriteLine(number + " Divided by 7 and 5? = " + true);
                }
                else
                    Console.WriteLine(number + " Divided by 7 and 5? = " + false);
            }
            else
                Console.WriteLine(number + " Divided by 7 and 5? = " + false);
        }
        else
            Console.WriteLine(number + " Divided by 7 and 5? = " + false);
    }

}

