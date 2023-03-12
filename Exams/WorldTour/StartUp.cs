public class StartUp
{
    public static void Main()
    {
        string destinations = Console.ReadLine();

        string commands;

        while ((commands = Console.ReadLine()) != "Travel")
        {
            string[] args = commands.Split(":", StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];

            if (command == "Add Stop")
            {
                int index = int.Parse(args[1]);
                string destination = args[2];
                if (index < 0 || index >= destinations.Length)
                {
                    Console.WriteLine(destinations);
                    continue;
                }
                destinations = destinations.Insert(index, destination);
                Console.WriteLine(destinations);
            }
            else if (command == "Remove Stop")
            {
                int startIndex = int.Parse(args[1]);
                int endIndex = int.Parse(args[2]);

                if (startIndex > endIndex ||
                    startIndex < 0 ||
                    startIndex >= destinations.Length ||
                    endIndex < 0 ||
                    endIndex >= destinations.Length)
                {
                    Console.WriteLine(destinations);
                    continue;
                }

                int count = endIndex - startIndex + 1;
                destinations = destinations.Remove(startIndex, count);
                Console.WriteLine(destinations);
            }
            else if (command == "Switch")
            {
                string oldDestination = args[1];
                string newDestination = args[2];

                if (destinations.Contains(oldDestination))
                {
                    destinations = destinations.Replace(oldDestination, newDestination);
                }
                Console.WriteLine(destinations);
            }
        }

        Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
    }
}