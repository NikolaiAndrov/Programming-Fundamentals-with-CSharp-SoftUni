using System;
using System.Linq;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var logs = new SortedDictionary<string, SortedDictionary<string, int>>();
        GetLogs(logs);
        PrintLogs(logs);
    }

    static void PrintLogs(SortedDictionary<string, SortedDictionary<string, int>> logs)
    {
        foreach (var log in logs)
        {
            Console.WriteLine($"{log.Key}: {log.Value.Values.Sum()} [{string.Join(", ", log.Value.Keys)}]");
        }
    }
    static void GetLogs(SortedDictionary<string, SortedDictionary<string, int>> logs)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var logsInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var ip = logsInfo[0];
            var name = logsInfo[1];
            var duration = int.Parse(logsInfo[2]);

            if (!logs.ContainsKey(name))
            {
                logs[name] = new SortedDictionary<string, int>();
            }

            if (!logs[name].ContainsKey(ip))
            {
                logs[name][ip] = 0;
            }

            logs[name][ip] += duration;
        }
    }
}