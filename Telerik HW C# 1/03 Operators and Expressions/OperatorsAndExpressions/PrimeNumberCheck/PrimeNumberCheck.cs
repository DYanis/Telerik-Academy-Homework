// Write an expression that checks if given positive integer number n (n <= 100)
// is prime (i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer number n between 2 and 100");
        int numberN = int.Parse(Console.ReadLine());
        
        while (numberN < 2 || numberN > 100)
        {
            Console.WriteLine("Try again");
            numberN = int.Parse(Console.ReadLine());
        }
        
        bool isPrime = true;
        int counter = 1;

        while (counter <= Math.Sqrt(numberN))
        {
            if (numberN % counter == 0 && counter > 1)
            {
                isPrime = false;
            }
            counter++;
        }
        Console.WriteLine("Is your number prime?\n{0}", isPrime);
    }
}
