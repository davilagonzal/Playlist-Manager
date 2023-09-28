////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Playlist Manager
// File Name: Song.cs
// Description: This is where the created songs get stored.
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
    /// <summary>
    /// Represents a song.
    /// </summary>
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre Genre { get; set; }
        public Album Album { get; set; }

        /// <summary>
        /// Initializes a new instance of the Song class.
        /// </summary>
        /// <param name="title">Title of song</param>
        /// <param name="artist">Artist of song</param>
        /// <param name="duration">Duration of the song in minutes</param>
        /// <param name="genre">Genre of the song</param>
        /// <param name="album">Album to the song belongs to</param>
        public Song(string title, string artist, double duration, Genre genre, Album album = null)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
            Album = album;
        }

        /// <summary>
        /// Returns a string representing the song.
        /// </summary>
        /// <returns>A string containing song details.</returns>
        public override string ToString() 
        {
            return $"{Title} by {Artist} ({Duration} minutes, Genre: {Genre})";
        }
    }
}
