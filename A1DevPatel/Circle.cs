using System;

namespace A1DevPatel
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius, double opacity) : base(opacity)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Circle (ID: {ShapeId}, Radius: {Radius}, Opacity: {Opacity}, Area: {GetArea():F2}, Perimeter: {GetPerimeter():F2})";
        }
    }
}
