/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - Circle class representing a circle
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
    /// Define a public class named "Circle" that inherits from a class called "Shape."
    /// </summary>
    public class Circle : Shape
    {
        private double radius; // Declare a private field to store the radius of the circle.

        /// <summary>
        /// Constructor for the Circle class.
        /// </summary>
        public Circle() 
        {
            Type = "Circle"; // Set the "Type" property to "Circle" when an instance of the Circle class is created.
        }

        /// <summary>
        /// Override the CalculateVolume method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume() 
        {
            return 0; // Circles are 2D shapes, so volume is not applicable and is set to 0.
        }

        /// <summary>
        /// Override the CalculateArea method from the base class.
        /// </summary>
        /// <returns>Calculated area</returns>
        public override double CalculateArea() 
        {
            return Math.PI * Math.Pow(radius, 2); // Calculate and return the area of the circle.
        }

        /// <summary>
        /// Override the SetData method from the base class.
        /// </summary>
        public override void SetData()
        {
            // Prompts the user to enter the radius for the current shape.
            Console.Write("Enter the radius: ");

            if (double.TryParse(Console.ReadLine(), out radius)) // Read user input and try to parse it as a double, storing the result in the "radius" field.
            {
                return; // Exit the method if the radius input is successfully parsed.
            }

            Console.WriteLine("Invalid input. Please enter valid dimensions."); // Display an error message for invalid input.
            SetData(); // Recursively call SetData to retry input if it's invalid.
        }

        /// <summary>
        /// Override the ToString method from the base class.
        /// </summary>
        /// <returns>String representation of this class</returns>
        public override string ToString() 
        {
            return string.Format("{0, -20} {1, -19} {2, -17:0.00} {3, -10:0.00}",
                Type, // The shape's type.
                radius, // The radius of the circle.
                CalculateArea(), // The area of the circle.
                CalculateVolume()); // The volume (set to 0 for circles).
        }
    }
}
