public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            var songInfo = Console.ReadLine()
                .Split("_");

            var type = songInfo[0];
            var name = songInfo[1];
            var time = songInfo[2];

            var currentSong = new Song(type, name, time);
            songs.Add(currentSong);
        }

        var listType = Console.ReadLine();

        foreach (var song in songs)
        {
            if (listType == "all")
            {
                Console.WriteLine(song.Name);
            }
            else if (listType == song.Type)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}

public class Song
{
    public Song(string type, string name, string time)
    {
        Type = type;
        Name = name;
        Time = time;
    }

    public string Type { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}