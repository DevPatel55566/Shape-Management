using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1DevPatel
{
    class AddShape
    {
        public static void AddShapeMenu()
        {
            Console.Clear();
            Console.WriteLine("\tAdd Shape\n");
            Console.WriteLine("\t1. Add Circle");
            Console.WriteLine("\t2. Add Rectangle");
            Console.WriteLine("\t3. Add Triangle");
            Console.WriteLine("\t4. Add Square");
            Console.WriteLine("\t5. Return to main menu\n");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddCircle();
                    break;
                case "2":
                    AddRectangle();
                    break;
                case "3":
                    AddTriangle();
                    break;
                case "4":
                    AddSquare();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }

        static void AddCircle()
        {
            try
            {
                double radius = ValidUserInput("Enter radius of Circle: ");
                double opacity = ValidOpacityInput();
                Circle circle = new Circle(Program.nextShapeId++, radius, opacity);
                Program.shapes.Add(circle);

                Console.WriteLine("\nNew Circle Added!");
                ViewShape.ViewShapesByType<Circle>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error : {ex.Message}");
            }
            AddShapeMenu(); // Return to Add Shape menu
        }

        static void AddRectangle()
        {
            try
            {
                double length = ValidUserInput("Enter length of rectangle: ");
                double width = ValidUserInput("Enter width of rectangle: ");
                double opacity = ValidOpacityInput();
                Rectangle rectangle = new Rectangle(Program.nextShapeId++, length, width, opacity);
                Program.shapes.Add(rectangle);

                Console.WriteLine("\nNew Rectangle Added!");
                ViewShape.ViewShapesByType<Rectangle>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            AddShapeMenu(); // Return to Add Shape menu
        }

        static void AddTriangle()
        {
            try
            {
                double sideA = ValidUserInput("Enter 1st side of triangle: ");
                double sideB = ValidUserInput("Enter 2nd side of triangle: ");
                double sideC = ValidUserInput("Enter 3rd side of triangle: ");
                double opacity = ValidOpacityInput();
                Triangle triangle = new Triangle(Program.nextShapeId++, sideA, sideB, sideC, opacity);
                Program.shapes.Add(triangle);

                Console.WriteLine("\nNew Triangle Added!");
                ViewShape.ViewShapesByType<Triangle>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            AddShapeMenu(); 
        }

        static void AddSquare()
        {
            try
            {
                double side = ValidUserInput("Enter the side of square: ");
                double opacity = ValidOpacityInput();
                Square square = new Square(Program.nextShapeId++, side, opacity);
                Program.shapes.Add(square);

                Console.WriteLine("\nNew Square Added!");
                ViewShape.ViewShapesByType<Square>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error : {ex.Message}");
            }
            AddShapeMenu(); 
        }

        public static double ValidUserInput(string prompt = "Enter a number: ")
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value;

                Console.WriteLine("Invalid ");
            }
        }

        public static double ValidOpacityInput(string prompt = "Enter opacity (0-1): ")
        {
            double opacity;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out opacity) && opacity >= 0 && opacity <= 1)
                    return opacity;

                Console.WriteLine("Invalid ");
            }
        }
    }
}
