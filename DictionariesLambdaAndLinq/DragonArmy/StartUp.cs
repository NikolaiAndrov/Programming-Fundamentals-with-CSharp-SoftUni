public class StartUp
{
    public static void Main()
    {
        var dragons = new Dictionary<string, SortedDictionary<string, List<double>>>();
        AddDragons(dragons);
        PrintDragons(dragons);
    }
    static void PrintDragons(Dictionary<string, SortedDictionary<string, List<double>>> dragons)
    {
        foreach (var type in dragons)
        {
            var avg = GetAverage(dragons, type.Key);
            Console.WriteLine(avg);

            foreach (var dragon in type.Value)
            {
                Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
            }
        }
    }
    static string GetAverage(Dictionary<string, SortedDictionary<string, List<double>>> dragons, string type)
    {
        var damage = 0d;
        var health = 0d;
        var armor = 0d;

        foreach (var currentType in dragons)
        {
            if (currentType.Key == type)
            {
                foreach (var dragon in currentType.Value)
                {
                    damage += dragon.Value[0];
                    health += dragon.Value[1];
                    armor += dragon.Value[2];
                }
            }
        }

        return $"{type}::({(damage / dragons[type].Count):F2}/{(health / dragons[type].Count):F2}/{(armor / dragons[type].Count):F2})";
    }
    static void AddDragons(Dictionary<string, SortedDictionary<string, List<double>>> dragons)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var dragonsInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var type = dragonsInfo[0];
            var name = dragonsInfo[1];
            var currentDamage = dragonsInfo[2];
            var currentHealth = dragonsInfo[3];
            var currentArmor = dragonsInfo[4];

            var damage = 0d;
            var health = 0d;
            var armor = 0d;

            if (currentDamage == "null")
            {
                damage = 45;
            }
            else
            {
                damage = double.Parse(currentDamage);
            }

            if (currentHealth == "null")
            {
                health = 250;
            }
            else
            {
                health = double.Parse(currentHealth);
            }

            if (currentArmor == "null")
            {
                armor = 10;
            }
            else
            {
                armor = double.Parse(currentArmor);
            }
            
            if (!dragons.ContainsKey(type))
            {
                dragons[type] = new SortedDictionary<string, List<double>>();
            }

            if (!dragons[type].ContainsKey(name))
            {
                dragons[type][name] = new List<double>();
                dragons[type][name].Add(0);
                dragons[type][name].Add(0);
                dragons[type][name].Add(0);
            }

            dragons[type][name][0] = damage;
            dragons[type][name][1] = health;
            dragons[type][name][2] = armor;
        }
    }
}