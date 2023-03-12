using System;
using System.Collections.Immutable;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var encryption = new int[n];

        for (int i = 0; i < n; i++)
        {
            var word = Console.ReadLine();
            var sum = 0;

            for (int j = 0; j < word.Length; j++)
            {
                if (word[j] == 'a' || word[j] == 'o' || word[j] == 'u' || word[j] == 'e' || word[j] == 'i' ||
                    word[j] == 'A' || word[j] == 'O' || word[j] == 'U' || word[j] == 'E' || word[j] == 'I')
                {
                    sum += word[j] * word.Length;
                }
                else
                {
                    sum += word[j] / word.Length;
                }
            }

            encryption[i] = sum;
        }
        Console.WriteLine(string.Join(Environment.NewLine, encryption.OrderBy(x => x)));
    }
}