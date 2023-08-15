using System.Collections;

namespace GeometryLibrary.Test.DataForCircle.Correct
{
    public class CircleDataRadiusAndArea : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            for (int i = 1; i < 100; i++)
            {
                yield return new object[] { i, Math.PI * Math.Pow(i, 2) };
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
