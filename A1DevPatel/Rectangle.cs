using System;

namespace A1DevPatel
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(int shapeId, double length, double width, double opacity) : base(shapeId, opacity)
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
            return base.ToString() + $", Length: {Length:F2}, Width: {Width:F2}, Area: {GetArea():F2}, Perimeter: {GetPerimeter():F2}";
        }
    }
}
