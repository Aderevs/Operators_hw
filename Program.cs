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
            string[] houses = { "Skalda 5", "qwerty" };
            House mainHouse = new House(1, houses);
            House shallowClone = mainHouse.Clone();
            House deepClone = mainHouse.DeepClone();
            mainHouse.ShallowCloneCheck(shallowClone);
            mainHouse.DeepCloneCheck(deepClone);
        }
    }
}
