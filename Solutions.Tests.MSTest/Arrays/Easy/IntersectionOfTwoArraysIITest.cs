using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy;

[TestClass]
public sealed class IntersectionOfTwoArraysIITest
{
    [TestMethod]
    [DynamicData(
        nameof(IntersectionOfTwoArraysIITestData.GetTestData),
        typeof(IntersectionOfTwoArraysIITestData)
    )]
    public void Solution_Intersection_Test(int[] nums1, int[] nums2, int[] expectedIntersection)
    {
        int[] result = IntersectionOfTwoArraysII.Solution(nums1, nums2);

        int rK = result.Length;
        int eK = expectedIntersection.Length;
        Assert.AreEqual(eK, rK);

        short[] counts = new short[1001];

        for (int i = 0; i < eK; ++i)
        {
            int value = expectedIntersection[i];
            ++counts[value];
        }

        for (int i = 0; i < rK; ++i)
        {
            int value = result[i];
            Assert.IsInRange(0, 1000, value);
            Assert.IsGreaterThanOrEqualTo(0, --counts[value], $"Unexpected extra value \"{value}\".");
        }
    }
}