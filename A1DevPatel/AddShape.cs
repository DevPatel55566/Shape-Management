using System;
using System.Collections.Generic;

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
            Console.WriteLine("\t5. Back to main menu\n");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddShapeToList<Circle>();
                    break;
                case "2":
                    AddShapeToList<Rectangle>();
                    break;
                case "3":
                    AddShapeToList<Triangle>();
                    break;
                case "4":
                    AddShapeToList<Square>();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        private static void AddShapeToList<T>() where T : Shape
        {
            try
            {
                double opacity = GetOpacityValue();

                Shape newShape = typeof(T) switch
                {
                    Type t when t == typeof(Circle) => new Circle(Program.nextShapeId++, GetDoubleInput("Enter radius: "), opacity),
                    Type t when t == typeof(Rectangle) => new Rectangle(Program.nextShapeId++, GetDoubleInput("Enter length: "), GetDoubleInput("Enter width: "), opacity),
                    Type t when t == typeof(Triangle) => new Triangle(Program.nextShapeId++, GetDoubleInput("Enter 1st side: "), GetDoubleInput("Enter 2nd side: "), GetDoubleInput("Enter 3rd side: "), opacity),
                    Type t when t == typeof(Square) => new Square(Program.nextShapeId++, GetDoubleInput("Enter side: "), opacity),
                    _ => throw new InvalidOperationException("Invalid shape type.")
                };

                Program.shapes.Add(newShape);
                Console.WriteLine($"\nNew {typeof(T).Name} Added!");
                ViewShape.ViewShapesByType<T>();
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            AddShapeMenu();
        }

        public static double GetDoubleInput(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value;

                Console.WriteLine("Invalid input, please enter a positive number.");
            }
        }

        public static double GetOpacityValue(string prompt = "Enter opacity: ")
        {
            double opacity;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out opacity) && opacity >= 0 && opacity <= 1)
                    return opacity;

                Console.WriteLine("Invalid,\n opacity must be between 0 and 1.");
            }
        }
    }
}
