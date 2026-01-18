namespace Solutions.Tests.Data.Strings.Easy;

public sealed class ReverseStringTestData : TestDataBase<ReverseStringTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<char[], char[]>()
            .Add(
                Charr("abba"), 
                Charr("abba"))
            .Add(
                Charr("dada"), 
                Charr("adad"))
            .Add(
                Charr("abcdefghijk"), 
                Charr("kjihgfedcba"))
            .Add(
                Charr("12#90*.\\$@"), 
                Charr("@$\\.*09#21"));
    }

    private static char[] Charr(string s)
        => s.ToCharArray();
}