public class StartUp
{
    public static void Main()
    {
        string[] phrases =
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can't live without this product."
        };

        string[] events =
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles.",
            "I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        string[] authors =
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };

        string[] cities =
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string phrase = GetRandomWord(phrases);
            string currentEvent = GetRandomWord(events);
            string author = GetRandomWord(authors);
            string city = GetRandomWord(cities);

            Console.WriteLine($"{phrase} {currentEvent} {author} – {city}.");
        }

    }

    static string GetRandomWord(string[] words)
    {
        Random random = new Random();
        string word = words[random.Next(words.Length)];
        return word;
    }
}