using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1DevPatel
{
    class ModifyShape
    {
        public static void ModifyShapes()
        {
            Console.Clear(); // clears the console
            Program.Header();//Displays header containing id and name 

            Console.WriteLine("\n\tEdit Shape\n");
            Console.WriteLine("\t1. Edit Circle");
            Console.WriteLine("\t2. Edit Triangle");
            Console.WriteLine("\t3. Edit Rectangle");
            Console.WriteLine("\t4. Edit Square");
            Console.WriteLine("\t5. Back to main menu\n");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ModifyShapeByType<Circle>(); // this will give option to modify exiating circle
                    break;
                case "2":
                    ModifyShapeByType<Triangle>(); // this will give option to modify exiating triangle
                    break;
                case "3":
                    ModifyShapeByType<Rectangle>(); // this will give option to modify exiating rectangle
                    break;
                case "4":
                    ModifyShapeByType<Square>(); // this will give option to modify exiating square
                    break;
                case "5":
                    return; // return to main menu
                default:
                    Console.WriteLine("Invalid \nPress any key to continue"); //If you enter something wrong this will pop up and you have to print correct value
                    Console.ReadKey();
                    ModifyShapes();
                    break;
            }
        }

        public static void ModifyShapeByType<T>() where T : Shape // Method to modify specific shape according to the option selected using its id
        {
            try
            {
                DisplayShape.DisplayShapesByCategory<T>();
                Console.Write("Enter ID to edit: ");

                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Shape shape = Program.Shapes.OfType<T>().First(s => s.ShapeId == id);
                    if (shape != null)
                    {
                        ModifyShapeProperties(shape);
                        Console.WriteLine($"{typeof(T).Name} updated!");
                    }
                    else
                    {
                        Console.WriteLine($"{typeof(T).Name} not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            DisplayShape.DisplayShapesByCategory<T>();
            Console.ReadKey();
            ModifyShapes();
        }

        public static void ModifyShapeProperties(Shape shape) // Properties of each shape that needs to be modified
        {
            switch (shape)
            {
                case Square square:
                    square.Side = AddShape.GetDoubleInput("Enter new side: ");
                    break;
                case Circle circle:
                    circle.Radius = AddShape.GetDoubleInput("Enter new radius: ");
                    break;
                case Triangle triangle:
                    triangle.SideA = AddShape.GetDoubleInput("Enter new side A: ");
                    triangle.SideB = AddShape.GetDoubleInput("Enter new side B: ");
                    triangle.SideC = AddShape.GetDoubleInput("Enter new side C: ");
                    break;
                case Rectangle rectangle:
                    rectangle.Length = AddShape.GetDoubleInput("Enter new length: ");
                    rectangle.Width = AddShape.GetDoubleInput("Enter new width: ");
                    break;

            }
            shape.Opacity = AddShape.GetOpacityValue();
        }
    }
}
