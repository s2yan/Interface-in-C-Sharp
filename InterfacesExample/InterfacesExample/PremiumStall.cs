using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    internal class PremiumStall : IStall
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public double Cost { get; set; }
        public string OwnerName { get; set; }
        public int NumberOfProjector { get; set; }

        public PremiumStall(string _name, string _details, double _cost, string _ownerName, int _numberOfProjector)
        {
            Name = _name;
            Details = _details;
            Cost = _cost;
            OwnerName = _ownerName;
            NumberOfProjector = _numberOfProjector;

        }

        public void display()
        {
            Console.WriteLine("Stall Name:{0}\nDetails:{1}\nCost:{2}\nOwner:{3}\nNumber of projector:{4}", Name, Details, Cost, OwnerName, NumberOfProjector);
        }
    }
}
