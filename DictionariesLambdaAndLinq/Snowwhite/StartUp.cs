public class StartUp
{
    public static void Main()
    {
        var dwarfs = new Dictionary<string, int>();
        AddDwarfs(dwarfs);
        PrintDwarfs(dwarfs);
    }

    static void PrintDwarfs(Dictionary<string, int> dwarfs)
    {
        foreach (var dwarf in dwarfs
            .OrderByDescending(x => x.Value)
            .ThenByDescending(x => dwarfs.Where(y => y.Key.Split()[0] == x.Key.Split(" ")[0])
            .Count())) 
        {
            Console.WriteLine($"{dwarf.Key.Split()[0]} {dwarf.Key.Split()[1]} <-> {dwarf.Value}");
        }
    }
    static void AddDwarfs(Dictionary<string, int> dwarfs)
    {
        string input;

        while ((input = Console.ReadLine()) != "Once upon a time")
        {
            var args = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
            var dwarf = $"({args[1]}) {args[0]}";
            var physics = int.Parse(args[2]);

            if (!dwarfs.ContainsKey(dwarf))
            {
                dwarfs[dwarf] = 0;
            }

            if (dwarfs[dwarf] < physics)
            {
                dwarfs[dwarf] = physics;
            }
        }
    }
}