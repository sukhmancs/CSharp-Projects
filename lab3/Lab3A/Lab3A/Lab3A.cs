/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 28, 2023
 * Program's purpose - The main class of this project
 * I, Sukhmanjeet Singh, 000838215, certify that this material is my original work. No other person's work has been used without due acknowledgment.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab3A  // Declare a namespace called Lab3A to organize code
{
    /// <summary>
    /// Main class of this project
    /// </summary>
    public class Lab3A
    {
        // Store up to 100 searchable media objects into an array 
        private const int maxMediaCount = 100; // Represents the number of array objects
        private static Media[] mediaObjects = new Media[maxMediaCount];
        private static int mediaCount = 0; // Intialize to zero
        public static void ReadData(string filePath)
        {
            try
            {
                // read the Data.txt file line by line (it creates an array of strings/one line represent a string)
                string[] lines = File.ReadAllLines(filePath);
                int lineNumber = 0; // Intialize current line number;

                // Go through all the lines one by one
                foreach (string line in lines)
                {
                    string[] words = line.Split('|'); // Split line to array of strings (or words)

                    // Check if there are at least three elements in the line
                    if (words.Length >= 3) 
                    {
                        
                        // Get the type of media, i.e. book, song, movie
                        string mediaName = words[0].Trim().ToUpper();

                        // Check the media type and create respective media objects
                        switch (mediaName) 
                        {                            
                            case "BOOK":

                                // Create a Book object if the maximum count of media
                                if (mediaCount < maxMediaCount)
                                {
                                    // Extract details for a book (title, year, author, summary)
                                    string title = words.Length > 1 ? words[1].Trim() : "";
                                    int year = words.Length > 2 ? int.Parse(words[2].Trim()) : 0;
                                    string author = words.Length > 3 ? words[3].Trim() : "";
                                    string summary = line.StartsWith("BOOK|") ? lines[lineNumber + 1].Trim() : "";
                                    
                                    // Create a new Book object and add it to the mediaObjects array
                                    mediaObjects[mediaCount] = new Book(title, year, author, summary);                                    
                                }
                                else
                                {
                                    Console.WriteLine("Max media objects reached.");
                                }
                                break;

                            case "SONG":

                                // Create a Song object if the maximum count of media
                                if (mediaCount < maxMediaCount)
                                {
                                    // Extract details for a book (title, year, album, artist)
                                    string title = words.Length > 1 ? words[1].Trim() : "";
                                    int year = words.Length > 2 ? int.Parse(words[2].Trim()) : 0;
                                    string album = words.Length > 3 ? words[3].Trim() : "";
                                    string artist = words.Length > 4 ? words[4].Trim() : "";

                                    // Create a new Song object and add it to the mediaObjects array
                                    mediaObjects[mediaCount] = new Song(title, year, artist, album);
                                }
                                else
                                {
                                    Console.WriteLine("Max media objects reached.");
                                }
                                break;

                            case "MOVIE":

                                // Create a Movie object if the maximum count of media
                                if (mediaCount < maxMediaCount)
                                {
                                    // Extract details for a book (title, year, Director, summary)
                                    string title = words.Length > 1 ? words[1].Trim() : "";
                                    int year = words.Length > 2 ? int.Parse(words[2].Trim()) : 0;
                                    string director = words.Length > 3 ? words[3].Trim() : "";
                                    string summary = line.StartsWith("MOVIE|") ? lines[lineNumber + 1].Trim() : "";

                                    // Create a new Movie object and add it to the mediaObjects array
                                    mediaObjects[mediaCount] = new Movie(title, year, director, summary);
                                }
                                else // Otherwise
                                {
                                    Console.WriteLine("Max media objects reached.");
                                }
                                break;

                            default:
                                Console.WriteLine("Unkown Media: " + mediaName);
                                break;

                        }

                        mediaCount++;   // Increase mediaCount by one on each object creation                     
                    }
                    lineNumber++;   // Increase lineNumber by one to represent the current line of data.txt in this loop
                }
            }
            catch (FileNotFoundException)  // If file does not exist
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }

        }

        /// <summary>
        /// Method to list media based on type
        /// </summary>
        /// <param name="type"></param>
        private static void ListMediaByType(Type type)
        {
            foreach (var media in mediaObjects)  // Go over all the mediaObjects
            {
                // Check if media object is present and it is of the same type
                if (media != null && media.GetType() == type)
                {
                    // Display the media object
                    Console.WriteLine(media);
                }
            }
        }

        /// <summary>
        /// List all the books
        /// </summary>
        public static void listAllBooks()
        {
            ListMediaByType(typeof(Book));
        }

        /// <summary>
        /// List all the Songs
        /// </summary>
        public static void listAllSongs()
        {
            ListMediaByType(typeof(Song));
        }

        /// <summary>
        /// List all the movies
        /// </summary>
        public static void listAllMovies()
        {
            ListMediaByType(typeof(Movie));
        }

        /// <summary>
        /// List all the media
        /// </summary>
        public static void listAllMedia()
        {
            foreach (var media in mediaObjects)  // Go over all the mediaObjects stored
            {
                if (media != null) // If it is not null
                {
                    // Display all available media objects
                    if (media is Book book)
                    {                        
                        Console.WriteLine($"{media},     Book Summary: {book.Summary}");
                    }
                    else if (media is Movie movie)
                    {
                        Console.WriteLine($"{media},     Movie Summary: {movie.Summary}");
                    }
                    else if (media is Song song)
                    {
                        Console.WriteLine(media);
                    }
                }
            }

        }

        /// <summary>
        /// Search All Media by Title
        /// </summary>
        /// <param name="key"></param>
        public static void searchAllMediaByTitle(string key)
        {
            foreach (var media in mediaObjects)
            {
                // Make sure media object is not null and the key is present media object's title property
                if (media != null && media.Title.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    // Display media objects that contain the provided title key
                    Console.WriteLine(media);
                }                               
            }
        }

        /// <summary>
        /// Main method of this class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ReadData("C:\\Users\\Norts\\source\\repos\\Lab3A\\Lab3A\\Data.txt"); // Process the data.

            bool exit = false; // Set intially to not exit
            while (!exit) // As long as user does not exit
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. List All Books");
                Console.WriteLine("2. List All Movies");
                Console.WriteLine("3. List All Songs");
                Console.WriteLine("4. List All Media");
                Console.WriteLine("5. Search All Media by Title");
                Console.WriteLine("6. Exit Program");

                Console.Write("Enter your choice: ");  // Prompt user for their choice                

                // Read the user input and try to parse it as int, storing the result in the "choice".
                if (int.TryParse(Console.ReadLine(), out int choice))   
                {
                    switch (choice)
                    {
                        case 1:
                            listAllBooks();  // Call method to list all books
                            break;
                        case 2:                            
                            listAllMovies(); // Call method to list all movies
                            break;
                        case 3:
                            listAllSongs();  // Call method to list all songs
                            break;
                        case 4:
                            listAllMedia();  // Call method to list all media
                            break;
                        case 5:
                            Console.WriteLine("Please enter the search key: "); // Ask the user to enter the search key
                            string searchKey = Console.ReadLine();
                            searchAllMediaByTitle(searchKey);  // Call method to search media by title using search key
                            break;
                        case 6:
                            exit = true; // Set the flag to true to exit the program
                            break;
                        default:  // Otherwise
                            Console.WriteLine("Invalid choice. Please try again."); // Inform the user of invalid choice
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer between 1 to 6."); // Invalid input
                }
            }
        }
    }
}
