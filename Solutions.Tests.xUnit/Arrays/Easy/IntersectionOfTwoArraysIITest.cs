using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.xUnit.Arrays.Easy;

public class IntersectionOfTwoArraysIITest
{
    [Theory]
    [ClassData(typeof(IntersectionOfTwoArraysIITestData))]
    public void Solution_Intersection_Test(int[] nums1, int[] nums2, int[] expectedIntersection)
    {
        int[] result = IntersectionOfTwoArraysII.Solution(nums1, nums2);
        int rK = result.Length;
        int eK = expectedIntersection.Length;
        Assert.Equal(eK, rK);
        short[] counts = new short[1001];

        for (int i = 0; i < eK; ++i)
        {
            int value = expectedIntersection[i];
            ++counts[value];
        }

        for (int i = 0; i < rK; ++i)
        {
            int value = result[i];
            Assert.InRange(value, 0, 1000);
            Assert.True(--counts[value] >= 0, $"Unexpected extra value \"{value}\".");
        }
    }
}