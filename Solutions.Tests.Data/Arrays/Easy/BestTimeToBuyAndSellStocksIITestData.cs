namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class BestTimeToBuyAndSellStocksIITestData : TestDataBase<BestTimeToBuyAndSellStocksIITestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[], int>()
            .Add(
                [1, 2, 3, 4, 5],
                4)
            .Add(
                [5, 1, 5],
                4)
            .Add(
                [5, 5, 5, 5, 5, 2, 1],
                0)
            .Add(
                [5, 5, 3, 5, 5, 2, 3, 4, 1, 0],
                4);
    }
}