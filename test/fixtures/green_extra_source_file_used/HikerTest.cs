using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class HikerTest
{
    [TestMethod]
    public void the_digits_of_the_answer_add_up_to_six()
    {
        Assert.AreEqual(6, new Hiker().AnswerChecksum());
    }
}
