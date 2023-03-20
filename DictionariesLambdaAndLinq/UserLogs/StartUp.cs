using System;
using System.Linq;
using System.Collections.Generic;
public class StartUp
{
    public static void Main()
    {
        var logs = new SortedDictionary<string, Dictionary<string, int>>();
        GetLogs(logs);
        PrintLogs(logs);

    }

    static void PrintLogs(SortedDictionary<string, Dictionary<string, int>> logs)
    {
        foreach (var user in logs)
        {
            Console.WriteLine($"{user.Key}:");
            var count = 0;

            foreach (var log in user.Value)
            {
                count++;
                if (count == user.Value.Count)
                {
                    Console.WriteLine($"{log.Key} => {log.Value}.");
                    break;
                }

                Console.Write($"{log.Key} => {log.Value}, ");
            }
        }
    }
    static void GetLogs(SortedDictionary<string, Dictionary<string, int>> logs)
    {
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            var logsInfo = input.Split(new char[] { ' ', '='}, StringSplitOptions.RemoveEmptyEntries);
            var ip = logsInfo[1];
            var message = logsInfo[3];
            var user = logsInfo[5];

            if (!logs.ContainsKey(user))
            {
                logs[user] = new Dictionary<string, int>();
            }

            if (!logs[user].ContainsKey(ip))
            {
                logs[user][ip] = 0;
            }

            logs[user][ip]++;
        }
    }
}