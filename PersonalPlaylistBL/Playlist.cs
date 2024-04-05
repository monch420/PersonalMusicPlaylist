using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistBL
{
    public class Playlist
    {
        public string name;
        public List<Song> songs = new List<Song>();

        public bool PlaySong(String songTitle)     //PLAYS A SONG FROM THE PLAYLIST
        {
            bool songfound = new bool();
            foreach (var Song in songs)
            {
                if (Song.title.Equals(songTitle, StringComparison.OrdinalIgnoreCase))
                {
                    songfound = true;
                    break;
                }
                else
                {
                    songfound = false;
                }
            }
            return songfound;
        }

        public void AddSong(Song song)     //ADDS A SONG IN THE PLAYLIST
        {
            songs.Add(song);
        }

        public void RemoveSong(String choiceRemove)     //REMOVES A SONG FROM THE PLAYLIST
        {
            foreach (var Song in songs)
            {
                if (Song.title.Equals(choiceRemove, StringComparison.OrdinalIgnoreCase))
                {
                    songs.Remove(Song);
                    break;
                }
                else
                {

                }
            }
        }

    }
}