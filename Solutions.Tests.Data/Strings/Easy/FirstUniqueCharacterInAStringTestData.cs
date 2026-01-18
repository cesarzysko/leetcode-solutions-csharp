namespace Solutions.Tests.Data.Strings.Easy;

public sealed class FirstUniqueCharacterInAStringTestData : TestDataBase<FirstUniqueCharacterInAStringTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, int>()
            .Add(
                "a", 
                s => s.IndexOf('a'))
            .Add(
                "aba", 
                s => s.IndexOf('b'))
            .Add(
                "abcdefghijklmnopqrstuwvyzabcdefghijklmnopqrstuwyz", 
                s => s.IndexOf('v'));
    }
}