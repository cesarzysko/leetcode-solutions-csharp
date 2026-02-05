namespace Solutions.Tests.Data.Strings.Easy;

public sealed class ReverseStringTestData : TestDataBase<ReverseStringTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, string>()
            .DefineCustomArgConverter(s => [s.ToCharArray()])
            .DefineCustomOutConverter(s => [s.ToCharArray()])
            .Add(
                "abba",
                "abba")
            .Add(
                "dada",
                "adad")
            .Add(
                "abcdefghijk",
                "kjihgfedcba")
            .Add(
                "12#90*.\\$@",
                "@$\\.*09#21");
    }
}