/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 28, 2023
 * Program's purpose - Class to represent book
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
    /// Class to represent song that inherits from Media and uses interface IEcryptable
    /// </summary>
    public class Book : Media, IEncryptable
    {
        // Properties to store author and summary of the book
        public string Author { get; set; }
        public string Summary { get; set; }

        /// <summary>
        /// Constructor that initializes a Book object
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="author"></param>
        /// <param name="summary"></param>
        public Book(string title, int year, string author, string summary) : base(title, year)
        {           
            Author = author;
            Summary = summary;
            Decrypt(); // Decrypt Summary
        }

        /// <summary>
        /// Encrypt method to perform Rot13 encryption
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
            return Summary;  // Return the encrypted summary
        }

        /// <summary>
        /// Decrypt method to perform Rot13 decryption
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
            // Format and return the Book details as a string
            return string.Format("Title: {0, -60}, Author: {1, -30}, Year: {2, -4}", Title, Author, Year);
        }

    }
}
