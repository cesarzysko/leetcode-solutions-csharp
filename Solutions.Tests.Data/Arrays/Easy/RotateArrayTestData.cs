namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class RotateArrayTestData : TestDataBase<RotateArrayTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(int[] Arr, int Rot), int[]>()
            .DefineCustomArgConverter(args => [args.Arr, args.Rot])
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