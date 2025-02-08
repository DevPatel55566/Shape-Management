using System;

namespace A1DevPatel
{
    public class Square : Rectangle
    {
        public double Side
        {
            get => Length;  // Get the Length property from Rectangle
            set
            {
                Length = value;
                Width = value; // Ensure Width stays equal to Length
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
