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
            Block block = new Block(1, 2, 3, 4);
            Block otherBlock = new Block(1, 2, 3, 3);
            Console.WriteLine(block);
            if(block.Equals(otherBlock))
            {
                Console.WriteLine(otherBlock);
            }
        }
    }
}
