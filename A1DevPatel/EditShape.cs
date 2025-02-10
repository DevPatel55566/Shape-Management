using System;
using System.Collections.Generic;
using System.Linq;

namespace A1DevPatel
{
    class EditShape
    {
        public static void EditShapeMenu()
        {
            Console.Clear();
            Console.WriteLine("\tChoose a Shape to Edit\n");
            Console.WriteLine("\t1. Edit Circle");
            Console.WriteLine("\t2. Edit Rectangle");
            Console.WriteLine("\t3. Edit Triangle");
            Console.WriteLine("\t4. Edit Square");
            Console.WriteLine("\t5. Return to main menu\n");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    EditShapeByType<Circle>();
                    break;
                case "2":
                    EditShapeByType<Rectangle>();
                    break;
                case "3":
                    EditShapeByType<Triangle>();
                    break;
                case "4":
                    EditShapeByType<Square>();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    Console.ReadKey();
                    EditShapeMenu();
                    break;
            }
        }

        private static void EditShapeByType<T>() where T : Shape
        {
            try
            {
                ViewShape.ViewShapesByType<T>();
                Console.Write("Enter ID to edit: ");

                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Shape shape = Program.shapes.OfType<T>().FirstOrDefault(s => s.ShapeId == id);
                    if (shape != null)
                    {
                        UpdateShapeProperties(shape);
                        Console.WriteLine($"{typeof(T).Name} updated!");
                    }
                    else
                    {
                        Console.WriteLine($"{typeof(T).Name} not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            ViewShape.ViewShapesByType<T>();
            Console.ReadKey();
            EditShapeMenu();
        }

        private static void UpdateShapeProperties(Shape shape)
        {
            switch (shape)
            {
                case Square square:
                    square.Side = AddShape.GetDoubleInput("Enter new side of Square: ");
                    break;
                case Circle circle:
                    circle.Radius = AddShape.GetDoubleInput("Enter new radius of Circle: ");
                    break;
                case Rectangle rectangle:
                    rectangle.Length = AddShape.GetDoubleInput("Enter new length of Rectangle: ");
                    rectangle.Width = AddShape.GetDoubleInput("Enter new width of Rectangle: ");
                    break;
                case Triangle triangle:
                    triangle.SideA = AddShape.GetDoubleInput("Enter new Side A of Triangle: ");
                    triangle.SideB = AddShape.GetDoubleInput("Enter new Side B of Triangle: ");
                    triangle.SideC = AddShape.GetDoubleInput("Enter new Side C of Triangle: ");
                    break;
            }
            shape.Opacity = AddShape.GetOpacityValue();
        }
    }
}