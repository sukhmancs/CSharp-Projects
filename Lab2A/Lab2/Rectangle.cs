/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - Rectangle class representing rectangle
 * I, Sukhmanjeet Singh, 000838215 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */

using System; // Import the System namespace, which contains fundamental classes and base classes for various data types.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A // Declare a namespace called "Lab2A" to contain the code.
{
    /// <summary>
    /// Define a public class named "Rectangle" that inherits from a class called "Box."
    /// </summary>
    public class Rectangle : Box 
    {
        private double length; // Declare a private field to store the length of the rectangle.
        private double height; // Declare a private field to store the height of the rectangle.

        /// <summary>
        /// Constructor for the Rectangle class.
        /// </summary>
        public Rectangle() 
        {
            Type = "Rectangle"; // Set the "Type" property to "Rectangle" when an instance of the Rectangle class is created.
        }

        /// <summary>
        /// Override the CalculateVolume method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume() 
        {
            return 0; // Rectangles are 2D shapes, so volume is not applicable and is set to 0.
        }

        /// <summary>
        /// Override the CalculateArea method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea() 
        {
            return length * height; // Calculate and return the area of the rectangle.
        }

        /// <summary>
        /// Override the SetData method from the base class.
        /// </summary>
        public override void SetData() 
        {
            // Prompts the user to enter the dimensions for the current shape.
            Console.Write("Enter the length: ");

            if (double.TryParse(Console.ReadLine(), out length)) // Read user input and try to parse it as a double, storing the result in the "length" field.
            {
                Console.Write("Enter the height: ");
                if (double.TryParse(Console.ReadLine(), out height)) // Read user input for the height and store it in the "height" field.
                {
                    return; // Exit the method if both length and height input are successfully parsed.
                };
            };

            Console.WriteLine("Invalid input. Please enter valid dimensions."); // Display an error message for invalid input.
            SetData(); // Recursively call SetData to retry input if it's invalid.
        }

        /// <summary>
        /// Override the ToString method from the base class.
        /// </summary>
        /// <returns>The string representation of this class</returns>
        public override string ToString() 
        {
            string dimensions = $"{length} x {height}"; // Combine the length and height into a string to represent dimensions.

            return string.Format("{0, -20} {1, -19} {2, -17:0.00} {3, -10:0.00}",
                Type, // The shape's type.
                dimensions, // The dimensions of the rectangle.
                CalculateArea(), // The area of the rectangle.
                CalculateVolume()); // The volume (set to 0 for rectangles).
        }
    }
}
