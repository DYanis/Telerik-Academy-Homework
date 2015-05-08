namespace StartMain
{
    using System;
    using System.Linq;

    public struct Point3D
    {
        public double x;

        public double y;

        public double z;

        private static readonly Point3D pointO = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D PointO
        {
            get
            {
                return pointO ;
            }
            private set { }
        }

        public override string ToString()
        {
            return "x - " + x + "\n" + "y - " + y + "\n" + "z - " + z;
        }
    }
}
