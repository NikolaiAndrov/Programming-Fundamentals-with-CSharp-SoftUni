public class StartUp
{
    public static void Main()
    {
        var members = new Dictionary<string, string>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            var name = args[1];

            if (command == "register")
            {
                var plate = args[2];

                if (members.ContainsKey(name))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {members[name]}");
                    continue;
                }

                members[name] = plate;
                Console.WriteLine($"{name} registered {plate} successfully");
            }
            else if (command == "unregister")
            {
                if (!members.ContainsKey(name))
                {
                    Console.WriteLine($"ERROR: user {name} not found");
                    continue;
                }

                members.Remove(name);
                Console.WriteLine($"{name} unregistered successfully");
            }
        }

        foreach (var member in members)
        {
            Console.WriteLine($"{member.Key} => {member.Value}");
        }
    }
}