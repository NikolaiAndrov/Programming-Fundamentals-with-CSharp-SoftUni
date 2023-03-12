using System.Text;

public class StartUp
{
    public static void Main()
    {
        var key = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string text;

        while ((text = Console.ReadLine()) != "find")
        {
            var message = FindHiddenMessage(text, key);
            FindCoordinates(message);
        }
    }

    static void FindCoordinates(string message)
    {
        var startIndexType = message.IndexOf('&');
        var endIndexType = message.LastIndexOf("&");
        var type = message.Substring(startIndexType + 1, endIndexType - startIndexType - 1);

        var startIndexCoordinates = message.IndexOf('<');
        var endIndexCoordinates = message.IndexOf(">");
        var coordinates = message.Substring(startIndexCoordinates + 1, endIndexCoordinates - startIndexCoordinates - 1);

        Console.WriteLine($"Found {type} at {coordinates}");
    }
    static string FindHiddenMessage(string text, int[] key)
    {
        StringBuilder hiddenMessage = new StringBuilder();
        var j = 0;

        for (int i = 0; i < text.Length; i++)
        {
            var ch = (char)(text[i] - key[j]);
            hiddenMessage.Append(ch);
            j++;

            if (j == key.Length)
            {
                j = 0;
            }
        }

        return hiddenMessage.ToString();
    }
}