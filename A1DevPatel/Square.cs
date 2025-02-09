using System;

namespace A1DevPatel
{
    public class Square : Rectangle
    {
        public double Side
        {
            get => Length;  
            set
            {
                Length = value;
                Width = value;
            }
        }

        public Square(int shapeId, double side, double opacity)
            : base(shapeId, side, side, opacity) { }

        public override string ToString()
        {
            return base.ToString() + $", Side Length: {Side:F2}";
        }
    }
}
