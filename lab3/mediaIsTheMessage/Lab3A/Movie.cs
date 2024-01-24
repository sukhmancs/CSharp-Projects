/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 28, 2023
 * Program's purpose - class to represent movie
 * I, Sukhmanjeet Singh, 000838215, certify that this material is my original work. No other person's work has been used without due acknowledgment.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3A  // Declare a namespace called Lab3A to organize code
{

    /// <summary>
    /// Class to represent Movie that inherits from Media, IEncrytable
    /// </summary>
    public class Movie : Media, IEncryptable
    {
        // Properties to store Directory and summary of the Movie
        public string Director { get; set; }
        public string Summary { get; set; }

        /// <summary>
        /// Constructor of this class
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="director"></param>
        /// <param name="summary"></param>
        public Movie(string title, int year, string director, string summary) : base(title, year)
        {
            Director = director;
            Summary = summary;
            Decrypt(); // Decript Summary
        }

        /// <summary>
        /// Encrypt the summary of movie
        /// </summary>
        /// <returns></returns>
        public string Encrypt()
        {
            // Implement Rot13 encryption logic
            Summary = new string(Summary.Select(c => {
                if ((c >= 'a' && c <= 'm') || (c >= 'A' && c <= 'M'))
                    return (char)(c + 13);
                else if ((c >= 'n' && c <= 'z') || (c >= 'N' && c <= 'Z'))
                    return (char)(c - 13);
                else
                    return c;
            }).ToArray());
            return Summary;
        }

        /// <summary>
        /// Decrypt the summary of movie
        /// </summary>
        /// <returns></returns>
        public string Decrypt()
        {
            // Implement Rot13 decryption logic
            return Encrypt();
        }

        /// <summary>
        /// Override ToString method to represent the Book object as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Title: {0, -60}, Director: {1, -28}, Year: {2, -4}", Title, Director, Year);
        }
    }
}
