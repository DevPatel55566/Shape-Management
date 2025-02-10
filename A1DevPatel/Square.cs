namespace A1DevPatel
{
    public class Square : Rectangle
    {
        public Square(int shapeId, double side, double opacity)
            : base(shapeId, side, side, opacity)
        {
        }

        public double Side
        {
            get => Length; // Since Length and Width are equal for a square
            set
            {
                Length = value;
                Width = value;
            }
        }
    }
}