namespace Solutions.Tests.Data.Strings.Easy;

public class ImplementStrStrTestData : TestDataBase<ImplementStrStrTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, string, int>()
            .Add(
                "sadbutsad", 
                "sad", 
                0)
            .Add(
                "hello world, goodbye world",
                "world",
                6)
            .Add(
                "cat had a hat",
                "hada",
                -1)
            .Add(
                "hello",
                "goodbye",
                -1);
    }
}