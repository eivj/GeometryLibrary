using System.Collections;

namespace GeometryLibrary.Test.DataForCircle.InCorrect
{
    public class CircleDataRadius : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            for (int i = -100; i < 1; i++)
            {
                yield return new object[] { i };
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
