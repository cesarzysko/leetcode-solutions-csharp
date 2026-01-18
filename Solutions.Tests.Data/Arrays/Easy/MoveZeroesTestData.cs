namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class MoveZeroesTestData : TestDataBase<MoveZeroesTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[], int[]>()
            .Add(
                [0],
                [0])
            .Add(
                [1],
                [1])
            .Add(
                [0, 1],
                [1, 0])
            .Add(
                [0, 0, 0, 1, 0],
                [1, 0, 0, 0, 0])
            .Add(
                [0, 1, 0, 2, 0, 3, 0],
                [1, 2, 3, 0, 0, 0, 0])
            .Add(
                [1, 2, 0, 3, 0, 4, 5],
                [1, 2, 3, 4, 5, 0, 0])
            .Add(
                [1, 2, 3, 4, 5, 0, 0],
                [1, 2, 3, 4, 5, 0, 0]);
    }
}