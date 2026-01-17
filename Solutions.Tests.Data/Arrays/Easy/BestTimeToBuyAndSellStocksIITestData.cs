using System.Collections;
using System.Collections.Generic;

namespace Solutions.Tests.Data.Arrays.Easy;

public class BestTimeToBuyAndSellStocksIITestData : IEnumerable<object[]>
{
    public static IEnumerable<object[]> GetTestData()
        => new BestTimeToBuyAndSellStocksIITestData();
        
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return Case(
            [1, 2, 3, 4, 5], 
            4
        );
        yield return Case(
            [5, 1, 5], 
            4
        );
        yield return Case(
            [5, 5, 5, 5, 5, 2, 1], 
            0
        );
        yield return Case(
            [5, 5, 3, 5, 5, 2, 3, 4, 1, 0], 
            4
        );
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    private static object[] Case(int[] prices, int expectedProfit)
        => [prices, expectedProfit];
}