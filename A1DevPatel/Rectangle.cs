namespace A1DevPatel
{
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(int shapeId, double length, double width, double opacity)
            : base(shapeId, ShapeType.Rectangle, opacity)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea() => Length * Width;
        public override double GetPerimeter() => 2 * (Length + Width);
    }
}