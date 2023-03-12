using System.Text;
public class StartUp
{
    public static void Main()
    {
        var words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                result.Append(word);
            }
        }

        Console.WriteLine(result);
    }
}