using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OnlineRadioDatabase
{
    public class OnlineRadioDatabase
    {
        public static void Main()
        {

            var playlist = new List<Song>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split(';');
                string artistName = data[0];
                string songName = data[1];
                
                try
                {
                    var length = data[2].Split(':').Select(int.Parse).ToArray();
                    var song = new Song(songName, artistName, length[0], length[1]);
                    playlist.Add(song);
                    Console.WriteLine($"Song added.");
                }

                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }

            int totalMinutes = playlist.Sum(s => s.Minutes);
            int totalSeconds = playlist.Sum(s => s.Seconds);

            totalSeconds += totalMinutes * 60;
            totalMinutes = totalSeconds / 60;
            totalSeconds = totalSeconds % 60;
            int totalHours = totalMinutes / 60;
            totalMinutes = totalMinutes % 60;

            Console.WriteLine($"Songs added: {playlist.Count}");
            Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");
        }
    }
}
