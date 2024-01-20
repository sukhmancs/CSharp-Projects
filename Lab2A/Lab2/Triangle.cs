/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - Triangle class representing a triangle
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
    /// Define a public class named "Triangle" that inherits from a class called "Shape."
    /// </summary>
    public class Triangle : Shape 
    {
        private double length; // Declare a private field to store the length of the triangle's base.
        private double height; // Declare a private field to store the height of the triangle.

        /// <summary>
        /// Constructor for the Triangle class.
        /// </summary>
        public Triangle() 
        {
            Type = "Triangle"; // Set the "Type" property to "Triangle" when an instance of the Triangle class is created.
        }

        /// <summary>
        /// Override the CalculateVolume method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume() 
        {
            return 0; // Triangles are 2D shapes, so volume is not applicable and is set to 0.
        }

        /// <summary>
        /// Override the CalculateArea method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea() 
        {
            return length * height / 2; // Calculate and return the area of the triangle.
        }

        /// <summary>
        /// Override the SetData method from the base class.
        /// </summary>
        public override void SetData() 
        {
            // Prompts the user to enter the dimensions for the current shape.
            Console.Write("Enter the base: ");

            if (double.TryParse(Console.ReadLine(), out length)) // Read user input and try to parse it as a double, storing the result in the "length" field.
            {
                Console.Write("Enter the height: ");
                if (double.TryParse(Console.ReadLine(), out height)) // Read user input for the height and store it in the "height" field.
                {
                    return; // Exit the method if both base and height input are successfully parsed.
                }
            }

            Console.WriteLine("Invalid input. Please enter valid input."); // Display an error message for invalid input.
            SetData(); // Recursively call SetData to retry input if it's invalid.
        }

        /// <summary>
        /// Override the ToString method from the base class.
        /// </summary>
        /// <returns>The string representation of this class</returns>
        public override string ToString()
        {
            string dimensions = $"{length} x {height}"; // Combine the base and height into a string to represent dimensions.

            return string.Format("{0, -20} {1, -19} {2, -17:0.00} {3, -10:0.00}",
                Type, // The shape's type.
                dimensions, // The dimensions of the triangle.
                CalculateArea(), // The area of the triangle.
                CalculateVolume()); // The volume (set to 0 for triangles).
        }
    }
}
