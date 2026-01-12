using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy
{
    public class PlusOneTestData : IEnumerable<object[]>
    {
        public static IEnumerable<object[]> GetTestData()
            => new PlusOneTestData();

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return Case(
                new[] { 0 }, 
                new[] { 1 }
            );
            yield return Case(
                new[] { 4, 2 }, 
                new[] { 4, 3 }
            );
            yield return Case(
                new[] { 9 }, 
                new[] { 1, 0 }
            );
            yield return Case(
                new[] { 1, 2, 3, 9, 7, 9 }, 
                new[] { 1, 2, 3, 9, 8, 0 }
            );
            yield return Case(
                new[] { 9, 9, 9, 9, 9, 9, 9, 9, 9 }, 
                new[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            );
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        private static object[] Case(int[] digits, int[] expectedDigits) 
            => new object[] { digits, expectedDigits };
    }
}