// 4. Rectangles
// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = (width + height) * 2;
        double area = width * height;

        Console.WriteLine("perimeter = {0} \narea = {1}", perimeter, area);
    }
}

