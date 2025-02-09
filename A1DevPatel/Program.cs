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

        SampleData();
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

    static void SampleData()
    {
        shapes.Add(new Circle(nextShapeId++, 5, 0.8));
        shapes.Add(new Rectangle(nextShapeId++, 4, 6, 0.7));
        shapes.Add(new Triangle(nextShapeId++, 3, 4, 5, 0.6));
        shapes.Add(new Square(nextShapeId++, 4, 0.9));
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
        double radius = ValidUserInput("Enter radius of Circle: ");

        double opacity = ValidOpacityInput();

        Circle circle = new Circle(nextShapeId++, radius, opacity);
        shapes.Add(circle);

        // Show shapes list after adding a circle
        Console.WriteLine("\nNew Circle Added!");
        ViewShapesByType<Circle>();
        AddShapeMenu(); // Return to Add Shape menu
    }

    static void AddRectangle()
    {
        double length = ValidUserInput("Enter length of rectangle: ");

        double width = ValidUserInput("Enter width of rectangle: ");

        double opacity = ValidOpacityInput();

        Rectangle rectangle = new Rectangle(nextShapeId++, length, width, opacity);
        shapes.Add(rectangle);

        // Show shapes list after adding a rectangle
        //ViewShapes();
        Console.WriteLine("\nNew Rectangle Added!");
        ViewShapesByType<Rectangle>();
        AddShapeMenu(); // Return to Add Shape menu
    }

    static void AddTriangle()
    {
        double sideA = ValidUserInput("Enter 1st side of triangle: ");

        double sideB = ValidUserInput("Enter 2nd side of triangle: ");

        double sideC = ValidUserInput("Enter 3rd side of triangle: ");

        double opacity = ValidOpacityInput();

        Triangle triangle = new Triangle(nextShapeId++, sideA, sideB, sideC, opacity);
        shapes.Add(triangle);

        // Show shapes list after adding a triangle
        Console.WriteLine("\nNew Triangle Added!");
        ViewShapesByType<Triangle>();
        AddShapeMenu(); // Return to Add Shape menu
    }

    static void AddSquare()
    {
        double side = ValidUserInput("Enter the side of square: ");

        double opacity = ValidOpacityInput();

        Square square = new Square(nextShapeId++, side, opacity);
        shapes.Add(square);

        // Show shapes list after adding a square
        Console.WriteLine("\nNew Rectangle Added!");
        ViewShapesByType<Square>();
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
        Console.WriteLine("\t5. Return to main menu\n\n");
        Console.WriteLine("Note: Shape ID cannot be edited. It must remain unique.");

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
            ViewShapesByType<Circle>();
            // Console.ReadKey();
            Console.Write("Enter ID to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Circle circle = shapes.Find(s => s.ShapeId == id) as Circle;
            if (circle != null)
            {
                double radius = ValidUserInput("Enter new radius of Circle: ");

                double opacity = ValidOpacityInput();
                Console.WriteLine("Circle updated!");
            }
            else
            {
                Console.WriteLine("Circle with this ID not found!");
            }

            ViewShapesByType<Circle>();
            Console.ReadKey();
            EditShapeMenu();
        }

        static void EditRectangle()
        {
            ViewShapesByType<Rectangle>();

            Console.Write("Enter ID to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Rectangle rectangle = shapes.Find(s => s.ShapeId == id) as Rectangle;
            if (rectangle != null)
            {
                double length = ValidUserInput("Enter new length of rectangle: ");
                double width = ValidUserInput("Enter width of rectangle: ");
                double opacity = ValidOpacityInput();
                Console.WriteLine("Rectangle updated!");
            }
            else
            {
                Console.WriteLine("Rectangle with this ID not found!");
            }
            ViewShapesByType<Rectangle>();

            Console.ReadKey();
            EditShapeMenu();
        }

        static void EditTriangle()
        {
            ViewShapesByType<Triangle>();
            Console.Write("Enter ID to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Triangle triangle = shapes.Find(s => s.ShapeId == id) as Triangle;
            if (triangle != null)
            {
                double sideA = ValidUserInput("Enter sideA of triangle: ");

                double sideB = ValidUserInput("Enter sideB of triangle: ");

                double sideC = ValidUserInput("Enter sideC of triangle: ");

                double opacity = ValidOpacityInput();
                Console.WriteLine("Triangle updated!");
            }
            else
            {
                Console.WriteLine("Triangle with this ID not found!");
            }

            ViewShapesByType<Triangle>();
            EditShapeMenu();
            Console.ReadKey();
        }

        static void EditSquare()
        {
            ViewShapesByType<Square>();
            Console.Write("Enter ID to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Square square = shapes.Find(s => s.ShapeId == id) as Square;
            if (square != null)
            {
                double side = ValidUserInput("Enter side of Square: ");

                double opacity = ValidOpacityInput();
                Console.WriteLine("Square updated!");
            }
            else
            {
                Console.WriteLine("Square with this ID not found!");
            }
            ViewShapesByType<Square>();

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
        Console.WriteLine("\t5. Return to main menu");
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
            ViewShapesByType<Circle>();
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
            ViewShapesByType<Rectangle>();
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
            ViewShapesByType<Triangle>();

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
            ViewShapesByType<Square>();

            Console.ReadKey();
            DeleteShapeMenu();
        }
    }

    static double ValidUserInput(string prompt = "Enter a number: ")
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                return value;

            Console.WriteLine("Invalid input! Please enter a positive number.");
        }
    }

    static double ValidOpacityInput(string prompt = "Enter opacity (0-1): ")
    {
        double opacity;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out opacity) && opacity >= 0 && opacity <= 1)
                return opacity;

            Console.WriteLine("Invalid input! Please enter a value between 0 and 1.");
        }
    }


    static void ViewShapes()
    {
        //Console.Clear();
        Console.WriteLine("\nAll Shapes:");

        var table = new ConsoleTable("ID", "Shape", "Dimensions", "Opacity", "Area", "Perimeter");

        foreach (var shape in shapes)
        {
            string dimensions = shape switch
            {
                Square s => $"s={s.Side:F2}",
                Circle c => $"r={c.Radius:F2}",
                Rectangle r => $"l={r.Length:F2}, w={r.Width:F2}",
                Triangle t => $"a={t.SideA:F2}, b={t.SideB:F2}, c={t.SideC:F2}",
                _ => "Unknown"
            };

            table.AddRow(
                shape.ShapeId,
                shape.GetType().Name,
                dimensions,
                $"{shape.Opacity:P2}",
                $"{shape.GetArea():F2}",
                $"{shape.GetPerimeter():F2}"
            );
        }

        if (shapes.Count == 0)
        {
            Console.WriteLine("No shapes found.");
        }
        else
        {
            table.Write();
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    static void ViewShapesByType<T>() where T : Shape
    {
        //Console.Clear();
        string shapeName = typeof(T).Name;
        var filteredShapes = shapes.OfType<T>().ToList(); // Filter shapes of specific type

        if (!filteredShapes.Any())
        {
            Console.WriteLine($"No {shapeName}s found.");
        }
        else
        {
            Console.WriteLine($"\nList of {shapeName}s:");
            var table = new ConsoleTable("ID", "Dimensions", "Opacity", "Area", "Perimeter");

            foreach (var shape in filteredShapes)
            {
                string dimensions = shape switch
                {
                    Square s => $"s={s.Side:F2}",
                    Circle c => $"r={c.Radius:F2}",
                    Rectangle r => $"l={r.Length:F2}, w={r.Width:F2}",
                    Triangle t => $"a={t.SideA:F2}, b={t.SideB:F2}, c={t.SideC:F2}",
                    _ => "Unknown"
                };

                table.AddRow(
                    shape.ShapeId,
                    dimensions,
                    $"{shape.Opacity:P2}",
                    $"{shape.GetArea():F2}",
                    $"{shape.GetPerimeter():F2}"
                );
            }
            table.Write();
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }



    static void Header()
    {
        Console.WriteLine("Assignment#1 - Dev Patel");
        Console.WriteLine("Assignment#2 - ID 991740023");
        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
    }
}