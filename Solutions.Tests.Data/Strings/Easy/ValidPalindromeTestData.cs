namespace Solutions.Tests.Data.Strings.Easy;

public class ValidPalindromeTestData : TestDataBase<ValidPalindromeTestData>
{
    protected override ITestCaseBuilder ConstructTestCases()
    {
        return Cases<string, bool>()
            .Add(
                "A man, a plan, a canal: Panama",
                true)
            .Add(
                "race a car",
                false)
            .Add(
                " ",
                true)
            .Add(
                "1 2 34 .321",
                true)
            .Add(
                "Madam, I'm Adam",
                true)
            .Add(
                "!M@ad--am, I'\\m Ad#am/",
                true)
            .Add(
                "appbappa",
                false);
    }
}