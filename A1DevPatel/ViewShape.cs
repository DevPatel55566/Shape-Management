using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace A1DevPatel
{
    class ViewShape
    {
        public static void ViewShapes()
        {
            Console.WriteLine("\nAll Shapes:");

            var table = new ConsoleTable("ID", "Shape", "Dimensions", "Opacity", "Area", "Perimeter");

            foreach (var shape in Program.shapes)
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
                    shape.GetType().Name,
                    dimensions,
                    $"{shape.Opacity:P2}",
                    $"{shape.GetArea():F2}",
                    $"{shape.GetPerimeter():F2}"
                );
            }

            if (Program.shapes.Count == 0)
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

        public static void ViewShapesByType<T>() where T : Shape
        {
            string shapeName = typeof(T).Name;
            var filteredShapes = Program.shapes.OfType<T>().ToList(); 
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
    }
}
