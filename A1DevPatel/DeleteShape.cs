using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1DevPatel
{
    class DeleteShape
    {
        public static void DeleteShapeMenu()
        {
            Console.Clear();
            Console.WriteLine("\tChoose a Shape to Delete\n");
            Console.WriteLine("\t1. Delete Circle");
            Console.WriteLine("\t2. Delete Rectangle");
            Console.WriteLine("\t3. Delete Triangle");
            Console.WriteLine("\t4. Delete Square");
            Console.WriteLine("\t5. Return to main menu\n");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DeleteCircle();
                    break;
                case "2":
                    DeleteRectangle();
                    break;
                case "3":
                    DeleteTriangle();
                    break;
                case "4":
                    DeleteSquare();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }

        static void DeleteCircle()
        {
            try
            {
                Console.Write("Enter ID to Delete: ");
                ViewShape.ViewShapesByType<Circle>();
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Circle circle = Program.shapes.Find(s => s.ShapeId == id) as Circle;
                    if (circle != null)
                    {
                        Program.shapes.Remove(circle);
                        Console.WriteLine("Circle deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Circle not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID entered. Please enter a numeric ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the circle: {ex.Message}");
            }
            ViewShape.ViewShapesByType<Circle>();
            Console.ReadKey();
            DeleteShapeMenu();
        }

        static void DeleteRectangle()
        {
            try
            {
                Console.Write("Enter ID to Delete: ");
                ViewShape.ViewShapesByType<Rectangle>();

                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Rectangle rectangle = Program.shapes.Find(s => s.ShapeId == id) as Rectangle;
                    if (rectangle != null)
                    {
                        Program.shapes.Remove(rectangle);
                        Console.WriteLine("Rectangle deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Rectangle not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID entered. Please enter a numeric ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the rectangle: {ex.Message}");
            }
            ViewShape.ViewShapesByType<Rectangle>();
            Console.ReadKey();
            DeleteShapeMenu();
        }

        static void DeleteTriangle()
        {
            try
            {
                Console.Write("Enter ID to Delete: ");
                ViewShape.ViewShapesByType<Triangle>();
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Triangle triangle = Program.shapes.Find(s => s.ShapeId == id) as Triangle;
                    if (triangle != null)
                    {
                        Program.shapes.Remove(triangle);
                        Console.WriteLine("Triangle deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Triangle not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID entered. Please enter a numeric ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the triangle: {ex.Message}");
            }
            ViewShape.ViewShapesByType<Triangle>();
            Console.ReadKey();
            DeleteShapeMenu();
        }

        static void DeleteSquare()
        {
            try
            {
                Console.Write("Enter ID to Delete: ");
                ViewShape.ViewShapesByType<Square>();
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Square square = Program.shapes.Find(s => s.ShapeId == id) as Square;
                    if (square != null)
                    {
                        Program.shapes.Remove(square);
                        Console.WriteLine("Square deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Square not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID entered. Please enter a numeric ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the square: {ex.Message}");
            }
            ViewShape.ViewShapesByType<Square>();
            Console.ReadKey();
            DeleteShapeMenu();
        }
    }
}
