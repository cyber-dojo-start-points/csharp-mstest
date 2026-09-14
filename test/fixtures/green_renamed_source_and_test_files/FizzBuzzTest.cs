using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class FizzBuzzTest
{
    [TestMethod]
    public void fifteen_says_fizz_buzz()
    {
        Assert.AreEqual("FizzBuzz", new FizzBuzz().Say(15));
    }
}
