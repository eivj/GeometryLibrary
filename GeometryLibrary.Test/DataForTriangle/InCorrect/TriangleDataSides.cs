using System.Collections;

namespace GeometryLibrary.Test.DataForTriangle.InCorrect
{
    public class TriangleDataSides : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            for (int i = -100; i < 0; i++)
            {
                yield return new object[] { i, i + 1, i + 2};
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
