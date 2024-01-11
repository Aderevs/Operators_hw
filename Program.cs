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
            Date gfBirthday = new Date(28, 9, 2004);
            Date myBirthday = new Date(18, 11, 2005);
            Console.WriteLine("age difference: " + (myBirthday - gfBirthday));
        }
    }
}
