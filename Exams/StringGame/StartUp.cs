public class StartUp
{
    public static void Main()
    {
        var str = Console.ReadLine();

        string input;

        while ((input = Console.ReadLine()) != "Done")
        {
            var commandInfo = input.Split();
            var command = commandInfo[0];

            if (command == "Change")
            {
                var ch = commandInfo[1];
                var replacement = commandInfo[2];
                str = str.Replace(ch, replacement);
                Console.WriteLine(str);

            }
            else if (command == "Includes")
            {
                var subs = commandInfo[1];

                if (str.Contains(subs))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (command == "End")
            {
                var subs = commandInfo[1];

                if (str.EndsWith(subs))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else if (command == "Uppercase")
            {
                str = str.ToUpper();
                Console.WriteLine(str);
            }
            else if (command == "FindIndex")
            {
                var ch = commandInfo[1];
                var index = str.IndexOf(ch);
                Console.WriteLine(index);
            }
            else if (command == "Cut")
            {
                var index = int.Parse(commandInfo[1]);
                var len = int.Parse(commandInfo[2]);
                var subs = str.Substring(index, len);
                str = subs;
                Console.WriteLine(str);
            }
        }
    }
}