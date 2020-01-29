using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

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
            System.Console.WriteLine("AJIACO");
            System.Console.WriteLine(Environment.GetEnvironmentVariable("Ambiente"));
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
            
        }
    }
}
