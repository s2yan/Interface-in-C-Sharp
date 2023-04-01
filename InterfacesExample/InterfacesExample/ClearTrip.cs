using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    internal class ClearTrip
    {
        Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
        "Chennai",
        new Dictionary<string,double>
        {
            {"Leela Palace",25000},
            {"Hilton",20000},
            {"WoodLands",18000}
        }
        },

        {
        "Bangalore",
        new Dictionary<string,double>
        {
            {"Adarsh Hamilton",12000},
            {"Wonderla Resort",15000},
            {"Olde Bangalore Resort",20000}
        }
        }
    };

        public bool CheckCity(string place)
        {
            foreach (string city in HotelList.Keys)
            {
                if (place.Equals(city))
                    return true;
            }
            return false;
        }


        public void CityList()
        {
            Console.WriteLine("Avvailable cities:");
            foreach(string city in HotelList.Keys)
            {
                Console.WriteLine(city);
            }
        }

        public void ShowTariff(string city)
        {
            Console.WriteLine("Hotel List with tariff:");
            foreach(KeyValuePair<string, double> hotel in HotelList[city])
            {
                Console.WriteLine($"{hotel.Key}-{hotel.Value}");
            }

        }
    }
}
