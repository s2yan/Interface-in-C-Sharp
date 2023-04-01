using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace InterfacesExample
{
    internal class GoldStall : IStall
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public double Cost { get; set; }
        public string OwnerName { get; set; }

       
        public GoldStall(string _name, string _details, double _cost, string _ownerName)
        {
            Name = _name;
            Details = _details;
            Cost = _cost;
            OwnerName = _ownerName;

        }

        public void display()
        {
            Console.WriteLine("Stall name:{0}\nDetails:{1}\nCost:{2}\nOwner:{3}", Name, Details, Cost, OwnerName);
        }
    }
}
