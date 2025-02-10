namespace A1DevPatel
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(int shapeId, double sideA, double sideB, double sideC, double opacity)
            : base(shapeId, ShapeType.Triangle, opacity)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override double GetPerimeter() => SideA + SideB + SideC;
    }
}