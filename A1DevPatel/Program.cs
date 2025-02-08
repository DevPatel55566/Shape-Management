using System;
using System.Collections.Generic;
using A1DevPatel;
using ConsoleTables;

class Program
{
    static List<Shape> shapes = new List<Shape>();
    static int nextShapeId = 1;

    static void Main()
    {


        bool running = true;
        while (running)
        {
            Console.Clear();
            Header();
            Console.WriteLine("\tMain Menu\n");
            Console.WriteLine("\t1. Add Shape");
            Console.WriteLine("\t2. Edit Shape");
            Console.WriteLine("\t3. Delete Shape");
            Console.WriteLine("\t4. View Shapes");
            Console.WriteLine("\t5. Exit");
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
        Header();
        Console.WriteLine("\tChoose a Shape to Add\n");
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
        ViewShapes();
        AddShapeMenu(); // Return to Add Shape menu
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
        //ViewShapes();
        Console.WriteLine("\nNew Rectangle Added!");
        ViewShapes();
        AddShapeMenu(); // Return to Add Shape menu
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
        Console.WriteLine("\nNew Triangle Added!");
        ViewShapes();
        AddShapeMenu(); // Return to Add Shape menu
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
        Console.WriteLine("\nNew Rectangle Added!");
        ViewShapes();
        AddShapeMenu(); // Return to Add Shape menu
    }

    static void EditShapeMenu()
    {
        Console.Clear();
        Header();
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
                Console.WriteLine("Invalid choice, try again.");
                break;
        }

        static void EditCircle()
        {
            ViewShapes();
            // Console.ReadKey();
            Console.Write("Enter ID to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Circle circle = shapes.Find(s => s.ShapeId == id) as Circle;
            if (circle != null)
            {
                Console.Write("Enter new radius: ");
                circle.Radius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter new opacity: ");
                circle.Opacity = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Circle updated!");
            }
            else
            {
                Console.WriteLine("Circle with this ID not found!");
            }

            ViewShapes();
            Console.ReadKey();
            EditShapeMenu();
        }

        static void EditRectangle()
        {
            Console.Write("Enter ID to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Rectangle rectangle = shapes.Find(s => s.ShapeId == id) as Rectangle;
            if (rectangle != null)
            {
                Console.Write("Enter new length: ");
                rectangle.Length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter new width: ");
                rectangle.Width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter new opacity: ");
                rectangle.Opacity = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Rectangle updated!");
            }
            else
            {
                Console.WriteLine("Rectangle with this ID not found!");
            }

            ViewShapes();
            Console.ReadKey();
            EditShapeMenu();
        }

        static void EditTriangle()
        {
            Console.Write("Enter ID to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Triangle triangle = shapes.Find(s => s.ShapeId == id) as Triangle;
            if (triangle != null)
            {
                Console.Write("Enter new SideA: ");
                triangle.SideA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter new SideB: ");
                triangle.SideB = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter new SideC: ");
                triangle.SideC = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter new opacity: ");
                triangle.Opacity = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Triangle updated!");
            }
            else
            {
                Console.WriteLine("Triangle with this ID not found!");
            }

            ViewShapes();
            EditShapeMenu();
            Console.ReadKey();
        }

        static void EditSquare()
        {
            Console.Write("Enter ID to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Square square = shapes.Find(s => s.ShapeId == id) as Square;
            if (square != null)
            {
                Console.Write("Enter new side: ");
                square.Side = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter new opacity: ");
                square.Opacity = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Square updated!");
            }
            else
            {
                Console.WriteLine("Square with this ID not found!");
            }

            ViewShapes();
            EditShapeMenu();
            Console.ReadKey();
        }

        Console.WriteLine("Shape updated!");
        ViewShapes();
        EditShapeMenu();
    }

    static void DeleteShapeMenu()
    {
        Console.Clear();
        Header();
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

        static void DeleteCircle()
        {
            Console.Write("Enter ID to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Circle circle = shapes.Find(s => s.ShapeId == id) as Circle;
            if (circle != null)
            {
                shapes.Remove(circle);
                Console.WriteLine("Circle deleted!");
            }
            else
            {
                Console.WriteLine("Circle not found!");
            }
            ViewShapes();
            Console.ReadKey();
            DeleteShapeMenu();
        }

        static void DeleteRectangle()
        {
            Console.Write("Enter ID to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Rectangle rectangle = shapes.Find(s => s.ShapeId == id) as Rectangle;
            if (rectangle != null)
            {
                shapes.Remove(rectangle);
                Console.WriteLine("Rectangle deleted!");
            }
            else
            {
                Console.WriteLine("Rectangle not found!");
            }
            ViewShapes();
            Console.ReadKey();
            DeleteShapeMenu();
        }

        static void DeleteTriangle()
        {
            Console.Write("Enter ID to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Triangle triangle = shapes.Find(s => s.ShapeId == id) as Triangle;
            if (triangle != null)
            {
                shapes.Remove(triangle);
                Console.WriteLine("Triangle deleted!");
            }
            else
            {
                Console.WriteLine("Triangle not found!");
            }
            ViewShapes();
            Console.ReadKey();
            DeleteShapeMenu();
        }

        static void DeleteSquare()
        {
            Console.Write("Enter ID to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Square square = shapes.Find(s => s.ShapeId == id) as Square;
            if (square != null)
            {
                shapes.Remove(square);
                Console.WriteLine("Square deleted!");
            }
            else
            {
                Console.WriteLine("Square not found!");
            }
            ViewShapes();
            Console.ReadKey();
            DeleteShapeMenu();
        }
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
                Circle c => $" {c.Radius}",
                Rectangle r => $"{r.Length} x {r.Width}",
                Triangle t => $"{t.SideA}, {t.SideB}, {t.SideC}",
                _ => "Unknown",
            };

            table.AddRow(
                shape.ShapeId,
                shape.GetType().Name,
                dimensions,
                shape.Opacity,
                shape.GetArea(),
                shape.GetPerimeter()
            );
        }

        table.Write();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void Header()
    {
        Console.WriteLine("Assignment#1 - Dev Patel");
        Console.WriteLine("Assignment#2 - ID 991740023");
        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
    }
}
