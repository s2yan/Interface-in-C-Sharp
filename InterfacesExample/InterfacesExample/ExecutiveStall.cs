using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    internal class ExecutiveStall : IStall
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public double Cost { get; set; }
        public string OwnerName { get; set; }
        public int NumberOfTVSet { get; set; }

        public ExecutiveStall(string _name, string _details, double _cost, string _ownerName, int _numberOfTVSet)
        {
            Name = _name;
            Details = _details;
            Cost = _cost;
            OwnerName = _ownerName;
            NumberOfTVSet = _numberOfTVSet;

        }

        public void display()
        {
            Console.WriteLine("Stall Name:{0}\nDetail:{1}\nCost:{2}\nOwner:{3}\nNumber of TV:{4}", Name, Details, Cost, OwnerName, NumberOfTVSet);
        }
    }
}
