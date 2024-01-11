using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_hw
{
    internal class House
    {
        private uint numberOfFloors;
        private List<string> neighborsAdresses;
        public House()
        {
            numberOfFloors = 1;
            neighborsAdresses = new List<string>();
        }
        public House(uint numberOfFloors, string[] neighbors)
        {
            this.numberOfFloors = numberOfFloors;
            this.neighborsAdresses = new List<string>(neighbors);
        }

        public uint HouseNumber { get; set; }
        public string Street { get; set; }



        public House Clone()
        {

            return (House)this.MemberwiseClone();
        }
        public House DeepClone()
        {
            House newHouse = new House();
            newHouse.HouseNumber = HouseNumber;
            newHouse.Street = Street;
            newHouse.numberOfFloors = numberOfFloors;
            newHouse.neighborsAdresses = new List<string>(neighborsAdresses.Select(adress => adress));
            return newHouse;
        }
        public void ShallowCloneCheck(House otherHouse)
        {
            if(!ReferenceEquals(otherHouse, this))
            {
                Console.WriteLine("shallow clone works correct");
            }
            else
            {
                Console.WriteLine("rror in the work of a shallow clone");
            }
        }

        public void DeepCloneCheck(House otherHouse)
        {
            //check only the neighborsAdresses field, since the rest is a value type or a string (immutable)
            if (!ReferenceEquals(otherHouse, this))
            {
                if(!ReferenceEquals(otherHouse.neighborsAdresses, this.neighborsAdresses))
                {
                    Console.WriteLine("deep clone works correct");
                    return;
                }
            }
             Console.WriteLine("rror in the work of a shallow clone");
        }
    }
}

