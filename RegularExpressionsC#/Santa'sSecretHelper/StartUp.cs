using System.Text;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        List<string> messages = new List<string>();
        DecryptMessages(messages);
        PrintGoodChildren(messages);
    }

    static void PrintGoodChildren(List<string> messages)
    {
        string pattern = @"\@(?<name>[A-Za-z]+)([^\@\-\!\:\>]*)(?<behavior>\![G]!)";
        Regex regex = new Regex(pattern);

        foreach (string child in messages) 
        {
            Match match = regex.Match(child);

            if (match.Success)
            {
                Console.WriteLine(match.Groups["name"].Value);
            }
        }
    }
    static void DecryptMessages(List<string> messages)
    {
        int n = int.Parse(Console.ReadLine());

        string encryptedMessages;

        while ((encryptedMessages = Console.ReadLine()) != "end")
        {
            StringBuilder message = new StringBuilder();

            for (int i = 0; i < encryptedMessages.Length; i++)
            {
                message.Append((char)(encryptedMessages[i] - n));
            }

            messages.Add(message.ToString());
        }
    }
}