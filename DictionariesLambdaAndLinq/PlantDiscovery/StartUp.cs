public class StartUp
{
    public static void Main()
    {
        var plants = new Dictionary<string, List<int>>();
        AddPlants(plants);

        string input;

        while ((input = Console.ReadLine()) != "Exhibition")
        {
            var args = input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            var plant = args[1];

            if (!plants.ContainsKey(plant))
            {
                Console.WriteLine("error");
                continue;
            }

            if (command == "Rate")
            {
                var rating = int.Parse(args[2]);
                plants[plant].Add(rating);
            }
            else if (command == "Update")
            {
                var rarity = int.Parse(args[2]);
                plants[plant][0] = rarity;
            }
            else if (command == "Reset")
            {
                if (plants[plant].Count > 1)
                {
                    plants[plant].RemoveRange(1, plants[plant].Count - 1);
                }
            }
        }

        PrintPlants(plants);
    }
    static void PrintPlants(Dictionary<string, List<int>> plants)
    {
        Console.WriteLine("Plants for the exhibition:");

        foreach (var plant in plants)
        {
            var avg = 0.0;

            if (plants[plant.Key].Count > 1)
            {
                avg = plants[plant.Key].Skip(1).Take(plants[plant.Key].Count - 1).Average();
            }
            
            Console.WriteLine($"- {plant.Key}; Rarity: {plants[plant.Key][0]}; Rating: {avg:F2}");
        }
    }
    static void AddPlants(Dictionary<string, List<int>> plants)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
            var plant = args[0];
            var rarity = int.Parse(args[1]);

            if (!plants.ContainsKey(plant))
            {
                plants[plant] = new List<int>();
                plants[plant].Add(0);
            }

            plants[plant][0] = rarity;
        }
    }
}