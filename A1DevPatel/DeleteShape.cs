using System;
using System.Collections.Generic;

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
            Console.WriteLine("\t5. Return to main menu");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DeleteShapeByType<Circle>();
                    break;
                case "2":
                    DeleteShapeByType<Rectangle>();
                    break;
                case "3":
                    DeleteShapeByType<Triangle>();
                    break;
                case "4":
                    DeleteShapeByType<Square>();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }

        private static void DeleteShapeByType<T>() where T : Shape
        {
            try
            {
                ViewShape.ViewShapesByType<T>();
                Console.Write("Enter ID to Delete: ");

                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Shape shape = Program.shapes.Find(s => s.ShapeId == id && s is T);
                    if (shape != null)
                    {
                        Program.shapes.Remove(shape);
                        Console.WriteLine($"{typeof(T).Name} deleted!");
                    }
                    else
                    {
                        Console.WriteLine($"{typeof(T).Name} not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID entered. Please enter a numeric ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the shape: {ex.Message}");
            }

            ViewShape.ViewShapesByType<T>();
            Console.ReadKey();
            DeleteShapeMenu();
        }
    }
}
