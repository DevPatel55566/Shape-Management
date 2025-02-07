namespace A1DevPatel
{
    public struct Dimensions
    {
        public double Radius { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Side { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public Dimensions(double radius = 0, double length = 0, double width = 0, double side = 0, double baseValue = 0, double height = 0)
        {
            Radius = radius;
            Length = length;
            Width = width;
            Side = side;
            Base = baseValue;
            Height = height;
        }
    }
}
