using System.Collections;

namespace GeometryLibrary.Test.DataForTriangle.Correct
{
    public class TriangleDataSides_RightTriangle : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 3, 4, 5 };
            yield return new object[] { 9, 40, 41 };
            yield return new object[] { 12, 35, 37 };
            yield return new object[] { 20, 21, 29 };
            yield return new object[] { 11, 60, 61 };
            yield return new object[] { 28, 45, 53 };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
