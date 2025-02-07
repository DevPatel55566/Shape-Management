using System;

namespace A1DevPatel
{
    public abstract class Shape
    {
        private static int _nextId = 1;
        public int ShapeId { get; }
        public double Opacity { get; set; }

        protected Shape(double opacity)
        {
            ShapeId = _nextId++;
            Opacity = opacity;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{GetType().Name} (ID: {ShapeId}, Opacity: {Opacity})";
        }
    }
}
