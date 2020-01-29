using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestTeamCity
{
    [TestFixture]
    class Test
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void test()
        {
            driver.Url = "https://www.google.co";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
