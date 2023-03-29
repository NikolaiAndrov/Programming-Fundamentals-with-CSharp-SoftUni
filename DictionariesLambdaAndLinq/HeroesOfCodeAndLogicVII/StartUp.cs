public class StartUp
{
    public static void Main()
    {
        var heroes = new Dictionary<string, List<int>>();
        GetHeroes(heroes);
        GetCommands(heroes);
        PrintHeroes(heroes);
    }

    static void PrintHeroes(Dictionary<string, List<int>> heroes)
    {
        foreach (var hero in heroes)
        {
            Console.WriteLine(hero.Key);
            Console.WriteLine($"  HP: {hero.Value[0]}");
            Console.WriteLine($"  MP: {hero.Value[1]}");
        }
    }
    static void GetCommands(Dictionary<string, List<int>> heroes)
    {
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var commandInfo = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            var command = commandInfo[0];
            var hero = commandInfo[1];

            if (command == "CastSpell")
            {
                var mpNeeded = int.Parse(commandInfo[2]);
                var spellName = commandInfo[3];

                if (heroes[hero][1] >= mpNeeded)
                {
                    heroes[hero][1] -= mpNeeded;
                    Console.WriteLine($"{hero} has successfully cast {spellName} and now has {heroes[hero][1]} MP!");
                }
                else
                {
                    Console.WriteLine($"{hero} does not have enough MP to cast {spellName}!");
                }
            }
            else if (command == "TakeDamage")
            {
                var damage = int.Parse(commandInfo[2]);
                var attacker = commandInfo[3];
                heroes[hero][0] -= damage;

                if (heroes[hero][0] > 0)
                {
                    Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heroes[hero][0]} HP left!");
                }
                else
                {
                    heroes.Remove(hero);
                    Console.WriteLine($"{hero} has been killed by {attacker}!");
                }
            }
            else if(command == "Recharge")
            {
                var amount = int.Parse(commandInfo[2]);
                Recharge(heroes, hero, amount);
            }
            else if (command == "Heal")
            {
                var amount = int.Parse(commandInfo[2]);
                Heal(heroes, hero, amount);
            }
        }
    }
    
    static void Heal(Dictionary<string, List<int>> heroes, string hero, int amount)
    {
        if (heroes[hero][0] + amount > 100)
        {
            var diff = 100 - heroes[hero][0];
            heroes[hero][0] += diff;
            Console.WriteLine($"{hero} healed for {diff} HP!");
        }
        else
        {
            heroes[hero][0] += amount;
            Console.WriteLine($"{hero} healed for {amount} HP!");
        }
    }
    static void Recharge(Dictionary<string, List<int>> heroes, string hero, int amount)
    {
        if (heroes[hero][1] + amount > 200)
        {
            var diff = 200 - heroes[hero][1];
            heroes[hero][1] += diff;
            Console.WriteLine($"{hero} recharged for {diff} MP!");
        }
        else
        {
            heroes[hero][1] += amount;
            Console.WriteLine($"{hero} recharged for {amount} MP!");
        }
    }
    static void GetHeroes(Dictionary<string, List<int>> heroes)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var heroInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var hero = heroInfo[0];
            var hp = int.Parse(heroInfo[1]);
            var mp = int.Parse(heroInfo[2]);

            if (hp > 100)
            {
                hp = 100;
            }

            if (mp > 200)
            {
                mp = 200;
            }

            heroes[hero] = new List<int> { hp, mp };
        }
    }
}
