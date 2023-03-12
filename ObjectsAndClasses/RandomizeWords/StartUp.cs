public class StartUp
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        Random random = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            var randomIndex = random.Next(words.Length);
            var currentWord = words[i];
            words[i] = words[randomIndex];
            words[randomIndex] = currentWord;
        }

        Console.WriteLine(string.Join(Environment.NewLine, words));
    }
}