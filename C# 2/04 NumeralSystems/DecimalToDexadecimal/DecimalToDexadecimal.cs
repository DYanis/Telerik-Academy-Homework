// Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Linq;

namespace DecimalToDexadecimal
{
    class DecimalToDexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter decimal number");
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexDecimalNumber = "";

            while (true)
            {
                if (decimalNumber == 0)
                {
                    break;
                }
                
                string remainderStr = Convert.ToString(decimalNumber % 16);
                decimalNumber = decimalNumber / 16;
                
                switch (remainderStr)
                {
                    case "10": remainderStr = "A"; break;
                    case "11": remainderStr = "B"; break;
                    case "12": remainderStr = "C"; break;
                    case "13": remainderStr = "D"; break;
                    case "14": remainderStr = "E"; break;
                    case "15": remainderStr = "F"; break;
                }
                hexDecimalNumber = remainderStr + hexDecimalNumber;
            }
            Console.WriteLine(hexDecimalNumber);
        }
    }
}
