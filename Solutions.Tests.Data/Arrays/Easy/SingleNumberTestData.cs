namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class SingleNumberTestData : TestDataBase<SingleNumberTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[], int>()
            .Add(
                [0], 
                0)
            .Add(
                [1, 0, 0], 
                1)
            .Add(
                [0, 1, 0], 
                1)
            .Add(
                [0, 0, 1], 
                1)
            .Add(
                [0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0], 
                5);
    }
}