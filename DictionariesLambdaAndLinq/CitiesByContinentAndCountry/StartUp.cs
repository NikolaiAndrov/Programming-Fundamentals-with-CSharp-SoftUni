public class StartUp
{
    public static void Main()
    {
        var globe = new Dictionary<string, Dictionary<string, List<string>>>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var continent = args[0];
            var country = args[1];
            var city = args[2];

            if (!globe.ContainsKey(continent))
            {
                globe[continent] = new Dictionary<string, List<string>>();
            }

            if (!globe[continent].ContainsKey(country))
            {
                globe[continent][country] = new List<string>();
            }

            globe[continent][country].Add(city);
        }

        foreach (var continent in globe)
        {
            Console.WriteLine($"{continent.Key}:");

            foreach (var country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }
}