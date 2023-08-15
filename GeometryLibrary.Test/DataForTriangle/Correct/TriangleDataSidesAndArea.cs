using System.Collections;

namespace GeometryLibrary.Test.DataForTriangle.Correct
{
    public class TriangleDataSidesAndArea : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            Random random = new();
            for (int i = 1; i < 100; i++)
            {
                double sideOne = i;
                double sideTwo = i + random.Next(2, 10);
                double sideThree = i + random.Next(2, 20);

                double semiperimeter = (sideOne + sideTwo + sideThree) / 2;
                double area = Math.Sqrt(semiperimeter * (semiperimeter - sideOne) * (semiperimeter - sideTwo) * (semiperimeter - sideThree));
                yield return new object[] { sideOne, sideTwo, sideThree, area };
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
