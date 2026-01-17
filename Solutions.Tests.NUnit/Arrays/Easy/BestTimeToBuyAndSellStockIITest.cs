using Solutions.Arrays.Easy;
using Solutions.Tests.Data.Arrays.Easy;

namespace Solutions.Tests.NUnit.Arrays.Easy;

[TestFixture]
public sealed class BestTimeToBuyAndSellStockIITest
{
    [Test]
    [TestCaseSource(typeof(BestTimeToBuyAndSellStocksIITestData))]
    public void Solution_GetMaxProfit_Test(int[] prices, int expectedProfit)
    {
        int result = BestTimeToBuyAndSellStockII.Solution(prices);
        Assert.That(result, Is.EqualTo(expectedProfit));
    }
}