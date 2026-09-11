using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NSubstitute;

[TestClass]
public class HikerTest
{
    // For exposition, once with Moq and once with NSubstitute.

    [TestMethod]
    public void answer_is_logged_verified_with_moq()
    {
        var logger = new Mock<ILogger>();

        var answer = new Hiker(logger.Object).Answer();

        Assert.AreEqual(42, answer);
        logger.Verify(l => l.Log("the answer is 42"), Times.Once);
    }

    [TestMethod]
    public void answer_is_logged_verified_with_nsubstitute()
    {
        var logger = Substitute.For<ILogger>();

        var answer = new Hiker(logger).Answer();

        Assert.AreEqual(42, answer);
        logger.Received(1).Log("the answer is 42");
    }
}
