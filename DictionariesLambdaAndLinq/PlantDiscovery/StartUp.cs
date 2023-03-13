public class StartUp
{
    public static void Main()
    {
        var plants = new Dictionary<string, List<int>>();
        AddPlants(plants);
        ModifyPlants(plants);
        PrintPlants(plants);
    }

    static void PrintPlants(Dictionary<string, List<int>> plants)
    {
        Console.WriteLine("Plants for the exhibition:");

        foreach (var plant in plants)
        {
            var avg = 0d;

            if (plant.Value.Count > 1)
            {
                avg = plant.Value.Skip(1).Average();
            }

            Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {avg:F2}");
        }
    }
    static void ModifyPlants(Dictionary<string, List<int>> plants)
    {
        string input;

        while ((input = Console.ReadLine()) != "Exhibition")
        {
            var args = input.Split(new char[] {':', ' ', '-'}, StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            var plant = args[1];

            if (command == "Rate")
            {
                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                var rating = int.Parse(args[2]);
                plants[plant].Add(rating);
            }
            else if (command == "Update")
            {
                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                var rarity = int.Parse(args[2]);
                plants[plant][0] = rarity;
            }
            else if (command == "Reset")
            {
                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                plants[plant].RemoveRange(1, plants[plant].Count - 1);
            }
        }
    }
    static void AddPlants(Dictionary<string, List<int>> plants)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var plantInfo = Console.ReadLine().Split("<->");
            var plant = plantInfo[0];
            var rarity = int.Parse(plantInfo[1]);

            if (!plants.ContainsKey(plant))
            {
                plants[plant] = new List<int>();
                plants[plant].Add(0);
            }

            plants[plant][0] = rarity;
        }
        
    }
}
