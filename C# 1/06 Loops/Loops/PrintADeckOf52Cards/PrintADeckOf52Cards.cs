//Write a program that generates and prBigIntegers all possible cards from a standard deck of 52 cards (without the jokers). The cards should be prBigIntegered using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//PrBigInteger each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class PrBigIntegerADeckOf52Cards
{
    static void Main()
    {

        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 1; j++) // if
            {
                switch (i)
                {
                    case 0: Console.Write("2♣");
                        Console.Write("2♠");
                        Console.Write("2♥");
                        Console.Write("2♦");
                        Console.WriteLine("\n");
                        break;

                    case 1: Console.Write("3♣");
                        Console.Write("3♠");
                        Console.Write("3♥");
                        Console.Write("3♦");
                        Console.WriteLine("\n");
                        break;

                    case 2: Console.Write("4♣");
                        Console.Write("4♠");
                        Console.Write("4♥");
                        Console.Write("4♦");
                        Console.WriteLine("\n");
                        break;

                    case 3: Console.Write("5♣");
                        Console.Write("5♠");
                        Console.Write("5♥");
                        Console.Write("5♦");
                        Console.WriteLine("\n");
                        break;

                    case 4: Console.Write("6♣");
                        Console.Write("6♠");
                        Console.Write("6♥");
                        Console.Write("6♦");
                        Console.WriteLine("\n");
                        break;

                    case 5: Console.Write("7♣");
                        Console.Write("7♠");
                        Console.Write("7♥");
                        Console.Write("7♦");
                        Console.WriteLine("\n");
                        break;

                    case 6: Console.Write("8♣");
                        Console.Write("8♠");
                        Console.Write("8♥");
                        Console.Write("8♦");
                        Console.WriteLine("\n");
                        break;

                    case 7: Console.Write("9♣");
                        Console.Write("9♠");
                        Console.Write("9♥");
                        Console.Write("9♦");
                        Console.WriteLine("\n");
                        break;

                    case 8: Console.Write("10♣");
                        Console.Write("10♠");
                        Console.Write("10♥");
                        Console.Write("10♦");
                        Console.WriteLine("\n");
                        break;

                    case 9: Console.Write("J♣");
                        Console.Write("J♠");
                        Console.Write("J♥");
                        Console.Write("J♦");
                        Console.WriteLine("\n");
                        break;

                    case 10: Console.Write("Q♣");
                        Console.Write("Q♠");
                        Console.Write("Q♥");
                        Console.Write("Q♦");
                        Console.WriteLine("\n");
                        break;

                    case 11: Console.Write("K♣");
                        Console.Write("K♠");
                        Console.Write("K♥");
                        Console.Write("K♦");
                        Console.WriteLine("\n");
                        break;

                    case 12: Console.Write("A♣");
                        Console.Write("A♠");
                        Console.Write("A♥");
                        Console.Write("A♦");
                        Console.WriteLine("\n");
                        break;   
                }
            }
        }
    }
}

