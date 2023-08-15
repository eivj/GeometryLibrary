using GeometryLibrary.Shapes;

namespace GeometryLibrary.Test.CircleTests
{
    public class CircleInCorrectRadius
    {
        [Theory]
        [ClassData(typeof(DataForCircle.InCorrect.CircleDataRadius))]
        public void CalculateAreaParamsRadius(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
