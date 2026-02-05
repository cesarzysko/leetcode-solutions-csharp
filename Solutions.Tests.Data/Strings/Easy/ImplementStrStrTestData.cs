namespace Solutions.Tests.Data.Strings.Easy;

public class ImplementStrStrTestData : TestDataBase<ImplementStrStrTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(string Str, string SearchedStr), int>()
            .DefineCustomArgConverter(args => [args.Str, args.SearchedStr])
            .Add(
                ("sadbutsad", "sad"),
                0)
            .Add(
                ("hello world, goodbye world", "world"),
                6)
            .Add(
                ("cat had a hat", "hada"),
                -1)
            .Add(
                ("hello", "goodbye"),
                -1);
    }
}