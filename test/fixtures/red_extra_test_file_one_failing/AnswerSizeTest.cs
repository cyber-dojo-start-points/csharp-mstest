using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class AnswerSizeTest
{
    [TestMethod]
    public void the_answer_is_three_digits_long()
    {
        Assert.AreEqual(3, new Hiker().Answer().ToString().Length);
    }
}
