////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Playlist Manager
// File Name: Album.cs
// Description: This is a child class of SongList.
// Course: CSCI 1260-002 – Introduction to Computer Science II
// Author: Jessi Davila, davilagonzal@etsu.edu, East Tennessee State University
// Created: Monday, September 18, 2023
// Copyright: Jesilys Davila, 2023
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1260_DavilaJesilys_PlaylistManager
{
    public class Album : SongList
    {
        public string Artist { get; set; }
        public List<string> BandMembers { get; set; }
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the album class.
        /// </summary>
        /// <param name="title">Title of album</param>
        /// <param name="artist">Artist of the album</param>
        /// <param name="releaseDate">Release date of the album</param>
        public Album(string title, string artist, DateTime releaseDate) : base(title)
        {
            Artist = artist;
            ReleaseDate = releaseDate;
            BandMembers = new List<string>();
        }

        /// <summary>
        /// Method to add a song to the album.
        /// </summary>
        public void AddSongToAlbum()
        {
            Console.WriteLine("Add a song to the album:");
            Console.Write("Enter song title: ");
            string songTitle = Console.ReadLine();
            Console.Write("Enter artist: ");
            string songArtist = Console.ReadLine();
            Console.Write("Enter duration (minutes): ");
            double songDuration = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose a genre:");
            for (int i = 0; i < Enum.GetNames(typeof(Genre)).Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Enum.GetName(typeof(Genre), i)}");
            }
            Console.Write("Enter genre number: ");
            int genreChoice = int.Parse(Console.ReadLine()) - 1;
            Genre songGenre = (Genre)genreChoice;

            // Create the song and add it to the album
            Song song = new Song(songTitle, songArtist, songDuration, songGenre);
            AddSong(song);
            Console.WriteLine("Song added to the album.");
        }

        /// <summary>
        /// Displays detailed information about the album
        /// </summary>
        public override void DisplayDetails()
        {
            Console.WriteLine($"Album: {Title}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Release Date: {ReleaseDate.ToShortDateString()}");
            Console.WriteLine($"Band Members: {string.Join(", ", BandMembers)}");
            Console.WriteLine($"Total Runtime: {TotalRuntime} mins");
        }
    }
}
