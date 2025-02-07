using System;

namespace A1DevPatel
{
    public abstract class Shape
    {
        public int ShapeId { get; }
        public double Opacity { get; set; }

        protected Shape(int shapeId, double opacity)
        {
            ShapeId = shapeId;
            Opacity = opacity;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{GetType().Name} (ID: {ShapeId}, Opacity: {Opacity:P2})";
        }
    }
}
