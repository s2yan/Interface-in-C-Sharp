using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Select your choice...\n1.Make My Trip\n2.Trivago\n3.Clear Trip");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var m = new MakeMyTrip();
                    m.CityList();
                    Console.WriteLine("Enter a city to view hotels:");
                    var newCity = Console.ReadLine();
                    if (m.CheckCity(newCity))
                    {
                        m.ShowTariff(newCity);
                    }
                    else
                    {
                        Console.WriteLine("Selected city not found...");
                    }
                    break;

                case 2:
                    var t = new Trivago();
                    t.CityList();
                    Console.WriteLine("Enter a city to view hotels:");
                    var tCity = Console.ReadLine();
                    if (t.CheckCity(tCity))
                    {
                        t.ShowTariff(tCity);
                    }
                    else { Console.WriteLine("Selected city not found..."); }

                    break;

                case 3:
                    var ct = new ClearTrip();
                    ct.CityList();
                    Console.WriteLine("Enter a city to view hotels:");
                    var ctCity = Console.ReadLine();
                    if (ct.CheckCity(ctCity))
                    {
                        ct.ShowTariff(ctCity);
                    }
                    else { Console.WriteLine("Selected city not found..."); }

                    break;

          
            }
        }
    }
}
