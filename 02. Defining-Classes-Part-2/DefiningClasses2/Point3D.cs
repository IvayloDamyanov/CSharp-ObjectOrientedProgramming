using System;

namespace DefiningClasses2
{
    struct Point3D
    {
        public readonly double X;
        public readonly double Y;
        public readonly double Z;

        public Point3D(double x, double y, double z)
            {
            this.X = x;
            this.Y = y;
            this.Z = z;
            }

        public override string ToString()
        {
            string output;
            output = String.Format("{0},{1},{2}", X, Y, Z);
            return output;
        }

        private static readonly Point3D StartPoint = new Point3D(0, 0 ,0);
        public static Point3D StartPointValue
        {
            get
            {
                return StartPoint;
            }
            set
            {
                StartPointValue = StartPoint;
            }
        }
    }
}
