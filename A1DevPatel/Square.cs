using System;

namespace A1DevPatel
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side, double opacity) : base(opacity)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetPerimeter()
        {
            return 4*Side;
        }

        public override string ToString()
        {
            return $"Square - ID: {ShapeId}, Side: {Side}, Opacity: {Opacity}, Area: {GetArea():F2}";
        }
    }
}
