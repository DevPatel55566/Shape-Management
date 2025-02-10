using System;
using System.Collections.Generic;
using System.Linq;

namespace A1DevPatel
{
    class Program
    {
        public static List<Shape> Shapes = new List<Shape>();
        public static int NextShapeId = 1;//It will generate unique id for each shape

        static void Main()
        {
            InitializeSampleData(); // Will load the smaple data initialised 
            bool running = true;

            while (running)
            {
                Console.Clear();
                Header(); //It will print the header that contains id and name
                Console.WriteLine("\n\tMain Menu\n");
                Console.WriteLine("\t1. Add Shape");
                Console.WriteLine("\t2. Edit Shape");
                Console.WriteLine("\t3. Delete Shape");
                Console.WriteLine("\t4. View Shapes");
                Console.WriteLine("\t5. Exit\n");
                Console.Write("Enter your choice: ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddShape.AddShapes(); // This will go to the Add Shapes menu where you can add new shapes
                        break;
                    case "2":
                        ModifyShape.ModifyShapes();// This will go to the Modify Shapes menu where you can edit existing shapes
                        break;
                    case "3":
                        RemoveShape.RemoveShapes();// This will go to the Remove Shapes menu where you can remove existing shapes
                        break;
                    case "4":
                        DisplayShape.DisplayShapes(); // This will display all the shapes 
                        break;
                    case "5":
                        running = false; //This will close the application
                        break;
                    default:
                        Console.WriteLine("Invalid\nPress any key to continue"); //If you enter something wrong this will pop up and you have to print correct value
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void Header() //Header to print at the top of each page
        {
            Console.Clear();
            Console.WriteLine("Assignment #1 - Dev Patel");
            Console.WriteLine("Assignment #1 - ID 991740023");
            for (int i = 0; i < 50; i++) Console.Write("-+");
            Console.WriteLine();
        }

        static void InitializeSampleData() // Sample Data
        {
            Shapes.Add(new Circle(NextShapeId++, 5, 0.8));
            Shapes.Add(new Rectangle(NextShapeId++, 4, 6, 0.7));
            Shapes.Add(new Triangle(NextShapeId++, 3, 4, 5, 0.6));
            Shapes.Add(new Square(NextShapeId++, 4, 0.9));
        }
    }
}