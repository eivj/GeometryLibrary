using GeometryLibrary.Shapes;
using GeometryLibrary.Test.DataForCircle.Correct;

namespace GeometryLibrary.Test.CircleTests
{
    public class CircleCorrectRadius
    {
        [Theory]
        [ClassData(typeof(CircleDataRadius))]
        public void CalculateArea_ParamsRadius(double radius)
        {
            Shape circle = new Circle(radius);

            double area = circle.CalculateArea();

            Assert.Equal(Math.PI * Math.Pow(radius, 2), area);
        }

        [Theory]
        [ClassData(typeof(CircleDataRadiusAndArea))]
        public void CalculateArea_ParamsRadiusAndArea(double radius, double area)
        {
            Shape circle = new Circle(radius);

            double areaResult = circle.CalculateArea();

            Assert.Equal(area, areaResult);
        }
    }
}
