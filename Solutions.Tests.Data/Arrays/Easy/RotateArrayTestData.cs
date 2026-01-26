namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class RotateArrayTestData : TestDataBase<RotateArrayTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(int[] arr, int rot), int[]>()
            .DefineCustomArgConverter(args => [args.arr, args.rot])
            .Add(
                ([1, 2, 3, 4, 5], 0),
                [1, 2, 3, 4, 5])
            .Add(
                ([1, 2, 3, 4, 5], 1),
                [5, 1, 2, 3, 4])
            .Add(
                ([1, 2, 3, 4, 5], 5),
                [1, 2, 3, 4, 5])
            .Add(
                ([1, 2, 3, 4, 5], 10),
                [1, 2, 3, 4, 5]);
    }
}