/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - Sphere class representing sphere
 * I, Sukhmanjeet Singh, 000838215 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */

using System; // Import the System namespace, which contains fundamental classes and base classes for various data types.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A // Declare a namespace called "Lab2" to contain the code.
{
    /// <summary>
    /// Define a public class named "Sphere" that inherits from a class called "Shape."
    /// </summary>
    public class Sphere : Shape 
    {
        private double radius; // Declare a private field to store the radius of the sphere.

        /// <summary>
        /// Constructor for the Sphere class.
        /// </summary>
        public Sphere() 
        {
            Type = "Sphere"; // Set the "Type" property to "Sphere" when an instance of the Sphere class is created.
        }

        /// <summary>
        /// Override the CalculateVolume method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume() 
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3); // Calculate and return the volume of the sphere.
        }

        /// <summary>
        /// Override the CalculateArea method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea() 
        {
            return 4 * Math.PI * radius; // Calculate and return the surface area of the sphere.
        }

        /// <summary>
        /// Override the SetData method from the base class.
        /// </summary>
        public override void SetData() 
        {
            // Prompts the user to enter the radius for the sphere.
            Console.Write("Enter the radius: ");

            if (double.TryParse(Console.ReadLine(), out radius)) // Read user input and try to parse it as a double, storing the result in the "radius" field.
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
                radius, // The radius of the sphere.
                CalculateArea(), // The surface area of the sphere.
                CalculateVolume()); // The volume of the sphere.
        }
    }
}
