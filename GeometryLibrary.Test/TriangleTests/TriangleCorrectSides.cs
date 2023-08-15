using GeometryLibrary.Shapes;
using GeometryLibrary.Test.DataForCircle.Correct;
using GeometryLibrary.Test.DataForTriangle.Correct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Test.TriangleTests
{
    public class TriangleCorrectSides
    {
        [Theory]
        [ClassData(typeof(TriangleDataSidesAndArea))]
        public void CalculateArea_ParamsSidesAndArea(double sideOne, double sideTwo, double sideThree, double area)
        {
            Shape triangle = new Triangle(sideOne, sideTwo, sideThree);
            
            double resultArea = triangle.CalculateArea();

            Assert.Equal(resultArea, area);
        }

        [Theory]
        [ClassData(typeof(TriangleDataSides_RightTriangle))]
        public void IsTriangleRightAngled_True(double sideOne, double sideTwo, double sideThree)
        {
            Triangle triangle = new Triangle(sideOne, sideTwo, sideThree);

            bool result = triangle.IsTriangleRightAngled();

            Assert.True(result);
        }

        [Theory]
        [ClassData(typeof(TriangleDataSides_IrregularTriangle))]
        public void IsTriangleRightAngled_False(double sideOne, double sideTwo, double sideThree)
        {
            Triangle triangle = new Triangle(sideOne, sideTwo, sideThree);

            bool result = triangle.IsTriangleRightAngled();

            Assert.True(!result);
        }
    }
}
