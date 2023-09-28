////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Playlist Manager
// File Name: Program.cs
// Description: The Program is where the interaction between the user and the program happen.
// Course: CSCI 1260-002 – Introduction to Computer Science II
// Author: Jessi Davila, davilagonzal@etsu.edu, East Tennessee State University
// Created: Monday, September 18, 2023
// Copyright: Jesilys Davila, 2023
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////

namespace _1260_DavilaJesilys_PlaylistManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Playlist myPlaylist = new Playlist("My Favorite Songs"); //Creates a new playlist.

            Console.WriteLine("Welcome to the Playlist Mangager Program");
            Console.WriteLine("To get started - How many albums do you want to create:");
            int numberOfAlbums = int.Parse(Console.ReadLine());
            Album album = null;

            //Create albulms base on the user input
            for (int i = 0; i < numberOfAlbums; i++)
            {
                Console.WriteLine($"Create album {i + 1}:");
                Console.Write("Enter album title: ");
                string albumTitle = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter artist name: ");
                string artistName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter release date (yyyy-mm-dd): ");
                DateTime releaseDate = DateTime.Parse(Console.ReadLine());
                album = new Album(albumTitle, artistName, releaseDate);
                Console.WriteLine();

                // Allow the user to add songs to the album
                while (true)
                {
                    album.AddSongToAlbum();
                    Console.Write("Add another song to the album? (yes/no): ");
                    string addAnother = Console.ReadLine();
                    if (addAnother.ToLower() != "yes")
                    {
                        break;
                    }
                }

                // Display album details
                album.DisplayDetails();
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Playlist Management Program:");
                Console.WriteLine("1. Add song");
                Console.WriteLine("2. Remove song");
                Console.WriteLine("3. Retrieve song by index");
                Console.WriteLine("4. Display entire playlist");
                Console.WriteLine("5. Shuffle playlist");
                Console.WriteLine("6. Display detailed information");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Available songs:");
                        for (int i = 0; i < album.Songs.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {album.Songs[i]}");
                        }
                        Console.Write("Enter the song number to add: ");
                        int songIndex = int.Parse(Console.ReadLine()) - 1;
                        if (songIndex >= 0 && songIndex < album.Songs.Count)
                        {
                            myPlaylist.AddSong(album.Songs[songIndex]);
                            Console.WriteLine("Song added to playlist.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid song number.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Current playlist:");
                        myPlaylist.DisplayAllSongs();
                        Console.Write("Enter the song number to remove: ");
                        int removeIndex = int.Parse(Console.ReadLine()) - 1;
                        if (removeIndex >= 0 && removeIndex < myPlaylist.Songs.Count)
                        {
                            myPlaylist.RemoveSong(myPlaylist.Songs[removeIndex]);
                            Console.WriteLine("Song removed from playlist.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid song number.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter the index of the song to retrieve: ");
                        int retrieveIndex = int.Parse(Console.ReadLine());
                        Song retrievedSong = myPlaylist.GetSongByIndex(retrieveIndex - 1);
                        if (retrievedSong != null)
                        {
                            Console.WriteLine(retrievedSong);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index.");
                        }
                        break;

                    case 4:
                        myPlaylist.DisplayAllSongs();
                        break;

                    case 5:
                        myPlaylist.Shuffle();
                        Console.WriteLine("Playlist shuffled.");
                        break;

                    case 6:
                        Console.WriteLine("Select an option:");
                        Console.WriteLine("1. Display playlist details");
                        Console.WriteLine("2. Display album details");
                        Console.Write("Enter your choice: ");
                        int detailsChoice = int.Parse(Console.ReadLine());
                        if (detailsChoice == 1)
                        {
                            myPlaylist.DisplayDetails();
                        }
                        else if (detailsChoice == 2)
                        {
                            album.DisplayDetails();
                        }
                        break;

                    case 7:
                        Console.WriteLine("Thank you for using my Playlist Manager");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}