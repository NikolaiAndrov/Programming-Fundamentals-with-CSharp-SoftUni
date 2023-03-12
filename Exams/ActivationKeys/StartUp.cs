public class StartUp
{
    public static void Main()
    {
        var key = Console.ReadLine();

        string input;

        while ((input = Console.ReadLine()) != "Generate")
        {
            var args = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];

            if (command == "Contains")
            {
                var substring = args[1];

                if (key.Contains(substring))
                {
                    Console.WriteLine($"{key} contains {substring}");
                }
                else
                {
                    Console.WriteLine("Substring not found!");
                }
            }
            else if (command == "Flip")
            {
                var caseType = args[1];
                var startIndex = int.Parse(args[2]);
                var endIndex = int.Parse(args[3]);
                key = ChangeCharCase(key, caseType, startIndex, endIndex);
                Console.WriteLine(key);
            }
            else if (command == "Slice")
            {
                var startIndex = int.Parse(args[1]);
                var endIndex = int.Parse(args[2]);
                var count = endIndex - startIndex;
                key = key.Remove(startIndex, count);
                Console.WriteLine(key);
            }
        }

        Console.WriteLine($"Your activation key is: {key}");
    }
    static string ChangeCharCase(string key, string caseType, int startIndex, int endIndex)
    {
        var count = endIndex - startIndex;
        var substring = key.Substring(startIndex, count);
        key = key.Remove(startIndex, count);

        if (caseType == "Upper")
        {
            key = key.Insert(startIndex, substring.ToUpper());
        }
        else if (caseType == "Lower")
        {
            key = key.Insert(startIndex, substring.ToLower());
        }

        return key;
    }
}