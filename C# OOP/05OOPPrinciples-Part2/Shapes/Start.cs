using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Start
    {
        static void Main()
        {
            var triangle = new Triangle(5, 2);
            var result = triangle.CalculateSurface();
            Console.WriteLine("Triangle surface = " + result);
            var rectangle = new Rectangle(5.4, 3);
            Console.WriteLine("Rectangle surface = " + rectangle.CalculateSurface());
            var square = new Square(5);
            Console.WriteLine("Square surface = " + square.CalculateSurface());

            Shape[] testShapes = {
                    new Triangle(5, 2),
                    new Rectangle(5.4, 3),
                    new Square(5)
                                 };

            foreach (var item in testShapes)
            {
                Console.WriteLine(item.GetType() + " = " + item.CalculateSurface());
            }
        }
    }
}
