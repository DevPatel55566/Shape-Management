using System;

namespace A1DevPatel
{
    public class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height, double opacity) : base(opacity)
        {
            BaseLength = baseLength;
            Height = height;
        }

        public override double GetArea()
        {
            return 0.5 * BaseLength * Height;
        }

        public override double GetPerimeter()
        {
            return BaseLength + Height;
        }

        public override string ToString()
        {
            return $"Triangle - ID: {ShapeId}, Base: {BaseLength}, Height: {Height}, Opacity: {Opacity}, Area: {GetArea():F2}";
        }
    }
}
