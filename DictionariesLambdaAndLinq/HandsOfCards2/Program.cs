using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.WebSockets;

public class Program
{
    public static void Main()
    {
        var line = Console.ReadLine();

        var players = new Dictionary<string, HashSet<string>>();

        while (line != "JOKER")
        {
            var tokens = line.Split(':');
            var name = tokens[0];
            var cards = tokens[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct();



            if (!players.ContainsKey(name))
            {
                players[name] = new HashSet<string>();
            }

            foreach (var card in cards)
            {
                players[name].Add(card);
            }

            line = Console.ReadLine();

        }

        var result = new Dictionary<string, HashSet<int>>();

        foreach (var player in players)
        {
            var name = player.Key;
            var cards = player.Value.ToList();

            if (!result.ContainsKey(name))
            {
                result[name] = new HashSet<int>();
            }

            foreach (var card in cards)
            {
                var type = ' ';
                var power = "";
                var currentType = 0;
                var currentPower = 0;
                var sum = 0;

                for (int i = card.Length - 1; i >= 0; i--)
                {
                    if (i == card.Length - 1)
                    {
                        type = card[i];
                        break;
                    }

                }
                for (int i = 0; i < card.Length - 1; i++)
                {
                    power += card[i];
                }


                if (type == 'S')
                {
                    currentType = 4;
                }
                else if (type == 'H')
                {
                    currentType = 3;
                }
                else if (type == 'D')
                {
                    currentType = 2;
                }
                else if (type == 'C')
                {
                    currentType = 1;
                }

                if (power != "J" && power != "Q" && power != "K" && power != "A")
                {
                    currentPower = int.Parse(power);
                }
                else if (power == "J")
                {
                    currentPower = 11;
                }
                else if (power == "Q")
                {
                    currentPower = 12;
                }
                else if (power == "K")
                {
                    currentPower = 13;
                }
                else if (power == "A")
                {
                    currentPower = 14;
                }

                sum = currentPower * currentType;
                result[name].Add(sum);
            }

        }

        foreach (var player in result)
        {
            var name = player.Key;
            var cards = player.Value.Sum();
            Console.WriteLine($"{name}: {cards}");
        }
    }
}