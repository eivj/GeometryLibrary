using GeometryLibrary.Shapes;
using GeometryLibrary.Test.DataForTriangle.Correct;
using GeometryLibrary.Test.DataForTriangle.InCorrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Test.TriangleTests
{
    public class TriangleInCorrectSides
    {
        [Theory]
        [ClassData(typeof(TriangleDataSides))]
        public void CalculateArea_ParamsSides(double sideOne, double sideTwo, double sideThree)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideOne, sideTwo, sideThree));
        }
    }
}
