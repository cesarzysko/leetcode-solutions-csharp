namespace Solutions.Tests.Data.Strings.Easy;

public class LongestCommonPrefixTestData : TestDataBase<LongestCommonPrefixTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string[], string>()
            .Add(
            [
                "preabc", "predef", "preghi"
            ],
            "pre")
            .Add(
            [
                "preabc", "predef", "prxghi"
            ],
            "pr")
            .Add(
            [
                "abc", "def", "ghi"
            ],
            string.Empty)
            .Add(
            [
                "prefix", "prefixabc", "prefixdef"
            ],
            "prefix");
    }
}