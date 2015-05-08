namespace StartMain
{
    using System;
    using System.Linq;

    class StartMain
    {
        static void Main()
        {
          //  Console.WriteLine(Point3D.PointO);
          //  Console.WriteLine(CalculateDistanceBetweenTwoPoints.CalculateDistance(new Point3D(0, 0, 0), new Point3D(128, 13000, 2)));

            GenericList<int> crazy = new GenericList<int>(4);
            crazy.Add(0);
            crazy.Add(1);
            crazy.Add(8);
            crazy.Add(3);

            crazy.Insert(3, 55);
            Console.WriteLine(crazy);    
        }
    }
}
