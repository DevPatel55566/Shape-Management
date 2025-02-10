using System;

namespace A1DevPatel
{
    class AddShape
    {
        public static void AddShapes()
        {
            Console.Clear(); // Clears the console
            Program.Header(); // Displays the header infrormation containing id and name 

            Console.WriteLine("\n\tAdd Shape\n");
            Console.WriteLine("\t1. Add Circle");
            Console.WriteLine("\t2. Add Triangle");
            Console.WriteLine("\t3. Add Rectangle");
            Console.WriteLine("\t4. Add Square");
            Console.WriteLine("\t5. Back to main menu\n");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    InsertShape<Circle>(); //This will give details to add circle
                    break;
                case "2":
                    InsertShape<Triangle>();//This will give details to add trianlge
                    break;
                case "3":
                    InsertShape<Rectangle>();//This will give details to add rectangle
                    break;
                case "4":
                    InsertShape<Square>();//This will give details to add square
                    break;
                case "5":
                    return;//This will return to main menu
                default:
                    Console.WriteLine("Invalid \nPress any key to continue"); //If you enter something wrong this will pop up and you have to print correct value
                    Console.ReadKey();
                    AddShapes();
                    break;
            }
        }

        private static void InsertShape<T>() where T : Shape // generic collection to add shape based on its type 
        {
            try
            {
                double opacity = GetOpacityValue();

                Shape newShape = typeof(T) switch
                {
                    Type t when t == typeof(Circle) => new Circle(Program.NextShapeId++, GetDoubleInput("Enter radius: "), opacity),
                    Type t when t == typeof(Triangle) => new Triangle(Program.NextShapeId++, GetDoubleInput("Enter side A: "), GetDoubleInput("Enter side B: "), GetDoubleInput("Enter side C: "), opacity),
                    Type t when t == typeof(Rectangle) => new Rectangle(Program.NextShapeId++, GetDoubleInput("Enter length: "), GetDoubleInput("Enter width: "), opacity),
                    Type t when t == typeof(Square) => new Square(Program.NextShapeId++, GetDoubleInput("Enter side: "), opacity),
                    _ => throw new InvalidOperationException("Invalid")
                };
                Program.Shapes.Add(newShape);
                Console.WriteLine($"\nNew {typeof(T).Name} Added!");
                DisplayShape.DisplayShapesByCategory<T>(); 
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            AddShapes();
        }

        public static double GetOpacityValue(string input = "Enter opacity: ") // This will check if the opacity of user is correct or not 
        {
            double opacity;
            while (true)
            {
                Console.Write(input);
                if (double.TryParse(Console.ReadLine(), out opacity) && opacity >= 0 && opacity <= 1)
                    return opacity;
                Console.WriteLine("Invalid \n. Opacity must be between 0 and 1.");
            }
        }
        public static double GetDoubleInput(string input) // This will check if the input of user is correct or not 
        {
            double value;
            while (true)
            {
                Console.Write(input);
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value;
                Console.WriteLine("Invalid ");
            }
        }
    }
}