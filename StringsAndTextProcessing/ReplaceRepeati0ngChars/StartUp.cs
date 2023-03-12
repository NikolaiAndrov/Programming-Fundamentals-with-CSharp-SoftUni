using System.Text;

public class StartUp
{
    public static void Main()
    {
        var word = Console.ReadLine().ToList();

        for (int i = 0; i < word.Count - 1; i++)
        {
            if (word[i] == word[i + 1])
            {
                word.RemoveAt(i);
                i--;
            }
        }

        Console.WriteLine(string.Join("", word));
    }
}