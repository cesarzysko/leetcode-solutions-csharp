namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class TwoSumTestData : TestDataBase<TwoSumTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(int[] nums, int sum), int[]>()
            .DefineCustomArgConverter(args => [args.nums, args.sum])
            .Add(
                ([9, 1, 2, 3, 4, 5], 10), 
                [0, 1])
            .Add(
                ([1, 2, 4, 9, 13, 15, 21], 15), 
                [1, 4])
            .Add(
                ([-25, -11, 5, 11, 100], 0), 
                [1, 3])
            .Add(
                ([-25, -11, 5, 11, 100], 89), 
                [1, 4]);
    }
}