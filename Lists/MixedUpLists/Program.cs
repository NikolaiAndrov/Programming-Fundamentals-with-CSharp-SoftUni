internal class Program
{
    private static void Main()
    {
        var left = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var right = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var result = new List<int>();

        var min = Math.Min(left.Length, right.Length) - 1;

        if (right.Length > left.Length)
        {
           right = right.Reverse().ToArray();
        }

        for (int i = 0; i <= min; i++)
        {
            result.Add(left[i]);
            result.Add(right[min - i]);
        }

        var range = new int[2];

        if (left.Length > right.Length)
        {
            range = left.Skip(min + 1).Take(2).ToArray();
        }
        else if (right.Length > left.Length)
        {
            range = right.Skip(min + 1).Take(2).ToArray();
        }

        var startRange = range.Min();
        var endRange = range.Max();

        Console.WriteLine(string.Join(" ", result.OrderBy(x => x).Where(x => x > startRange && x < endRange)));
    }
}