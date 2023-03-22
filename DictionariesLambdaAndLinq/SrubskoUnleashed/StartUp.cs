using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        var conserts = new Dictionary<string, Dictionary<string, long>>();
        GetConcerts(conserts);
        PrintConcerts(conserts);
    }

    static void PrintConcerts(Dictionary<string, Dictionary<string, long>> conserts)
    {
        foreach (var place in conserts)
        {
            Console.WriteLine(place.Key);

            foreach (var name in place.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {name.Key} -> {name.Value}");
            }
        }
    }
    static void GetConcerts(Dictionary<string, Dictionary<string, long>> conserts)
    {
        string pattern = @"(?<name>[A-Za-z]+(\s[A-Za-z]+)*)\s\@(?<place>[A-Za-z]+(\s[A-Za-z]+)*)\s(?<ticketsPrice>\d+)\s(?<ticketsCount>\d+)";
        Regex regex = new Regex(pattern);

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    string place = match.Groups["place"].Value;
                    string name = match.Groups["name"].Value;
                    long income = int.Parse(match.Groups["ticketsPrice"].Value) * int.Parse(match.Groups["ticketsCount"].Value);

                    if (!conserts.ContainsKey(place))
                    {
                        conserts[place] = new Dictionary<string, long>();
                    }

                    if (!conserts[place].ContainsKey(name))
                    {
                        conserts[place][name] = 0;
                    }

                    conserts[place][name] += income;
                }
            }
        }
    }
}