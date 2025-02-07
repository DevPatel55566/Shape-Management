using System;
using System.Collections.Generic;
using ConsoleTables;
using A1DevPatel;

class Program
{
    static List<Circle> circles = new List<Circle>();

    static void Main()
    {
        Console.WriteLine("Assignment#1 - Dev Patel");
        Console.WriteLine("Assignment#2 - ID 991740023");
        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("1. Add Shape");
            Console.WriteLine("2. Edit Shape");
            Console.WriteLine("3. Delete Shape");
            Console.WriteLine("4. View Shapes");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddCircleMenu();
                    break;
                case "2":
                    EditCircleMenu();
                    break;
                case "3":
                    DeleteCircleMenu();
                    break;
                case "4":
                    ViewCircles();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void AddCircleMenu()
    {
        Console.Clear();
        Console.WriteLine("\nChoose Shape");
        Console.WriteLine("1. Add Circle");
        Console.WriteLine("5. Return to Main Menu");
        Console.Write("Enter your choice: ");

        if (Console.ReadLine() == "1")
        {
            Console.Write("Enter radius of Circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter opacity (0-1): ");
            double opacity = Convert.ToDouble(Console.ReadLine());

            Circle circle = new Circle(radius, opacity);
            circles.Add(circle);

            Console.WriteLine("\nNew Circle Added!");
            ViewCircles();
        }
    }

    static void EditCircleMenu()
    {
        Console.Clear();
        Console.WriteLine("\nEdit Shape");
        Console.WriteLine("1. Edit Circle");
        Console.WriteLine("5. Back to Main Menu");
        Console.Write("Enter your choice: ");

        if (Console.ReadLine() == "1")
        {
            ViewCircles();

            Console.Write("\nEnter the ID of the Circle to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Circle circle = circles.Find(c => c.ShapeId == id);

            if (circle != null)
            {
                Console.Write("Enter new radius: ");
                double newRadius = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter new opacity (0-1): ");
                circle.Opacity = Convert.ToDouble(Console.ReadLine());

                circles.Remove(circle);
                circles.Add(new Circle(newRadius, circle.Opacity));

                Console.WriteLine("\nCircle Updated!");
                ViewCircles();
            }
            else
            {
                Console.WriteLine("Circle not found.");
            }
        }
    }

    static void DeleteCircleMenu()
    {
        Console.Clear();
        Console.WriteLine("\nDelete Shape");
        Console.WriteLine("1. Delete Circle");
        Console.WriteLine("5. Back to Main Menu");
        Console.Write("Enter your choice: ");

        if (Console.ReadLine() == "1")
        {
            ViewCircles();

            Console.Write("\nEnter the ID of the Circle to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Circle circle = circles.Find(c => c.ShapeId == id);

            if (circle != null)
            {
                circles.Remove(circle);
                Console.WriteLine("\nCircle Deleted!");
                ViewCircles();
            }
            else
            {
                Console.WriteLine("Circle not found.");
            }
        }
    }

    static void ViewCircles()
    {
        Console.Clear();
        Console.WriteLine("\nCircles:");

        if (circles.Count == 0)
        {
            Console.WriteLine("No circles available.");
        }
        else
        {
            var table = new ConsoleTable("ID", "Radius", "Opacity", "Area", "Perimeter");

            foreach (var circle in circles)
            {
                table.AddRow(circle.ShapeId, circle.Radius, circle.Opacity, circle.GetArea().ToString("F2"), circle.GetPerimeter().ToString("F2"));
            }

            table.Write();
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
