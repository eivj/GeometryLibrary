namespace GeometryLibrary.Shapes
{
    public class Triangle : Shape
    {
        private double _sideOne;
        private double _sideTwo;
        private double _sideThree;
        public double SideOne
        {
            get { return _sideOne; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длины сторон должны быть положительными числами.");
                }
                _sideOne = value;
            }
        }
        public double SideTwo
        {
            get { return _sideTwo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длины сторон должны быть положительными числами.");
                }
                _sideTwo = value;
            }
        }
        public double SideThree
        {
            get { return _sideThree; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длины сторон должны быть положительными числами и больше нуля.");
                }
                _sideThree = value;
            }
        }

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne <= 0 || sideTwo <= 0 || sideThree <= 0)
            {
                throw new ArgumentException("Длины сторон должны быть положительными числами и больше нуля");
            }
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
        }

        public override double CalculateArea()
        {
            // Используем формулу Герона для вычисления площади треугольника
            double semiperimeter = (_sideOne + _sideTwo + _sideThree) / 2;

            return Math.Sqrt(semiperimeter * (semiperimeter - _sideOne) * (semiperimeter - _sideTwo) * (semiperimeter - _sideThree));
        }

        public bool IsTriangleRightAngled()
        {
            // Проверяем теорему Пифагора для определения прямоугольности треугольника
            double[] sides = { _sideOne, _sideTwo, _sideThree };
            // Гипотенуза - это большая сторона
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
