public class StartUp
{
    public static void Main()
    {
        var text = Console.ReadLine()
            .Replace(" ", string.Empty)
            .ToArray();

        var lettersCount = new Dictionary<char, int>();

        foreach (var letter in text)
        {
            if (!lettersCount.ContainsKey(letter))
            {
                lettersCount[letter] = 0;
            }

            lettersCount[letter]++;
        }

        foreach (var letter in lettersCount)
        {
            Console.WriteLine($"{letter.Key} -> {letter.Value}");
        }
    }
}