public class StartUp
{
    public static void Main()
    {
        var heroes = new Dictionary<string, List<int>>();
        AddHeroes(heroes);

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var args = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            var heroName = args[1];

            if (command == "CastSpell")
            {
                var mpNeeded = int.Parse(args[2]);
                var spellName = args[3];
                CastSpell(heroes, heroName, mpNeeded, spellName);
            }
            else if (command == "TakeDamage")
            {
                var damage = int.Parse(args[2]);
                var attacker = args[3];
                TakeDamage(heroes, heroName, damage, attacker);
            }
            else if (command == "Recharge")
            {
                var amount = int.Parse(args[2]);
                Recharge(heroes, heroName, amount);
            }
            else if (command == "Heal")
            {
                var amount = int.Parse(args[2]);
                Heal(heroes, heroName, amount);
            }
        }

        PrintHeroes(heroes);
    }

    static void PrintHeroes(Dictionary<string, List<int>> heroes)
    {
        foreach (var hero in heroes)
        {
            Console.WriteLine(hero.Key);
            Console.WriteLine($"  HP: {heroes[hero.Key][0]}");
            Console.WriteLine($"  MP: {heroes[hero.Key][1]}");
        }
    }
    static void Heal(Dictionary<string, List<int>> heroes, string heroName, int amount)
    {
        if (heroes.ContainsKey(heroName))
        {
            if (heroes[heroName][0] + amount > 100)
            {
                var diff = 100 - heroes[heroName][0];
                heroes[heroName][0] += diff;
                Console.WriteLine($"{heroName} healed for {diff} HP!");
            }
            else
            {
                heroes[heroName][0] += amount;
                Console.WriteLine($"{heroName} healed for {amount} HP!");
            }
        }
    }
    static void Recharge(Dictionary<string, List<int>> heroes, string heroName, int amount)
    {
        if (heroes.ContainsKey(heroName))
        {
            if (heroes[heroName][1] + amount > 200)
            {
                var diff = 200 - heroes[heroName][1];
                heroes[heroName][1] += diff;
                Console.WriteLine($"{heroName} recharged for {diff} MP!");
            }
            else
            {
                heroes[heroName][1] += amount;
                Console.WriteLine($"{heroName} recharged for {amount} MP!");
            }
            
        }
    }
    static void TakeDamage(Dictionary<string, List<int>> heroes, string heroName, int damage, string attacker)
    {
        if (heroes.ContainsKey(heroName))
        {
            heroes[heroName][0] -= damage;

            if (heroes[heroName][0] > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
            }
            else if (heroes[heroName][0] <= 0)
            {
                heroes.Remove(heroName);
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
            }
        }
    }
    static void CastSpell(Dictionary<string, List<int>> heroes, string heroName, int mpNeeded, string spellName)
    {
        if (heroes.ContainsKey(heroName))
        {
            if (heroes[heroName][1] >= mpNeeded)
            {
                heroes[heroName][1] -= mpNeeded;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }
    }
    static void AddHeroes(Dictionary<string, List<int>> heroes)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var name = args[0];
            var hp = int.Parse(args[1]);
            var mp = int.Parse(args[2]);

            if (!heroes.ContainsKey(name))
            {
                heroes[name] = new List<int>();
                heroes[name].Add(hp);
                heroes[name].Add(mp);
            }
        }
    }
}