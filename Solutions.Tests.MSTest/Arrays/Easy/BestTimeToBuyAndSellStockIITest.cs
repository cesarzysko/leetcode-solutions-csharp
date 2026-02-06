// <copyright file="BestTimeToBuyAndSellStockIITest.cs" company="SPS">
// Copyright (c) SPS. All rights reserved.
// </copyright>

namespace Solutions.Tests.MSTest.Arrays.Easy;

using BestTimeToBuyAndSellStockII = Solutions.Arrays.Easy.BestTimeToBuyAndSellStockII;
using BestTimeToBuyAndSellStocksIITestData = Solutions.Tests.Data.Arrays.Easy.BestTimeToBuyAndSellStocksIITestData;

/// <summary>
/// Class implementing tests logic for <see cref="BestTimeToBuyAndSellStockII"/>.
/// </summary>
[TestClass]
public sealed class BestTimeToBuyAndSellStockIITest
{
    /// <summary>
    /// Tests whether the returned profit matches the expected profit.
    /// </summary>
    /// <param name="prices">Prices of stocks across days.</param>
    /// <param name="expectedProfit">Expected max profit from buying and selling stocks.</param>
    [TestMethod]
    [FromTestData(typeof(BestTimeToBuyAndSellStocksIITestData))]
    public void Solution_GetMaxProfit_Test(int[] prices, int expectedProfit)
    {
        int result = BestTimeToBuyAndSellStockII.Solution(prices);
        Assert.AreEqual(expectedProfit, result);
    }
}
