using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_hw
{
    internal struct Point3d
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Point3d()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Point3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Point3d operator +(Point3d point1, Point3d point2)
        {
            return new Point3d(point1.X + point2.X, point1.Y + point2.Y, point1.Z + point2.Z);
        }
        public override string ToString()
        {
            return $"(X: {X}, Y: {Y},Z: {Z})";
        }
    }
}
