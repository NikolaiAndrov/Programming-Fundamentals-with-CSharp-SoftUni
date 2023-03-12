public class StartUp
{
    public static void Main()
    {
        string message = Console.ReadLine();

        string input;

        while ((input = Console.ReadLine()) != "Reveal")
        {
            string[] args = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];

            if (command == "InsertSpace")
            {
                int index = int.Parse(args[1]);
                message = message.Insert(index, " ");
                Console.WriteLine(message);
            }
            else if (command == "Reverse")
            {
                string word = args[1];

                if (message.Contains(word))
                {
                    int index = message.IndexOf(word);
                    message = message.Remove(index, word.Length);
                    char[] reversed = word.Reverse().ToArray();
                    string result = new string(reversed);
                    message += result;
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (command == "ChangeAll")
            {
                string word = args[1];
                string replacement = args[2];

                message = message.Replace(word, replacement);
                Console.WriteLine(message);
            }
        }

        Console.WriteLine($"You have a new text message: {message}");
    }
}