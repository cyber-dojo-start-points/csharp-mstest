using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class HikerTest
{
    // The [TestMethod] attribute is what MSTest gathers, and nothing here
    // carries one, so the run proves nothing about the code. MSTest says as
    // much, printing a summary of zero tests, and that is the count the
    // colour is read from.
    private int Expected()
    {
        return 42;
    }
}
