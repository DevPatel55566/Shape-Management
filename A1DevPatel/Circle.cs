namespace A1DevPatel
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(int shapeId, double radius, double opacity)
            : base(shapeId, ShapeType.Circle, opacity)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;
        public override double GetPerimeter() => 2 * Math.PI * Radius;
    }
}