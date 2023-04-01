using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    internal class Trivago
    {
        Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
        "Hyderabad",
        new Dictionary<string,double>
        {
            {"Park Hyatt",12000},
            {"Courtyard By Marriott",10000},
            {"Taj Krishna",14500}
        }
        },

        {
        "Mysore",
        new Dictionary<string,double>
        {
            {"Hotel Royal Orchid",20000},
            {"Hotel Kings Kourt",18000}
        }
        }
    };

        public bool CheckCity(string place)
        {
            foreach (string city in HotelList.Keys)
            {
                if (place.Equals(city))
                    return true;
                else
                    return false; 
            }

            return false;
        }

        public void CityList()
        {
            Console.WriteLine("Available Cities:");
            foreach(string citis in HotelList.Keys)
            {
                Console.WriteLine(citis);
            }
        }

        public void ShowTariff(string city)
        {
            Console.WriteLine("Hotel list with Tariff:");
            foreach(KeyValuePair<string, double > hotels in HotelList[city])
            {
                Console.WriteLine($"{hotels.Key} - Rs.{hotels.Value}");
            }
        }
    }
}
