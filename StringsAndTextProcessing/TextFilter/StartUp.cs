﻿public class StartUp
{
    public static void Main()
    {
        var bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
        var text = Console.ReadLine();

        foreach (var word in bannedWords)
        {
            text = text.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}