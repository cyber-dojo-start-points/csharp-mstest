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
    public void the_answer_is_two_digits_long()
    {
        Assert.AreEqual(2, new Hiker().AnswerSize());
    }
}
