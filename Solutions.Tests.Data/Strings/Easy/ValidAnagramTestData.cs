namespace Solutions.Tests.Data.Strings.Easy;

public class ValidAnagramTestData : TestDataBase<ValidAnagramTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(string s1, string s2), bool>()
            .DefineCustomArgConverter(args => [args.s1, args.s2])
            .Add(
                ("turtle", "leturt"), 
                true)
            .Add(
                ("anagram", "nagamam"), 
                false)
            .Add(
                ("abba", "baab"), 
                true)
            .Add(
                ("anagrram", "anagrramm"), 
                false)
            .Add(
                ("anagramm", "anagrammm"), 
                false);
    }
}