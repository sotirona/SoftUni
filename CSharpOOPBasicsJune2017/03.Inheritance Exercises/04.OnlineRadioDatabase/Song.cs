using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OnlineRadioDatabase
{
    public class Song
    {
        private int seconds;
        private int minutes;
        private string artistName;
        private string songName;

        public Song(string songName, string artistName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public int Seconds 
        {
            get { return this.seconds; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }

                this.seconds = value;
            }
        }

        public string ArtistName
        {
            get
            {
                return this.artistName;
            }

            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artistName = value;
            }
        }

        public string SongName
        {
            get
            {
                return this.songName;
            }

            set
            {
                if (value.Length<3||value.Length>30)
                {
                    throw new InvalidSongNameException();
                }

                this.songName = value;
            }
        }

        public int Minutes
        {
            get
            {
                return this.minutes;
            }

            set
            {
                if (value< 0 || value> 14)
                {
                    throw new InvalidSongMinutesException();
                }

                this.minutes = value;
            }
        }
    }
}
