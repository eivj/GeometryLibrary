namespace GeometryLibrary.Shapes
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус должен быть положительным числом и больше нуля.");
                }
                _radius = value;
            }
        }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом и больше нуля.");
            }
            _radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
