namespace Solutions.Tests.Data.Strings.Easy;

public sealed class FirstUniqueCharacterInAStringTestData : TestDataBase<FirstUniqueCharacterInAStringTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, char>()
            .DefineCustomOutGenerator((s, c) => [s.IndexOf(c)])
            .Add(
                "a", 
                'a')
            .Add(
                "aba", 
                'b')
            .Add(
                "abcdefghijklmnopqrstuwvyzabcdefghijklmnopqrstuwyz", 
                'v');
    }
}