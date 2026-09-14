using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class HikerTest
{
    [TestMethod]
    public void life_the_universe_and_everything()
    {
        Assert.AreEqual(42, new Hiker().Ansewr());
    }
}
