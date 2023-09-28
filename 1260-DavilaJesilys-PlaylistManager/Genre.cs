////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Playlist Manager
// File Name: Genre.cs
// Description: This is the category choices for the available Genre.
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
    /// Represents different music genres for use in the playlist manager.
    /// </summary>
    public enum Genre
    {
        Rock,          
        Pop,
        Jazz,
        Country,
        Classical,         
        Other             //Will represent an other or unknown music genre.
    }
}
