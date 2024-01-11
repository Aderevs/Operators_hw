using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3d a = new Point3d(1, 2, 3);
            Point3d b = new Point3d(3, 2, 1);
            Console.WriteLine($"point a: {a}");
            Console.WriteLine($"point b: {b}");
            Console.WriteLine($"point a+b: {a + b}");
        }
    }
}
