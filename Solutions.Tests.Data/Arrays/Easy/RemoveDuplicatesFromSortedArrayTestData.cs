namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class RemoveDuplicatesFromSortedArrayTestData : TestDataBase<RemoveDuplicatesFromSortedArrayTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[], int[]>()
            .Add(
                [1, 1, 1, 2, 2, 3],
                [1, 2, 3])
            .Add(
                [2, 2, 4, 5, 8, 11, 11, 11, 11, 15, 100],
                [2, 4, 5, 8, 11, 15, 100])
            .Add(
                [4, 7, 9, 11, 13, 101],
                [4, 7, 9, 11, 13, 101])
            .Add(
                [0],
                [0]);
    }
}