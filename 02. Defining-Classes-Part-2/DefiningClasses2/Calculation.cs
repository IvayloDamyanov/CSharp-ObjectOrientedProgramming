using System;

namespace DefiningClasses2
{
    static class Calculation
    {
        public static double PointsDistance(Point3D first, Point3D second)
        {
            double output = 0;
            double x1 = first.X;
            double y1 = first.Y;
            double z1 = first.Z;
            double x2 = second.X;
            double y2 = second.Y;
            double z2 = second.Z;
            output = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return output;
        }
    }
}
