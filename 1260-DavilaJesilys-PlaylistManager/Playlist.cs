////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Playlist Manager
// File Name: Playlist.cs
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
using System.Text;
using System.Threading.Tasks;

namespace _1260_DavilaJesilys_PlaylistManager
{
    public class Playlist : SongList
    {
        public Playlist(string title) : base(title) {}

        /// <summary>
        /// Shuffles the songs in the playlist randomly.
        /// </summary>
        public void Shuffle()
        {
            Random random = new Random();
            Songs = Songs.OrderBy(song => random.Next()).ToList();
        }

        /// <summary>
        /// Displays all songs in the playlist.
        /// </summary>
        public void DisplayAllSongs()
        {
            Console.WriteLine(Title);
            if (Songs.Count == 0 )
            {
                Console.WriteLine("The playlist is empty.");
            } else
            {
                foreach (var song in Songs)
                {
                    Console.WriteLine(song);
                }
            }
        }

        /// <summary>
        /// Displays detailed information about the playlist.
        /// </summary>
        public override void DisplayDetails()
        {
            Console.WriteLine($"Playlist: {Title}");
            Console.WriteLine($"Total Runtime: {TotalRuntime} minutes");
        }
    }
}
