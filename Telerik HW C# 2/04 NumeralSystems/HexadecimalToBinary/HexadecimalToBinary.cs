// Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Linq;

namespace HexadecimalToBinary
{
    class HexadecimalToBinarys
    {
        static void Main()
        {
            Console.WriteLine("Enter hexadecimal number");
            string hexadecimalNumber = Console.ReadLine();
            string binaryNuber = "";

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                string digit = Convert.ToString(hexadecimalNumber[i]);

                switch (digit)
                {
                    case "1": binaryNuber = binaryNuber + "0001"; break;
                    case "2": binaryNuber = binaryNuber + "0010"; break;
                    case "3": binaryNuber = binaryNuber + "0011"; break;
                    case "4": binaryNuber = binaryNuber + "0100"; break;
                    case "5": binaryNuber = binaryNuber + "0101"; break;
                    case "6": binaryNuber = binaryNuber + "0110"; break;
                    case "7": binaryNuber = binaryNuber + "0111"; break;
                    case "8": binaryNuber = binaryNuber + "1000"; break;
                    case "9": binaryNuber = binaryNuber + "1001"; break;
                    case "A": binaryNuber = binaryNuber + "1010"; break;
                    case "B": binaryNuber = binaryNuber + "1011"; break;
                    case "C": binaryNuber = binaryNuber + "1100"; break;
                    case "D": binaryNuber = binaryNuber + "1101"; break;
                    case "E": binaryNuber = binaryNuber + "1110"; break;
                    case "F": binaryNuber = binaryNuber + "1111"; break;
                }
            }
            Console.WriteLine(binaryNuber);
        }
    }
}
