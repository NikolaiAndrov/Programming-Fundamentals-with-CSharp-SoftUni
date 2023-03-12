public class StartUp
{
    public static void Main()
    {
        var contest = new Dictionary<string, Dictionary<string, int>>();

        string input;

        while ((input = Console.ReadLine()) != "no more time")
        {
            var args = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            var name = args[0];
            var course = args[1];
            var points = int.Parse(args[2]);

            if (!contest.ContainsKey(course))
            {
                contest[course] = new Dictionary<string, int>();
            }

            if (!contest[course].ContainsKey(name))
            {
                contest[course][name] = 0;
            }

            if (contest[course][name] < points)
            {
                contest[course][name] = points;
            }
        }

        var statistics = new Dictionary<string, int>();

        foreach (var currentCourse in contest)
        {
            Console.WriteLine($"{currentCourse.Key}: {currentCourse.Value.Count()} participants");
            var count = 0;

            foreach (var userName in currentCourse.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                var name = userName.Key;

                if (!statistics.ContainsKey(name))
                {
                    statistics[name] = 0;
                }

                statistics[name] += userName.Value;

                count++;
                Console.WriteLine($"{count}. {userName.Key} <::> {userName.Value}");
            }
        }

        Console.WriteLine("Individual standings:");

        var count2 = 0;

        foreach (var userName in statistics.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            count2++;

            Console.WriteLine($"{count2}. {userName.Key} -> {userName.Value}");
        }
    }
}