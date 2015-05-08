// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Linq;

namespace BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter binary number");
            string binaryNumber = Console.ReadLine();
            string hexadecimalNumber = "";

            for (int i = 0; i < binaryNumber.Length; i+=4)
            {
                var fourDigits = Convert.ToString(binaryNumber[i]) + Convert.ToString(binaryNumber[i+1]) + Convert.ToString(binaryNumber[i+2]) + Convert.ToString(binaryNumber[i+3]);

                switch (fourDigits)
                {
                    case "0000": hexadecimalNumber = hexadecimalNumber + "0"; break;
                    case "0001": hexadecimalNumber = hexadecimalNumber + "1"; break;
                    case "0010": hexadecimalNumber = hexadecimalNumber + "2"; break;
                    case "0011": hexadecimalNumber = hexadecimalNumber + "3"; break;
                    case "0100": hexadecimalNumber = hexadecimalNumber + "4"; break;
                    case "0101": hexadecimalNumber = hexadecimalNumber + "5"; break;
                    case "0110": hexadecimalNumber = hexadecimalNumber + "6"; break;
                    case "0111": hexadecimalNumber = hexadecimalNumber + "7"; break;
                    case "1000": hexadecimalNumber = hexadecimalNumber + "8"; break;
                    case "1001": hexadecimalNumber = hexadecimalNumber + "9"; break;
                    case "1010": hexadecimalNumber = hexadecimalNumber + "A"; break;
                    case "1011": hexadecimalNumber = hexadecimalNumber + "B"; break;
                    case "1100": hexadecimalNumber = hexadecimalNumber + "C"; break;
                    case "1101": hexadecimalNumber = hexadecimalNumber + "D"; break;
                    case "1110": hexadecimalNumber = hexadecimalNumber + "E"; break;
                    case "1111": hexadecimalNumber = hexadecimalNumber + "F"; break;
                }           
            }
            Console.WriteLine(hexadecimalNumber);
        }
    }
}
