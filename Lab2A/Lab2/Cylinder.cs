/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - Cylinder class representing a cylinder
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
    /// Define a public class named "Cylinder" that inherits from a class called "Shape."
    /// </summary>
    public class Cylinder : Shape 
    {
        private double radius; // Declare a private field to store the radius of the cylinder's base.
        private double height; // Declare a private field to store the height of the cylinder.

        public Cylinder() // Constructor for the Cylinder class.
        {
            Type = "Cylinder"; // Set the "Type" property to "Cylinder" when an instance of the Cylinder class is created.
        }

        /// <summary>
        /// Override the CalculateVolume method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume() 
        {
            return Math.PI * Math.Pow(radius, 2) * height; // Calculate and return the volume of the cylinder.
        }

        /// <summary>
        /// Override the CalculateArea method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea() 
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2); // Calculate and return the surface area of the cylinder.
        }

        /// <summary>
        /// Override the SetData method from the base class.
        /// </summary>
        public override void SetData() 
        {
            // Prompts the user to enter the dimensions for the current shape.
            Console.Write("Enter the radius: ");

            if (double.TryParse(Console.ReadLine(), out radius)) // Read user input and try to parse it as a double, storing the result in the "radius" field.
            {
                Console.Write("Enter the height: ");
                if (double.TryParse(Console.ReadLine(), out height)) // Read user input for the height and store it in the "height" field.
                {
                    return; // Exit the method if both radius and height input are successfully parsed.
                }
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
            string dimensions = $"{radius} x {height}"; // Combine the radius and height into a string to represent dimensions.

            return string.Format("{0, -20} {1, -19} {2, -17:0.00} {3, -10:0.00}",
                Type, // The shape's type.
                dimensions, // The dimensions of the cylinder.
                CalculateArea(), // The surface area of the cylinder.
                CalculateVolume()); // The volume of the cylinder.
        }
    }
}
