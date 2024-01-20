/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - Ellipse class representing an ellipse
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
    /// Define a public class named "Ellipse" that inherits from a class called "Shape."
    /// </summary>
    public class Ellipse : Shape 
    {
        private double semiMajorAxis; // Declare a private field to store the length of the semi-major axis.
        private double semiMinorAxis; // Declare a private field to store the length of the semi-minor axis.

        /// <summary>
        /// Constructor for the Ellipse class.
        /// </summary>
        public Ellipse() 
        {
            Type = "Ellipse"; // Set the "Type" property to "Ellipse" when an instance of the Ellipse class is created.
        }

        /// <summary>
        /// Override the CalculateVolume method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateVolume() 
        {
            return 4 / 3 * Math.PI * Math.Pow(semiMinorAxis, 2) * semiMajorAxis; // Calculate and return the volume of the ellipse.
        }

        /// <summary>
        /// Override the CalculateArea method from the base class.
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea() 
        {
            return Math.PI * semiMinorAxis * semiMajorAxis; // Calculate and return the surface area of the ellipse.
        }

        /// <summary>
        /// Override the SetData method from the base class.
        /// </summary>
        public override void SetData() 
        {
            // Prompts the user to enter the dimensions for the current shape.
            Console.Write("Enter the length: ");

            if (double.TryParse(Console.ReadLine(), out semiMinorAxis)) // Read user input and try to parse it as a double, storing the result in the "semiMinorAxis" field.
            {
                Console.Write("Enter the height: ");
                if (double.TryParse(Console.ReadLine(), out semiMajorAxis)) // Read user input for the height and store it in the "semiMajorAxis" field.
                {
                    return; // Exit the method if both semi-minor and semi-major axis input are successfully parsed.
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
            string dimensions = $"{semiMinorAxis} x {semiMajorAxis}"; // Combine the semi-minor and semi-major axes into a string to represent dimensions.

            return string.Format("{0, -20} {1, -19} {2, -17:0.00} {3, -10:0.00}",
                Type, // The shape's type.
                dimensions, // The dimensions of the ellipse.
                CalculateArea(), // The surface area of the ellipse.
                CalculateVolume()); // The volume of the ellipse.
        }
    }
}
