using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class ContainsDuplicateTest
    {
        [DataTestMethod]
        [DynamicData(
            nameof(ContainsDuplicateTestData.GetTestData),
            typeof(ContainsDuplicateTestData),
            DynamicDataSourceType.Method
        )]
        public void Solution_ContainsDuplicate_Test(int[] nums, bool expectedResult)
        {
            bool result = ContainsDuplicate.Solution(nums);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
