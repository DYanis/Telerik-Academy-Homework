// Write an expression that checks for given point (x, y) if it is within 
// the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            bool insideK = (x - 1 * x - 1) + (y - 1 * y - 1) <= (1.5 * 1.5);
            bool outsideR = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

            if (insideK == true && outsideR == false)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

