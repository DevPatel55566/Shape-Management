using System;

namespace A1DevPatel
{
    public class Square : Rectangle
    {
        public double Side
        {
            get => Length;  // Length property is inherited from Rectangle
            set
            {
                Length = value;
                Width = value; // Ensuring width remains the same
            }
        }

        public Square(int shapeId, double side, double opacity)
    : base(shapeId, side, side, opacity) // Provide both length and width
        {
        }


        public override string ToString()
        {
            return base.ToString() + $", Side Length: {Length:F2}";
        }
    }
}
