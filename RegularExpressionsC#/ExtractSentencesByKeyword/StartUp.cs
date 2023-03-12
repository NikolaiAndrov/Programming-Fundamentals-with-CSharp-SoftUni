using System;
using System.Linq;
public class StartUp
{
    public static void Main()
    {
        var specialWord = Console.ReadLine().Trim();

        var sentences = Console.ReadLine()
           .Split(new char[] {'.', '!', '?'});

        foreach (var sentence in sentences)
        {
            var result = sentence
                .Split(new char[] { ',', ':', '(', ')', '[', ']', '\"', '\'', '/', '\\', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (result.Contains(specialWord))
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}