using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class HikerTest
{
    [TestMethod]
    public void life_the_universe_and_everything()
    {
        Assert.AreEqual(42, new Hiker().Answer());
    }

    [TestMethod]
    public void the_answer_is_a_multiple_of_seven()
    {
        Assert.AreEqual(0, new Hiker().Answer() % 7);
    }

    [TestMethod]
    public void the_answer_reads_as_forty_two()
    {
        Assert.AreEqual("42", new Hiker().Answer().ToString());
    }
}
