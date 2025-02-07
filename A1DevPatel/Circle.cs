using System;

namespace A1DevPatel
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(int shapeId, double radius, double opacity) : base(shapeId, opacity)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return base.ToString() + $", Radius: {Radius:F2}, Area: {GetArea():F2}, Perimeter: {GetPerimeter():F2}";
        }
    }
}
