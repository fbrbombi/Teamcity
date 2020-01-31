using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

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
            Console.WriteLine("AJIACO1");
            Console.WriteLine(Environment.GetEnvironmentVariable("Ambiente"));
            Thread.Sleep(60000);
        }

        [Test]
        public void test2()
        {
            driver.Url = "https://www.google.co";
            Console.WriteLine("AJIACO2");
            Console.WriteLine(Environment.GetEnvironmentVariable("Ambiente"));
            Thread.Sleep(60000);

        }
        [Test]
        public void test3()
        {
            driver.Url = "https://www.google.co";
            Console.WriteLine("AJIACO3");
            Console.WriteLine(Environment.GetEnvironmentVariable("Ambiente"));
            Thread.Sleep(60000);

        }

        [Test]
        public void test4()
        {
            driver.Url = "https://www.google.co";
            Console.WriteLine("AJIACO4");
            Console.WriteLine(Environment.GetEnvironmentVariable("Ambiente"));
            Thread.Sleep(60000);

        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
            
        }
    }
}
