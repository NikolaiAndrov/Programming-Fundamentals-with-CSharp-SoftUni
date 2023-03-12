public class StartUp
{
    public static void Main()
    {
        var usernames = Console.ReadLine()
            .Split(", ")
            .Where(x => x.Length >= 3 && x.Length <= 16)
            .ToArray();

        foreach (var user in usernames)
        {
            var isValid = true;

            for (int i = 0; i < user.Length; i++)
            {
                var ch = user[i];
                
                if (!char.IsLetter(ch) && !char.IsDigit(ch) && ch != '-' && ch != '_')
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                Console.WriteLine(user);
            }
        }
    }
}