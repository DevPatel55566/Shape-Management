using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    EditCircle();
                    break;
                case "2":
                    EditRectangle();
                    break;
                case "3":
                    EditTriangle();
                    break;
                case "4":
                    EditSquare();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }

        static void EditCircle()
        {
            try
            {
                ViewShape.ViewShapesByType<Circle>();
                Console.Write("Enter ID to edit: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Circle circle = Program.shapes.Find(s => s.ShapeId == id) as Circle;
                    if (circle != null)
                    {
                        double radius = AddShape.ValidUserInput("Enter new radius of Circle: ");
                        double opacity = AddShape.ValidOpacityInput();
                        circle.Radius = radius;
                        circle.Opacity = opacity;
                        Console.WriteLine("Circle updated!");
                    }
                    else
                    {
                        Console.WriteLine("Circle not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            ViewShape.ViewShapesByType<Circle>();
            Console.ReadKey();
            EditShapeMenu();
        }

        static void EditRectangle()
        {
            try
            {
                ViewShape.ViewShapesByType<Rectangle>();
                Console.Write("Enter rectangle to edit: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Rectangle rectangle = Program.shapes.Find(s => s.ShapeId == id) as Rectangle;
                    if (rectangle != null)
                    {
                        double length = AddShape.ValidUserInput("Enter new length of rectangle: ");
                        double width = AddShape.ValidUserInput("Enter new width of rectangle: ");
                        rectangle.Length = length;
                        rectangle.Width = width;
                        rectangle.Opacity = AddShape.ValidOpacityInput();
                        Console.WriteLine("Rectangle updated!");
                    }
                    else
                    {
                        Console.WriteLine("Rectangle not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            ViewShape.ViewShapesByType<Rectangle>();
            Console.ReadKey();
            EditShapeMenu();
        }

        static void EditTriangle()
        {
            try
            {
                ViewShape.ViewShapesByType<Triangle>();
                Console.Write("Enter ID to edit: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Triangle triangle = Program.shapes.Find(s => s.ShapeId == id) as Triangle;
                    if (triangle != null)
                    {
                        double sideA = AddShape.ValidUserInput("Enter new sideA of triangle: ");
                        double sideB = AddShape.ValidUserInput("Enter new sideB of triangle: ");
                        double sideC = AddShape.ValidUserInput("Enter new sideC of triangle: ");
                        triangle.SideA = sideA;
                        triangle.SideB = sideB;
                        triangle.SideC = sideC;
                        triangle.Opacity = AddShape.ValidOpacityInput();
                        Console.WriteLine("Triangle updated!");
                    }
                    else
                    {
                        Console.WriteLine("Triangle not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            ViewShape.ViewShapesByType<Triangle>();
            Console.ReadKey();
            EditShapeMenu();
        }

        static void EditSquare()
        {
            try
            {
                ViewShape.ViewShapesByType<Square>();
                Console.Write("Enter ID to edit: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Square square = Program.shapes.Find(s => s.ShapeId == id) as Square;
                    if (square != null)
                    {
                        double side = AddShape.ValidUserInput("Enter new side of Square: ");
                        square.Side = side;
                        square.Opacity = AddShape.ValidOpacityInput();
                        Console.WriteLine("Square updated!");
                    }
                    else
                    {
                        Console.WriteLine("Square not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            ViewShape.ViewShapesByType<Square>();
            Console.ReadKey();
            EditShapeMenu();
        }
    }
}
