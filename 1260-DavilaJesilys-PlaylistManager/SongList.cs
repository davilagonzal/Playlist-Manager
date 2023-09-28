////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Playlist Manager
// File Name: SongList.cs
// Description: The songlist class represents one song file that the user creates.
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
    /// <summary>
    /// Represents a list of songs.
    /// </summary>
    public abstract class SongList
    {
        /// <summary>
        /// Gets or sets the list of songs in the song list.
        /// </summary>
        public List<Song> Songs { get; set; }
        public string Title { get; set; }
        public double TotalRuntime { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the SongList class.
        /// </summary>
        /// <param name="title"></param>
        public SongList(string title)
        {
            Title = title;
            Songs = new List<Song>();
            TotalRuntime = 0;
        }

        /// <summary>
        /// Adds a song to the song list.
        /// </summary>
        /// <param name="song"></param>
        public void AddSong(Song song)
        {
            Songs.Add(song);
            TotalRuntime += song.Duration;
        }

        /// <summary>
        /// Removes a song from the song list.
        /// </summary>
        /// <param name="song"></param>
        public void RemoveSong(Song song)
        {
            if (Songs.Contains(song))
            {
                Songs.Remove(song);
                TotalRuntime -= song.Duration;
            }
        }

        /// <summary>
        /// Retrieves a song from the song list by its index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>The song at the specific index, or null if invalid</returns>
        public Song GetSongByIndex(int index)
        {
            if (index >= 0 && index < Songs.Count)
            { return Songs[index]; }
            return null;
        }

        /// <summary>
        /// ABstract method to display details of the song list( to be implemented by the child class)
        /// </summary>
        public abstract void DisplayDetails();
    }
}
