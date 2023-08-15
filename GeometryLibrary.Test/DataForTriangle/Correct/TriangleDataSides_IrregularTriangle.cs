using System.Collections;

namespace GeometryLibrary.Test.DataForTriangle.Correct
{
    public class TriangleDataSides_IrregularTriangle : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            for (int i = 1; i < 100; i++)
            {
                yield return new object[] { i, i, i };
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
