/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - Box class representing a box
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
    /// Define a public class named "Box" that inherits from a class called "Shape."
    /// </summary>
    public class Box : Shape 
    {
        private double length; // Declare a private field to store the length of the box.
        private double width; // Declare a private field to store the width of the box.
        private double height; // Declare a private field to store the height of the box.

        /// <summary>
        /// Constructor for the Box class.
        /// </summary>
        public Box() 
        {
            Type = "Box"; // Set the "Type" property to "Box" when an instance of the Box class is created.
        }

        /// <summary>
        /// Override the CalculateVolume method from the base class.
        /// </summary>
        /// <returns>The calculated volume</returns>
        public override double CalculateVolume() 
        {
            return length * width * height; // Calculate and return the volume of the box.
        }

        /// <summary>
        /// Override the CalculateArea method from the base class.
        /// </summary>
        /// <returns>The calculated area</returns>
        public override double CalculateArea() 
        {
            return length * width * height; // Calculate and return the surface area of the box, which is also the volume for a box.
        }

        /// <summary>
        /// Override the SetData method from the base class.
        /// </summary>
        public override void SetData() 
        {
            // Prompts the user to enter the dimensions for the current shape.
            Console.Write("Enter the length: ");

            if (double.TryParse(Console.ReadLine(), out length)) // Read user input for the length and try to parse it as a double, storing the result in the "length" field.
            {
                Console.Write("Enter the width: ");
                if (double.TryParse(Console.ReadLine(), out width)) // Read user input for the width and store it in the "width" field.
                {
                    Console.Write("Enter the height: ");
                    if (double.TryParse(Console.ReadLine(), out height)) // Read user input for the height and store it in the "height" field.
                    {
                        return; // Exit the method if all dimensions are successfully parsed.
                    };
                };
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
            string dimensions = $"{length} x {width} x {height}"; // Combine the dimensions into a string to represent the box's size.

            return string.Format("{0, -20} {1, -19} {2, -17:0.00} {3, -10:0.00}",
                Type, // The shape's type.
                dimensions, // The dimensions of the box.
                CalculateArea(), // The surface area of the box (also the volume).
                CalculateVolume()); // The volume of the box (same as the surface area for a box).
        }
    }
}
