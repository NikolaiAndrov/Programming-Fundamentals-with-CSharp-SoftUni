public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        var sum = 0m;

        foreach (var item in input)
        {
            var n1 = GetFirstLetterPosition(item);
            var num = GetNumber(item);
            var n2 = GetLastLetterPosition(item);

            if (char.IsUpper(item[0]))
            {
                num /= n1;
            }
            else if (char.IsLower(item[0]))
            {
                num *= n1;
            }

            if (char.IsUpper(item[item.Length - 1]))
            {
                num -= n2;
            }
            else if (char.IsLower(item[item.Length - 1]))
            {
                num += n2;
            }

            sum += num;
        }

        Console.WriteLine($"{sum:F2}");
    }

    static decimal GetNumber(string item)
    {
        var numStr = item.Substring(1, item.Length - 2);
        return decimal.Parse(numStr);
    }
    static decimal GetFirstLetterPosition(string item)
    {
        var letter = char.ToLower(item[0]);
        return letter - 96;
    }

    static decimal GetLastLetterPosition(string item)
    {
        var letter = char.ToLower(item[item.Length - 1]);
        return letter - 96;
    }
}