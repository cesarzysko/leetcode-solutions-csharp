namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class RotateImageTestData : TestDataBase<RotateImageTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int[][], int[][]>()
            .Add(
                [
                    [1]
                ],
                [
                    [1]
                ])
            .Add(
                [
                    [1, 2],
                    [3, 4]
                ],
                [
                    [3, 1],
                    [4, 2]
                ])
            .Add(
                [
                    [1, 2, 3],
                    [4, 5, 6],
                    [7, 8, 9]
                ],
                [
                    [7, 4, 1],
                    [8, 5, 2],
                    [9, 6, 3]
                ]);
    }
}