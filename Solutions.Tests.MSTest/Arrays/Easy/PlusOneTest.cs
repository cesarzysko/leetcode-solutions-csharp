using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Arrays.Easy.PlusOne;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.MSTest.Arrays.Easy
{
    [TestClass]
    public class PlusOneTest
    {
        [TestMethod]
        [DynamicData(
            nameof(PlusOneTestData.GetTestData),
            typeof(PlusOneTestData)
        )]
        public void Solution_PlusOne_Test(int[] digits, int[] expectedDigits)
        {
            int[] result = PlusOne.Solution(digits);

            int rK = result.Length;
            int eK = expectedDigits.Length;
            Assert.AreEqual(eK, rK);
            CollectionAssert.AreEqual(expectedDigits, result);
        }
    }
}
