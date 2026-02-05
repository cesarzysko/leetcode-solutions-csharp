namespace Solutions.Tests.Data.Strings.Easy;

public class StringToIntegerAtoiTestData : TestDataBase<StringToIntegerAtoiTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, int>()
            .Add(
                "42",
                42)
            .Add(
                "-042",
                -42)
            .Add(
                "1337c0d3",
                1337)
            .Add(
                "0-1",
                0)
            .Add(
                "words and 987",
                0);
    }
}