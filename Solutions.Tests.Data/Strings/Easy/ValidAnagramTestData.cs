namespace Solutions.Tests.Data.Strings.Easy;

public class ValidAnagramTestData : TestDataBase<ValidAnagramTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, string, bool>()
            .Add(
                "turtle", 
                "leturt", 
                true)
            .Add(
                "anagram", 
                "nagamam", 
                false)
            .Add(
                "abba", 
                "baab", 
                true)
            .Add(
                "anagrram", 
                "anagrramm", 
                false)
            .Add(
                "anagramm", 
                "anagrammm", 
                false);
    }
}