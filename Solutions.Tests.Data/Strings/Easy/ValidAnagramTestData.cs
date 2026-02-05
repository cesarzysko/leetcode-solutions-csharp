namespace Solutions.Tests.Data.Strings.Easy;

public class ValidAnagramTestData : TestDataBase<ValidAnagramTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<(string Str, string AnagramStr), bool>()
            .DefineCustomArgConverter(args => [args.Str, args.AnagramStr])
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