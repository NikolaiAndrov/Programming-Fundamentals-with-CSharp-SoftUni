public class StartUp
{
    public static void Main()
    {
        var players = new Dictionary<string, Dictionary<string, int>>();

        string input;

        while ((input = Console.ReadLine()) != "Season end")
        {
            var args = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            if (args[1] != "vs")
            {
                var player = args[0];
                var place = args[1];
                var skill = int.Parse(args[2]);
                AddPlayers(players, player, place, skill);
                continue;
            }

            var player1 = args[0];
            var player2 = args[2];
            Fight(players, player1, player2);
        }

        PrintPlayers(players);
    }

    static void PrintPlayers(Dictionary<string, Dictionary<string, int>> players)
    {
        foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

            foreach (var place in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"- {place.Key} <::> {place.Value}");
            }
        }
    }
    static void Fight(Dictionary<string, Dictionary<string, int>> players, string player1, string player2)
    {
        if (players.ContainsKey(player1) && players.ContainsKey(player2))
        {
            var isBest = false;

            foreach (var player in players)
            {
                foreach (var k in player.Value)
                {
                    if (players[player1].ContainsKey(k.Key) && players[player2].ContainsKey(k.Key))
                    {
                        if (players[player1][k.Key] > players[player2][k.Key])
                        {
                            players.Remove(player2);
                            isBest = true;
                            break;
                        }
                        else if (players[player1][k.Key] < players[player2][k.Key])
                        {
                            players.Remove(player1);
                            isBest = true;
                            break;
                        }
                    }
                }

                if (isBest)
                {
                    break;
                }
            }
        }
    }
    static void AddPlayers(Dictionary<string, Dictionary<string, int>> players, string player, string place, int skill)
    {
        if (!players.ContainsKey(player))
        {
            players[player] = new Dictionary<string, int>();
        }

        if (!players[player].ContainsKey(place))
        {
            players[player][place] = 0;
        }

        if (players[player][place] < skill)
        {
            players[player][place] = skill;
        }
    }
}