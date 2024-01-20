/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - Cube class representing a cube
 * I, Sukhmanjeet Singh, 000838215, certify that this material is my original work. No other person's work has been used without due acknowledgment.
 */

using System; // Import the System namespace, which contains fundamental classes and base classes for various data types.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A // Declare a namespace called "Lab2A" to contain the code.
{
    /// <summary>
    /// Define a public class named "Cube" that inherits from a class called "Shape."
    /// </summary>
    public class Cube : Shape 
    {
        private double length; // Declare a private field to store the length of the cube's edges.

        /// <summary>
        /// Constructor for the Cube class.
        /// </summary>
        public Cube() 
        {
            Type = "Cube"; // Set the "Type" property to "Cube" when an instance of the Cube class is created.
        }

        /// <summary>
        /// Override the CalculateVolume method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume() 
        {
            return Math.Pow(length, 3); // Calculate and return the volume of the cube.
        }

        /// <summary>
        /// Override the CalculateArea method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea() 
        {
            return 6 * Math.Pow(length, 2); // Calculate and return the surface area of the cube.
        }

        /// <summary>
        /// Override the SetData method from the base class.
        /// </summary>
        public override void SetData() 
        {
            // Prompts the user to enter the length of the cube's edges.
            Console.Write("Enter the length: ");

            if (double.TryParse(Console.ReadLine(), out length)) // Read user input and try to parse it as a double, storing the result in the "length" field.
            {
                return; // Exit the method if parsing is successful.
            }

            Console.WriteLine("Invalid input. Please enter valid dimensions."); // Display an error message for invalid input.
            SetData(); // Recursively call SetData to retry input if it's invalid.
        }

        /// <summary>
        /// Override the ToString method from the base class.
        /// </summary>
        /// <returns>The string representation of this class</returns>
        public override string ToString() 
        {
            return string.Format("{0, -20} {1, -19} {2, -17:0.00} {3, -10:0.00}",
                Type, // The shape's type.
                length, // The length of the cube's edges.
                CalculateArea(), // The surface area of the cube.
                CalculateVolume()); // The volume of the cube.
        }
    }
}
