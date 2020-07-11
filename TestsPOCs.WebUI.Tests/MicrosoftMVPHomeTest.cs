using NUnit.Framework;

namespace TestsPOCs.WebUI.Tests
{
    [TestFixture]
    public class MicrosoftMVPHomeTest : TestBase
    {
        [SetUp]
        public void setup()
        {

        }

        [Test]
        public void test()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "https://www.google.com/";

            webDriver.Navigate();

            Assert.AreEqual("Google kaka", webDriver.Title);
        }
    }
}
