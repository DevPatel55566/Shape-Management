using System;

namespace A1DevPatel
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width, double opacity) : base(opacity)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public override string ToString()
        {
            return $"Rectangle - ID: {ShapeId}, Length: {Length}, Width: {Width}, Opacity: {Opacity}, Area: {GetArea():F2}";
        }
    }
}
