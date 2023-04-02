public class StartUp
{
    public static void Main()
    {
        var people = new Dictionary<string, int>();
        var capacity = int.Parse(Console.ReadLine());

        string input;

        while ((input = Console.ReadLine()) != "Statistics")
        {
            var commandInfo = input.Split("=", StringSplitOptions.RemoveEmptyEntries);
            var command = commandInfo[0];

            if (command == "Add")
            {
                var username = commandInfo[1];
                var sent = int.Parse(commandInfo[2]);
                var received = int.Parse(commandInfo[3]);

                if (!people.ContainsKey(username))
                {
                    var totalMessages = sent + received;
                    people[username] = totalMessages;
                }
            }
            else if (command == "Message")
            {
                var sender = commandInfo[1];
                var receiver = commandInfo[2];

                if (people.ContainsKey(sender) && people.ContainsKey(receiver))
                {
                    people[sender] += 1;
                    people[receiver] += 1;

                    if (people[sender] >= capacity)
                    {
                        Console.WriteLine($"{sender} reached the capacity!");
                        people.Remove(sender);
                    }

                    if (people[receiver] >= capacity)
                    {
                        Console.WriteLine($"{receiver} reached the capacity!");
                        people.Remove(receiver);
                    }
                }
            }
            else if(command == "Empty")
            {
                if (commandInfo[1] == "All")
                {
                    people.Clear();
                    continue;
                }

                var username = commandInfo[1];

                if (people.ContainsKey(username))
                {
                    people.Remove(username);
                }
            }
        }

        Console.WriteLine($"Users count: {people.Count}");

        foreach ( var person in people )
        {
            Console.WriteLine($"{person.Key} - {person.Value}");
        }
    }
}