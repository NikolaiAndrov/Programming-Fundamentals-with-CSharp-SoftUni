public class Program
{
    public static void Main()
    {
        var word = Console.ReadLine().ToList();

        string input;

        while ((input = Console.ReadLine()) != "Decode")
        {
            var args = input.Split("|");
            var command = args[0];

            if (command == "Move")
            {
                var n = int.Parse(args[1]);
                var subList = word.Take(n).ToList();
                word.RemoveRange(0, n);
                word.AddRange(subList);
            }
            else if (command == "Insert")
            {
                var index = int.Parse(args[1]);

                var elements = args[2].ToCharArray();
                word.InsertRange(index, elements);
            }
            else if (command == "ChangeAll")
            {
                var substring = char.Parse(args[1]);
                var replacement = char.Parse(args[2]);

                for (int i = 0; i < word.Count; i++)
                {
                    if (word[i] == substring)
                    {
                        word[i] = replacement;
                    }
                }
            }
        }

        Console.WriteLine($"The decrypted message is: {string.Join("", word)}");
    }
}