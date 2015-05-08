namespace StartMain
{
    using System;
    using System.Linq;

    static class CalculateDistanceBetweenTwoPoints
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double deltaX = secondPoint.x - firstPoint.x;
            double deltaY = secondPoint.y - firstPoint.y;
            double deltaZ = secondPoint.z - firstPoint.z;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance;
        }
    }
}
