using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class SingleNumberTest
    {
        [DataTestMethod]
        [DynamicData(
            nameof(SingleNumberTestData.GetTestData), 
            typeof(SingleNumberTestData), 
            DynamicDataSourceType.Method
        )]
        public void Solution_SingleNumber_Test(int[] nums, int expectedNum)
        {
            int result = SingleNumber.Solution(nums);
            Assert.AreEqual(expectedNum, result);
        }
    }
}
