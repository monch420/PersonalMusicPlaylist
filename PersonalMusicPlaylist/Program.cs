using System;
using System.Collections.Generic;
using PlaylistBL;
using static System.Reflection.Metadata.BlobBuilder;

namespace MusicPlaylistFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist PersonalPlaylist = new Playlist();

            Song FirstSong = new Song();
            FirstSong.title = "DIFFERENT DAY";
            FirstSong.artist = "Playboi Carti";
            FirstSong.album = "I AM MUSIC";
            FirstSong.duration = "2:48";

            PersonalPlaylist.AddSong(FirstSong);     //ADDS A SONG IN THE PLAYLIST

            Song SecondSong = new Song();
            SecondSong.title = "I KNOW ?";
            SecondSong.artist = "Travis Scott";
            SecondSong.album = "UTOPIA";
            SecondSong.duration = "3:31";

            PersonalPlaylist.AddSong(SecondSong);     //ADDS A SONG IN THE PLAYLIST

            Song ThirdSong = new Song();
            ThirdSong.title = "If We Being Real";
            ThirdSong.artist = "Yeat";
            ThirdSong.album = "2093";
            ThirdSong.duration = "2:52";

            PersonalPlaylist.AddSong(ThirdSong);     //ADDS A SONG IN THE PLAYLIST

            Console.WriteLine("PERSONAL PLAYLIST");
            Console.WriteLine("\n--------------------\n" + FirstSong.artist + " - " + FirstSong.title);
            Console.WriteLine(SecondSong.artist + " - " + SecondSong.title);
            Console.WriteLine(ThirdSong.artist + " - " + ThirdSong.title + "\n--------------------\n");
            Console.WriteLine("COMMANDS \n1. PLAY SONG \n2. DISPLAY PLAYLIST INFORMATION \n3. REMOVE SONG\n \nENTER COMMAND: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("\n--------------------\n\nENTER SONG TITLE: ");
                string songTitle = Console.ReadLine();

                bool found = PersonalPlaylist.PlaySong(songTitle);     //PLAYS A SONG FROM THE PLAYLIST

                if (found)
                {
                    Console.WriteLine("\n♫ NOW PLAYING...... \n\n--------------------\n");
                }
                else
                {
                    Console.WriteLine("\nSONG NOT FOUND");
                }
            }
            else if (choice == 2)
            {
                DisplayPlaylistInfo(PersonalPlaylist.songs);     //DISPLAYS EACH SONG'S INFORMATION IN THE PLAYLIST
            }
            else if (choice == 3)
            {
                Console.Write("\n--------------------\n\nWHICH SONG WOULD YOU LIKE TO REMOVE?\n\n--------------------\n\nDIFFERENT DAY \nI KNOW ? \nIf We Being Real\n\n--------------------\n\nENTER TITLE: ");
                string songTitle = Console.ReadLine();
                PersonalPlaylist.RemoveSong(songTitle);     //REMOVES A SONG FROM THE PLAYLIST
                DisplayPlaylistInfo(PersonalPlaylist.songs);
            }
            else { Console.WriteLine("INVALID CHOICE. TRY AGAIN");
            }
        }

        public static void DisplayPlaylistInfo(List<Song> songs)
        {
            foreach (var Song in songs)
            {
                Console.WriteLine($"\n--------------------\nTITLE: {Song.title} \nARTIST: {Song.artist} \nALBUM: {Song.album} \nDURATION: {Song.duration} \n--------------------\n");
            }
        }
    }
}


