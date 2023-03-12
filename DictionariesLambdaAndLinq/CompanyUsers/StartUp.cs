public class StartUp
{
    public static void Main()
    {
        var companyUsers = new Dictionary<string, HashSet<string>>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var args = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            var company = args[0];
            var userID = args[1];

            if (!companyUsers.ContainsKey(company))
            {
                companyUsers[company] = new HashSet<string>();
            }

            companyUsers[company].Add(userID);
        }

        foreach (var item in companyUsers)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine($"-- {string.Join(Environment.NewLine + "-- ", item.Value)}");
        }
    }
        
}