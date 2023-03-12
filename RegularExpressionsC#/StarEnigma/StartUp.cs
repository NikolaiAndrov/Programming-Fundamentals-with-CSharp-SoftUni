using System.Text;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:\d+[^\@\-\!\:\>]*?\!(?<attack>[A-Z])\![^\@\-\!\:\>]*?\-\>\d+";
        Regex regex = new Regex(pattern);

        List<string> attacked = new List<string>();
        List<string> destructed = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string encryptedMessage = Console.ReadLine();
            string decryptedMessage = DecryptMessage(encryptedMessage);

            Match match = regex.Match(decryptedMessage);

            if (match.Success)
            {
                string planet = match.Groups["planet"].Value;
                string attack = match.Groups["attack"].Value;

                if (attack == "A")
                {
                    attacked.Add(planet);
                }
                else if (attack == "D")
                {
                    destructed.Add(planet);
                }
            }
        }

        PrintPlanets(attacked, destructed);
    }

    static void PrintPlanets(List<string> attacked, List<string> destructed)
    {
        Console.WriteLine($"Attacked planets: {attacked.Count}");

        foreach (var planet in attacked.OrderBy(p => p))
        {
            Console.WriteLine($"-> {planet}");
        }

        Console.WriteLine($"Destroyed planets: {destructed.Count}");

        foreach(var planet in destructed.OrderBy(p => p))
        {
            Console.WriteLine($"-> {planet}");
        }
    }
    static string DecryptMessage(string encryptedMessage)
    {
        int lettersCount = 0;

        foreach (var letter in encryptedMessage)
        {
            if (char.ToLower(letter) == 's' ||
                char.ToLower(letter) == 't' ||
                char.ToLower(letter) == 'a' ||
                char.ToLower(letter) == 'r')
            {
                lettersCount++;
            }
        }

        StringBuilder message = new StringBuilder();

        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            char letter = (char)(encryptedMessage[i] - lettersCount);
            message.Append(letter);
        }

        return message.ToString();
    }
}