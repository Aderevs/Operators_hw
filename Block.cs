using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_hw
{
    internal class Block
    {
        public Block(uint sideA, uint sideB, uint sideC, uint sideD) 
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.SideD = sideD;
        }
        public uint SideA { get; set; }
        public uint SideB { get; set; }
        public uint SideC { get; set; }
        public uint SideD { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == this)
            {
                return true;
            }
            if (obj is Block)
            {
                return SideA == ((Block)obj).SideA &&
                    SideB == ((Block)obj).SideB &&
                    SideC == ((Block)obj).SideC &&
                    SideD == ((Block)obj).SideD;
            }
            return false;
        }
        public override string ToString()
        {
            string description = "SideA = " + SideA + "\nSideC = " + SideB + "\nSideC = " + SideC + "\nSideD = " + SideD + "\n";
            return description;
        }
    }
}
