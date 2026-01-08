using Solutions.Arrays.Easy;
using NUnit.Framework;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy
{
    [TestFixture]
    public class BestTimeToBuyAndSellStockIITest
    {
        [Test]
        [TestCaseSource(typeof(BestTimeToBuyAndSellStocksIITestData))]
        public void Solution_GetMaxProfit_Test(int[] prices, int expectedProfit)
        {
            int result = BestTimeToBuyAndSellStockII.Solution(prices);
            Assert.That(expectedProfit, Is.EqualTo(result));
        }
    }
}
