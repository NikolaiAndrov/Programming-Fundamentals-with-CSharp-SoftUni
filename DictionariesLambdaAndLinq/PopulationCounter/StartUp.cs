using System;
using System.Linq;
using System.Collections.Generic;
public class StartUp
{
    public static void Main()
    {
        var placeAndPopulation = new Dictionary<string, Dictionary<string, long>>();
        GetPlaceAndPopulation(placeAndPopulation);
        PrintPlaceAndPopulation(placeAndPopulation);
    }

    static void PrintPlaceAndPopulation(Dictionary<string, Dictionary<string, long>> placeAndPopulation)
    {
        foreach (var country in placeAndPopulation.OrderByDescending(x => x.Value.Values.Sum()))
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

            foreach (var city in country.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
    static void GetPlaceAndPopulation(Dictionary<string, Dictionary<string, long>> placeAndPopulation)
    {
        string input;

        while ((input = Console.ReadLine()) != "report")
        {
            var populationInfo = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
            var city = populationInfo[0];
            var country = populationInfo[1];
            var population = int.Parse(populationInfo[2]);

            if (!placeAndPopulation.ContainsKey(country))
            {
                placeAndPopulation[country] = new Dictionary<string, long>();
            }

            if (!placeAndPopulation[country].ContainsKey(city))
            {
                placeAndPopulation[country][city] = 0;
            }

            placeAndPopulation[country][city] = population;
        }
    }
}
