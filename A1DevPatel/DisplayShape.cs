using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace A1DevPatel
{
    class DisplayShape
    {
        public static void DisplayShapes() //Method to display each shape present in a table
        {
            Console.WriteLine("\nAll Shapes:");

            var table = new ConsoleTable("ID", "Shape", "Dimensions", "Opacity", "Area", "Perimeter");

            foreach (var shape in Program.Shapes)
            {
                string measurements = shape switch
                {
                    Square s => $"{s.Side:F2}",
                    Circle c => $"{c.Radius:F2}",
                    Rectangle r => $"{r.Length:F2}, {r.Width:F2}",
                    Triangle t => $"{t.SideA:F2}, {t.SideB:F2}, {t.SideC:F2}",
                    _ => "Unknown"
                };

                table.AddRow(
                    shape.ShapeId,
                    shape.GetType().Name,
                    measurements,
                    $"{shape.Opacity:P2}",
                    $"{shape.GetArea():F2}",
                    $"{shape.GetPerimeter():F2}"
                );
            }

            if (Program.Shapes.Count == 0)
            {
                Console.WriteLine("No shapes found.");
            }
            else
            {
                table.Write();
            }
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        public static void DisplayShapesByCategory<T>() where T : Shape // Method to dsiplay each shape specifically
        {
            string shapeName = typeof(T).Name;
            var filteredShapes = Program.Shapes.OfType<T>().ToList();
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
                        Square s => $"{s.Side:F2}",
                        Circle c => $"{c.Radius:F2}",
                        Rectangle r => $"{r.Length:F2}, {r.Width:F2}",
                        Triangle t => $"{t.SideA:F2}, {t.SideB:F2}, {t.SideC:F2}",
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

        }
    }
}
