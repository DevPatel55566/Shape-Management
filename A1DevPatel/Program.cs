using System;
using System.Collections.Generic;
using System.Linq; 
using A1DevPatel;
using ConsoleTables;

class Program
{
    public static List<Shape> shapes = new List<Shape>();
    public static int nextShapeId = 1;

    static void Main()
    {
        SampleData();
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Assignment #1 - Dev Patel");
            Console.WriteLine("Assignment #1 - ID 991740023");
            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");

            Console.WriteLine("\tMain Menu\n");
            Console.WriteLine("\t1. Add Shape");
            Console.WriteLine("\t2. Edit Shape");
            Console.WriteLine("\t3. Delete Shape");
            Console.WriteLine("\t4. View Shapes");

            Console.WriteLine("\t5. Exit\n");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            if (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("Invalid ");
                Console.ReadKey();
                continue;
            }

            switch (choice)
            {
                case "1":
                    AddShape.AddShapeMenu();
                    break;
                case "2":
                    EditShape.EditShapeMenu();
                    break;
                case "3":
                    DeleteShape.DeleteShapeMenu();
                    break;
                case "4":
                    ViewShape.ViewShapes();
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
}