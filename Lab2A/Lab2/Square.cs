/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - Square class representing square
 * I, Sukhmanjeet Singh, 000838215 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */

using System;  // Import the System namespace, which contains fundamental classes and base classes for various data types.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    public class Square : Box
    {
        private double length; // Declare a private field to store the length of the square

        public Square()
        {
            Type = "Square";
        }

        /// <summary>
        /// Override the CalculateVolume method from the base class
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume()
        {
            return 0; // Squares are 2D, so volume is not applicable.
        }

        /// <summary>
        /// Override the CalculateArea method from base class
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return length * length; // Calculate and return the area of square
        }

        /// <summary>
        /// Override the SetData method from the base class.
        /// </summary>
        public override void SetData()
        {
            // prompts the user to enter each dimension for the current shape
            Console.Write("Enter the length: ");
            if (double.TryParse(Console.ReadLine(), out length)) // Read the input from user and try to parse it as double, storing the value in the "length"
            {
                return; // If parse succeeds exit the program
            }
            Console.Write("Invalid input. Please enter valid dimensions."); // Display an error message for invalid input.
            SetData(); // Retry this method
        }

        /// <summary>
        /// Override the ToString method from the base class
        /// </summary>
        /// <returns>String representation of this class</returns>
        public override string ToString()
        {
            return string.Format("{0, -20} {1, -19} {2, -17:0.00} {3, -10:0.00}",
                Type, // The shape's type.
                length, // The shape's length.
                CalculateArea(), // The shape's surface area.
                CalculateVolume()); // The shap's volumn.
        }
    }
}
