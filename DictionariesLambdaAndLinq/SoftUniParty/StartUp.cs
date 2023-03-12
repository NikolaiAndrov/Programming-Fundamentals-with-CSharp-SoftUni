public class StartUp
{
    public static void Main()
    {
        var guests = new  HashSet<string>();

        string input;

        while ((input = Console.ReadLine()) != "PARTY")
        {
            guests.Add(input);
        }

        while ((input = Console.ReadLine()) != "END")
        {
            guests.Remove(input);
        }

        var result = new List<string>();

        foreach (var guest in guests)
        {
            for (int i = 0; i < guest.Length; i++)
            {
                if (char.IsDigit(guest[0]))
                {
                    result.Add(guest);
                    guests.Remove(guest);
                    break;
                }
            }
        }

        var count = result.Count + guests.Count;

        Console.WriteLine(count);

        foreach (var guest in result)
        {
            Console.WriteLine(guest);
        }

        foreach (var guest in guests)
        {
            Console.WriteLine(guest);
        }
    }
}