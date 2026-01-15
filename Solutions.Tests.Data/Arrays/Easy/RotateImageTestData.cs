using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy
{
    public class RotateImageTestData : IEnumerable<object[]>
    {
        public static IEnumerable<object[]> GetTestData()
            => new RotateImageTestData();

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return Case(
                new[] {
                    new[] { 1 }
                },
                new[] {
                    new[] { 1 }
                }
            );
            yield return Case(
                new[] {
                    new[] { 1, 2 },
                    new[] { 3, 4 }
                },
                new[] {
                    new[] { 3, 1 },
                    new[] { 4, 2 }
                }
            );
            yield return Case(
                new[] {
                    new[] { 1, 2, 3 },
                    new[] { 4, 5, 6 },
                    new[] { 7, 8, 9 }
                },
                new[] {
                    new[] { 7, 4, 1 },
                    new[] { 8, 5, 2 },
                    new[] { 9, 6, 3 }
                }
            );
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private static object[] Case(int[][] matrix, int[][] expectedMatrix)
            => new object[] { matrix, expectedMatrix };
    }
}
