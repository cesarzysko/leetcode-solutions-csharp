namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class PlusOneTestData : TestDataBase<PlusOneTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[], int[]>()
            .Add(
                [0],
                [1])
            .Add(
                [4, 2],
                [4, 3])
            .Add(
                [9],
                [1, 0])
            .Add(
                [1, 2, 3, 9, 7, 9],
                [1, 2, 3, 9, 8, 0])
            .Add(
                [9, 9, 9, 9, 9, 9, 9, 9, 9],
                [1, 0, 0, 0, 0, 0, 0, 0, 0, 0]);
    }
}