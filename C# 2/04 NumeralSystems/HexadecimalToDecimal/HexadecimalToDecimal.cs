// Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Linq;

namespace HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Enter hexadecimal number");
            string hexaDecimalNumber = Console.ReadLine();
            double sum = 0;

            for (int i = 0; i < hexaDecimalNumber.Length; i++)
            {
                double pow = (hexaDecimalNumber.Length - 1) - i;
                string digit = Convert.ToString(hexaDecimalNumber[i]);
                switch (digit)
                {
                    case "A": digit = "10"; break;
                    case "B": digit = "11"; break;
                    case "C": digit = "12"; break;
                    case "D": digit = "13"; break;
                    case "E": digit = "14"; break;
                    case "F": digit = "15"; break;
                }
                sum += int.Parse(digit) * Math.Pow(16,pow);
            }
            Console.WriteLine(sum);
        }
    }
}
