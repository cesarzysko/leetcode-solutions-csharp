namespace Solutions.Tests.Data.Strings.Easy;

public sealed class ReverseIntegerTestData : TestDataBase<ReverseIntegerTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<int, int>()
            .Add(
                12,
                21)
            .Add(
                int.MaxValue,
                0)
            .Add(
                int.MinValue,
                0)
            .Add(
                123_456_789,
                987_654_321)
            .Add(
                -123_456_789,
                -987_654_321)
            .Add(
                1_000_000_008,
                0);
    }
}