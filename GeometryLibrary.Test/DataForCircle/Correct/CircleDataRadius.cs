using System.Collections;

namespace GeometryLibrary.Test.DataForCircle.Correct
{
    public class CircleDataRadius : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            for (int i = 1; i < 100; i++)
            {
                yield return new object[] { i };
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
