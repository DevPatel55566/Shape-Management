using System;

namespace A1DevPatel
{
    public enum ShapeType
    {
        Circle,
        Triangle,
        Rectangle,
        Square
    }

    public abstract class Shape
    {
        public int ShapeId { get; }
        public ShapeType ShapeType { get; }
        public double Opacity { get; set; }

        protected Shape(int shapeId, ShapeType shapeType, double opacity)
        {
            ShapeId = shapeId;
            ShapeType = shapeType;
            Opacity = opacity;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}