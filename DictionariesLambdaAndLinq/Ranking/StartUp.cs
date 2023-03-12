public class StartUp
{
    public static void Main()
    {
        var contestsAndPasswords = new Dictionary<string, string>();
        GetContestsAndPasswordsInfo(contestsAndPasswords);
        var participants = new SortedDictionary<string, Dictionary<string, int>>();
        GetParticipantsInfo(contestsAndPasswords, participants);
        PrintParticipants(participants);
    }

    static void PrintParticipants(SortedDictionary<string, Dictionary<string, int>> participants)
    {
        var bestCandidate = GetBestCandidate(participants);
        Console.WriteLine(bestCandidate);
        Console.WriteLine("Ranking:");

        foreach (var participant in participants)
        {
            Console.WriteLine(participant.Key);

            foreach (var contest in participant.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
            }
        }
    }
    static string GetBestCandidate(SortedDictionary<string, Dictionary<string, int>> participants)
    {
        var maxPoints = 0;
        var name = string.Empty;

        foreach(var participant in participants)
        {
            var max = 0;

            foreach (var contest in participant.Value)
            {
                max += contest.Value;
            }

            if (max > maxPoints)
            {
                maxPoints = max;
                name = participant.Key;
            }
        }

        return $"Best candidate is {name} with total {maxPoints} points.";
    }
    static void GetParticipantsInfo(Dictionary<string, string> contestsAndPasswords, SortedDictionary<string, Dictionary<string, int>> participants)
    {
        string input;

        while ((input = Console.ReadLine()) != "end of submissions")
        {
            var args = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
            var contest = args[0];
            var password = args[1];
            var name = args[2];
            var points = int.Parse(args[3]);

            if (contestsAndPasswords.ContainsKey(contest) && contestsAndPasswords[contest] == password)
            {
                if (!participants.ContainsKey(name))
                {
                    participants[name] = new Dictionary<string, int>();
                }

                if (!participants[name].ContainsKey(contest))
                {
                    participants[name][contest] = 0;
                }

                if (points > participants[name][contest])
                {
                    participants[name][contest] = points;
                }
            }
        }
    }
    static void GetContestsAndPasswordsInfo(Dictionary<string, string> contestsAndPasswords)
    {
        string input;

        while ((input = Console.ReadLine()) != "end of contests")
        {
            var args = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
            var contest = args[0];
            var password = args[1];

            contestsAndPasswords[contest] = password;
        }
    }
}