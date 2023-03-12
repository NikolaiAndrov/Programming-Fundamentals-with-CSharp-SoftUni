using System.Text;

public class StartUp
{
    public static void Main()
    {
        string password = Console.ReadLine();

        string commandArgs;

        while ((commandArgs = Console.ReadLine()) != "Done") 
        {
            string[] args = commandArgs.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];

            if (command == "TakeOdd")
            {
                password = TakeOddChars(password);
                Console.WriteLine(password);
            }
            else if (command == "Cut")
            {
                int index = int.Parse(args[1]);
                int length = int.Parse(args[2]);
                password = password.Remove(index, length);
                Console.WriteLine(password);
            }
            else if (command == "Substitute")
            {
                string word = args[1];
                string substitute = args[2];

                if (password.Contains(word))
                {
                    password = password.Replace(word, substitute);
                    Console.WriteLine(password);
                }
                else
                {
                    Console.WriteLine("Nothing to replace!");
                }
            }
        }

        Console.WriteLine($"Your password is: {password}");
    }

    static string TakeOddChars(string word)
    {
        StringBuilder currentWord = new StringBuilder();

        for (int i = 0; i < word.Length; i++)
        {
            if (i % 2 != 0)
            {
                currentWord.Append(word[i]);
            }
        }

        return currentWord.ToString();
    }
}