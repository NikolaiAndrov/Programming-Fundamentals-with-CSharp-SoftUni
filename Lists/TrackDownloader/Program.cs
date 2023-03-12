using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blackListedWords = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var downloadedTracks = new List<string>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                bool isInBlackList = false;

                foreach (var item in blackListedWords)
                {
                    if (line.Contains(item))
                    {
                        isInBlackList = true;
                        break;
                    }
                }

                if (!isInBlackList)
                {
                    downloadedTracks.Add(line);
                }

                line = Console.ReadLine();
            }

            downloadedTracks.Sort();

            foreach (var track in downloadedTracks)
            {
                Console.WriteLine(track);
            }
        }
    }
}
