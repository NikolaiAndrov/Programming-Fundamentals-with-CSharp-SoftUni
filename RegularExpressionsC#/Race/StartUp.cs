using System.Text;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        var people = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
        var peopleInfo = new Dictionary<string, int>();
        PushPeopleInfo(people, peopleInfo);

        var pattern = @"([A-Za-z])|(\d)";
        var regex = new Regex(pattern);

        string input;

        while ((input = Console.ReadLine()) != "end of race")
        {
            var matches = regex.Matches(input);
            GetAndModifyPeopleInfo(matches, peopleInfo);
        }

        PrintTop3Competitors(peopleInfo);
    }

    static void PrintTop3Competitors(Dictionary<string, int> peopleInfo)
    {
        var count = 0;

        foreach (var person in peopleInfo.OrderByDescending(x => x.Value))
        {
            count++;

            if (count == 1)
            {
                Console.WriteLine($"{count}st place: {person.Key}");
            }
            else if (count == 2)
            {
                Console.WriteLine($"{count}nd place: {person.Key}");
            }
            else if(count == 3)
            {
                Console.WriteLine($"{count}rd place: {person.Key}");
            }

            if (count == 3)
            {
                break;
            }
        }
    }
    static void GetAndModifyPeopleInfo(MatchCollection matches, Dictionary<string, int> peopleInfo)
    {
        var name = new StringBuilder();
        var sum = 0;

        foreach (Match match in matches)
        {
            var matchStr = match.Value;
            var ch = char.Parse(matchStr);

            if (char.IsLetter(ch))
            {
                name.Append(matchStr);
            }
            else if (char.IsDigit(ch))
            {
                var n = int.Parse(matchStr);
                sum += n;
            }
        }

        var personName = name.ToString();

        if (peopleInfo.ContainsKey(personName))
        {
            peopleInfo[personName] += sum;
        }
    }
    static void PushPeopleInfo(string[] people, Dictionary<string, int> peopleInfo)
    {
        foreach (var person in people)
        {
            if (!peopleInfo.ContainsKey(person))
            {
                peopleInfo[person] = 0;
            }
        }
    }
}