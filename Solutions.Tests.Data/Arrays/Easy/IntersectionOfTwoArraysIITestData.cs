namespace Solutions.Tests.Data.Arrays.Easy;

public sealed class IntersectionOfTwoArraysIITestData : TestDataBase<IntersectionOfTwoArraysIITestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(int[] arr1, int[] arr2), int[]>()
            .DefineCustomArgConverter(args => [args.arr1, args.arr2])
            .Add(
                ([0], [1]),
                [])
            .Add(
                ([1, 2, 3, 4, 5], [5, 4, 3, 2, 1]),
                [1, 2, 3, 4, 5])
            .Add(
                ([0, 10, 11, 11, 11, 20], [1, 2, 3, 11, 10, 22, 13, 11]),
                [10, 11, 11]);
    }
}