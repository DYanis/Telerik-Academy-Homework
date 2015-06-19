// Write a program to convert binary numbers to their decimal representation.

using System;
using System.Linq;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number");
            string binaryNumber = Console.ReadLine();
            double decimalNumber = 0;
            
            for (int i = 0; i < binaryNumber.Length ; i++)
            {
                int pow = (binaryNumber.Length - 1) - i;
                if (binaryNumber[i] == '1')
                {
                    decimalNumber += (binaryNumber[i] - '0') * Math.Pow(2, pow);
                }
            }
            Console.WriteLine(decimalNumber);

        }
    }
}
