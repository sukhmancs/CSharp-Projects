/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 28, 2023
 * Program's purpose - Class to represent song
 * I, Sukhmanjeet Singh, 000838215, certify that this material is my original work. No other person's work has been used without due acknowledgment.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A  // Declare a namespace called "Lab3A" to contain the code.
{
    /// <summary>
    /// Class to represent song that inherits from Media
    /// </summary>
    public class Song : Media
    {
        // Properties to store Album and Artist of the Song
        public string Album { get; set; }  // Album property
        public string Artist { get; set; }  // Artist property

        /// <summary>
        /// Constructor of this class
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="artist"></param>
        /// <param name="album"></param>
        public Song(string title, int year, string artist, string album) : base(title, year)
        {
            Album = album; 
            Artist = artist;
        }

        /// <summary>
        /// Override ToString method to represent the Book object as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Title: {0, -60}, Artist: {1, -30}, Year: {2, -10}, Album: {3, -4}", Title, Artist, Year, Album);

        }
    }
}
