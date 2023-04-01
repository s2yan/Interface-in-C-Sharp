using System;
using System.Collections.Generic;

class MakeMyTrip
{
    Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
            "Tokyo",
            new Dictionary<string, double>
            {
                {"Tokyo Residency", 10000},
                {"Heritage Tokyo", 15000},
                {"Germanus", 20000}
            }
        },
        {
            "Singapore",
            new Dictionary<string, double>
            {
                {"Hotel CAG Pride", 15000},
                {"Heritage Inn", 25000}
            }
        }
    };

    public bool CheckCity(string place)
    {
        foreach(string city in HotelList.Keys)
        {
            if (place.ToLower().Equals(city.ToLower())){

                return true;
            }
        }
        return false;
    }

    public void CityList()
    {
        Console.WriteLine("Available Cities:");
        foreach (string city in HotelList.Keys)
            Console.WriteLine(city);
    }

    public void ShowTariff(string city)
    {
        Console.WriteLine($"Hotel List with Tariff:");
        foreach (KeyValuePair<string, double> hotel in HotelList[city])
            Console.WriteLine($"{hotel.Key} - Rs.{hotel.Value}");
    }
}
