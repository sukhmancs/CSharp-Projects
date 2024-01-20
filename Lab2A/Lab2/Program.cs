/* 
 * Name - Sukhmanjeet Singh
 * Student ID - 000838215
 * Date - October 10, 2023
 * Program's purpose - A console app that list various shapes according to user's input 
 * I, Sukhmanjeet Singh, 000838215 certify that this material is my original work. No other person's work has been used without due acknowledgement.
 */

using Lab2A;
using System;
using System.Collections.Generic;

namespace Lab2A  // Declare a namespace called "Lab2A" to contain the code.
{
    /// <summary>
    /// Main program class
    /// </summary>
    class Program
    {
        static List<Shape> shapes = new List<Shape>();  // Create a list to store shapes.

        /// <summary>
        /// The main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool exit = false; // Set the loop condition

            while (!exit) // When not exit
            {               
                Console.WriteLine("Sukhman's Geometry Class:\n" +
                    "A - Rectangle     E - Ellipse     I - Triangle\n" +
                    "B - Square        F - Circle      J - Tetrahedron\n" +
                    "C - Box           G - Cylinder\n" +
                    "D - Cube          H - Sphere");
                Console.WriteLine("K. Exit");
                Console.Write("Select an option: ");

                // Read the user input and try to parse it as char, storing the result in the "choice".
                if (char.TryParse(Console.ReadLine().Trim().ToUpper(), out char choice))
                {
                    switch (choice)
                    {
                        case 'A':
                            shapes.Add(CreateRectangle());  // Create a rectangle and add it to the list.
                            break;
                        case 'B':
                            shapes.Add(CreateSquare()); // Create a square and add it to the list.
                            break;
                        case 'C':
                            shapes.Add(CreateBox()); // Create a box and add it to the list.
                            break;
                        case 'D':
                            shapes.Add(CreateCube()); // Create a cube and add it to the list.
                            break;
                        case 'E':
                            shapes.Add(CreateEllipse()); // Create a ellipse and add it to the list.
                            break;
                        case 'F':
                            shapes.Add(CreateCircle()); // Create a circle and add it to the list.
                            break;
                        case 'G':
                            shapes.Add(CreateCylinder()); // Create a cylinder and add it to the list.
                            break;
                        case 'H':
                            shapes.Add(CreateSphere()); // Create a sphere and add it to the list.
                            break;
                        case 'I':
                            shapes.Add(CreateTriangle()); // Create a triangle and add it to the list.
                            break;
                        case 'J':
                            shapes.Add(CreateTetrahedron()); // Create a tetrahedron and add it to the list.
                            break;
                        case 'K': // Otherwise exit the program
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again."); // Prompt the user for invalid choice.
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an alphabet."); // Prompt the user if user enters a value other than a alphabet.
                }
            }

            DisplayShapes(); // Dislpay shapes
        }

        /// <summary>
        /// Create rectangle
        /// </summary>
        /// <returns>A rectangle object</returns>
        static Rectangle CreateRectangle()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetData();
            return rectangle;
        }

        /// <summary>
        /// Create square
        /// </summary>
        /// <returns>A square object</returns>
        static Square CreateSquare()
        {
            Square square = new Square();
            square.SetData();
            return square;
        }

        /// <summary>
        /// Create box
        /// </summary>
        /// <returns>A box object</returns>
        static Box CreateBox()
        {
            Box box = new Box();
            box.SetData();
            return box;
        }

        /// <summary>
        /// Create cube
        /// </summary>
        /// <returns>A cube object</returns>
        static Cube CreateCube()
        {
            Cube cube = new Cube();
            cube.SetData();
            return cube;
        }

        /// <summary>
        /// Create ellipse
        /// </summary>
        /// <returns>An ellipse object</returns>
        static Ellipse CreateEllipse()
        {
            Ellipse ellipse = new Ellipse();
            ellipse.SetData();
            return ellipse;
        }

        /// <summary>
        /// Create circle
        /// </summary>
        /// <returns>A circle object</returns>
        static Circle CreateCircle()
        {
            Circle circle = new Circle();
            circle.SetData();
            return circle;
        }

        /// <summary>
        /// Create cylinder
        /// </summary>
        /// <returns>A cylinder object</returns>
        static Cylinder CreateCylinder()
        {
            Cylinder cylinder = new Cylinder();
            cylinder.SetData();
            return cylinder;
        }

        /// <summary>
        /// Create sphere
        /// </summary>
        /// <returns>A sphere object</returns>
        static Sphere CreateSphere()
        {
            Sphere sphere = new Sphere();
            sphere.SetData();
            return sphere;
        }

        /// <summary>
        /// Create triangle
        /// </summary>
        /// <returns>A triangle object</returns>
        static Triangle CreateTriangle()
        {
            Triangle triangle = new Triangle();
            triangle.SetData();
            return triangle;
        }

        /// <summary>
        /// Create tetrahedron
        /// </summary>
        /// <returns>A tetrahedron object</returns>
        static Tetrahedron CreateTetrahedron()
        {
            Tetrahedron tetrahedron = new Tetrahedron();
            tetrahedron.SetData();
            return tetrahedron;
        }

        /// <summary>
        /// List all the shapes to the screen
        /// </summary>
        static void DisplayShapes()
        {
            Console.WriteLine("\nList of Shapes:");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Type\t\t     Dimensions\t\t Area\t\t  Volume");
            Console.WriteLine("----------------------------------------------------------------");

            // Count the number of shapes. 
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Total Shapes: {shapes.Count}");
        }
    }
}
