public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var firstWord = input[0];
        var secondWord = input[1];
        var n = Math.Min(firstWord.Length, secondWord.Length);
        var sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += firstWord[i] * secondWord[i];
        }

        if (firstWord.Length > secondWord.Length)
        {
            for (int i = n; i < firstWord.Length; i++)
            {
                sum += firstWord[i];
            }
        }
        else if (secondWord.Length > firstWord.Length)
        {
            for (int i = n; i < secondWord.Length; i++)
            {
                sum += secondWord[i];
            }
        }

        Console.WriteLine(sum);
    }
}