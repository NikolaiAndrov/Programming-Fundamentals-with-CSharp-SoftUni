using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.WebSockets;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
            

        var players = new Dictionary<string, HashSet<int>>();

        while (input != "JOKER")
        {

            var tokens = input.Split(':');
            var name = tokens[0];
            var cards = tokens[1].Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            

            foreach (var card in cards)
            {

                var power = "";
                var type = ' ';
                var sum = 0;
                var currentPower = 0;
                var currentType = 0;

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

                sum = currentPower * currentType;

                if (!players.ContainsKey(name))
                {
                    players[name] = new HashSet<int>();
                }
                players[name].Add(sum);
            }

            input = Console.ReadLine();
        }

        foreach (var player in players)
        {
            var name = player.Key;
            var value = player.Value.Sum();
            Console.WriteLine($"{name}: {value}");
        }
    }
}