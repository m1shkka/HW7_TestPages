using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestForGoogle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com.ua");
            Assert.AreEqual("Google", driver.Title);

        }
    }
}
