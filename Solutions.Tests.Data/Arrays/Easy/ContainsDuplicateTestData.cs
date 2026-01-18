namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class ContainsDuplicateTestData : TestDataBase<ContainsDuplicateTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[], bool>()
            .Add(
                [1, 2, 3, 4, 5],
                false)
            .Add(
                [1, 4, 3, 10, 5],
                false)
            .Add(
                [1],
                false)
            .Add(
                [1, 1],
                true)
            .Add(
                [1, 0, 3, 1, 9],
                true);
    }
}