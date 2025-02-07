using System;
using System.Collections.Generic;
using ConsoleTables;
using A1DevPatel;

class Program
{
    static List<Shape> shapes = new List<Shape>();
    static int nextShapeId = 1;

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
                    AddShapeMenu();
                    break;
                case "2":
                    EditShapeMenu();
                    break;
                case "3":
                    DeleteShapeMenu();
                    break;
                case "4":
                    ViewShapes();
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

    static void AddShapeMenu()
    {
        Console.Clear();
        Console.WriteLine("\nChoose Shape to Add");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Triangle");
        Console.WriteLine("4. Square");
        Console.WriteLine("5. Return to Main Menu");
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
                Console.WriteLine("Invalid choice, try again.");
                break;
        }
    }

    static void AddCircle()
    {
        Console.Write("Enter radius of Circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter opacity (0-1): ");
        double opacity = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle(nextShapeId++, radius, opacity);
        shapes.Add(circle);

        // Show shapes list after adding a circle
        Console.WriteLine("\nNew Circle Added!");
        Console.WriteLine("Press any key to return to the Add Shape menu...");
        ViewShapes();
        Console.ReadKey();
        AddShapeMenu();  // Return to Add Shape menu
    }

    static void AddRectangle()
    {
        Console.Write("Enter length of Rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter width of Rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter opacity (0-1): ");
        double opacity = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(nextShapeId++, length, width, opacity);
        shapes.Add(rectangle);

        // Show shapes list after adding a rectangle
        ViewShapes();
        Console.WriteLine("\nNew Rectangle Added!");
        Console.WriteLine("Press any key to return to the Add Shape menu...");
        Console.ReadKey();
        AddShapeMenu();  // Return to Add Shape menu
    }

    static void AddTriangle()
    {
        Console.Write("Enter SideA of Triangle: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter SideB of Triangle: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter SideC of Triangle: ");
        double sideC = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter opacity (0-1): ");
        double opacity = Convert.ToDouble(Console.ReadLine());

        Triangle triangle = new Triangle(nextShapeId++, sideA, sideB, sideC, opacity);
        shapes.Add(triangle);

        // Show shapes list after adding a triangle
        ViewShapes();
        Console.WriteLine("\nNew Triangle Added!");
        Console.WriteLine("Press any key to return to the Add Shape menu...");
        Console.ReadKey();
        AddShapeMenu();  // Return to Add Shape menu
    }

    static void AddSquare()
    {
        Console.Write("Enter side of Square: ");
        double side = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter opacity (0-1): ");
        double opacity = Convert.ToDouble(Console.ReadLine());

        Square square = new Square(nextShapeId++, side, opacity);
        shapes.Add(square);

        // Show shapes list after adding a square
        ViewShapes();
        Console.WriteLine("\nNew Square Added!");
        Console.WriteLine("Press any key to return to the Add Shape menu...");
        Console.ReadKey();
        AddShapeMenu();  // Return to Add Shape menu
    }

    static void EditShapeMenu()
    {
        //Console.Clear();
        Console.WriteLine("\nEdit Shape");
        ViewShapes();
        Console.Write("Enter Shape ID to edit: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Shape shape = shapes.Find(s => s.ShapeId == id);
        if (shape == null)
        {
            Console.WriteLine("Shape not found!");
            return;
        }

        Console.WriteLine("Editing " + shape.GetType().Name);
        if (shape is Circle c)
        {
            Console.Write("Enter new radius: ");
            c.Radius = Convert.ToDouble(Console.ReadLine());
        }
        else if (shape is Rectangle r)
        {
            Console.Write("Enter new length: ");
            r.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter new width: ");
            r.Width = Convert.ToDouble(Console.ReadLine());
        }
        Console.Write("Enter new opacity (0-1): ");
        shape.Opacity = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Shape updated!");
        ViewShapes();
    }

    static void DeleteShapeMenu()
    {
        Console.Clear();
        Console.WriteLine("\nDelete Shape");
        ViewShapes();
        Console.Write("Enter Shape ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Shape shape = shapes.Find(s => s.ShapeId == id);
        if (shape == null)
        {
            Console.WriteLine("Shape not found!");
            return;
        }

        shapes.Remove(shape);
        Console.WriteLine("Shape deleted!");
        ViewShapes();
    }

    static void ViewShapes()
    {
        //Console.Clear();
        Console.WriteLine("\nShape Details:");

        var table = new ConsoleTable("ID", "Shape", "Dimensions", "Opacity", "Area", "Perimeter");

        foreach (var shape in shapes)
        {
            string dimensions = shape switch
            {
                Circle c => $"Radius: {c.Radius}",
                Rectangle r => $"{r.Length} x {r.Width}",
                Triangle t => $"{t.SideA}, {t.SideB}, {t.SideC}",
                _ => "Unknown"
            };

            table.AddRow(shape.ShapeId, shape.GetType().Name, dimensions, shape.Opacity, shape.GetArea(), shape.GetPerimeter());
        }

        table.Write();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
