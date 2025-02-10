using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1DevPatel
{
    class RemoveShape
    {
        public static void RemoveShapes()
        {
            Console.Clear(); // clears the console 
            Program.Header(); // displays header containing id and name 
            Console.WriteLine("\n\tDelete Shape\n");
            Console.WriteLine("\t1. Delete Circle");
            Console.WriteLine("\t2. Delete Triangle");
            Console.WriteLine("\t3. Delete Rectangle");
            Console.WriteLine("\t4. Delete Square");
            Console.WriteLine("\t5. Back to main menu\n");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    DeleteShapesByCategory<Circle>(); // this will remove circle
                    break;
                case "2":
                    DeleteShapesByCategory<Triangle>();//this will remove triangle
                    break;
                case "3":
                    DeleteShapesByCategory<Rectangle>();//this will remove rectangle 
                    break;
                case "4":
                    DeleteShapesByCategory<Square>();//this will remove square
                    break;
                case "5":
                    return; //return to main menu
                default:
                    Console.WriteLine("Invalid \nPress any key to continue");//If you enter something wrong this will pop up and you have to print correct value
                    Console.ReadKey();
                    RemoveShapes();
                    break;
            }
        }

        private static void DeleteShapesByCategory<T>() where T : Shape // Method to remove each shape accordingly to the option selected
        {
            try
            {
                DisplayShape.DisplayShapesByCategory<T>();
                Console.Write("Enter ID to delete: ");

                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Shape shape = Program.Shapes.OfType<T>().First(s => s.ShapeId == id);
                    if (shape != null)
                    {
                        Program.Shapes.Remove(shape);
                        Console.WriteLine($"{typeof(T).Name} deleted!");
                    }
                    else
                    {
                        Console.WriteLine($"{typeof(T).Name} not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID entered.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            DisplayShape.DisplayShapesByCategory<T>();
            Console.ReadKey();
            RemoveShapes();
        }
    }
}
