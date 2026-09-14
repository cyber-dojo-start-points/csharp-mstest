using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class AnswerSizeTest
{
    [TestMethod]
    public void the_answer_is_two_digits_long()
    {
        Assert.AreEqual(2, new Hiker().Answer().ToString().Length;
    }
}
