using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace UnitTestDVA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com.ua");
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("test");
            element.Submit();

            List<IWebElement> elements = driver.FindElements( By.ClassName("bkWMgd") ).ToList();

            foreach (var newelement in elements)
            {
                Xunit.Assert.Contains("test", newelement.Text);
            }
        }

        [TestMethod]
        public void TestmethodGIT()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://github.com");
            var elements = driver.FindElements(By.CssSelector("col-md-7 text-center text-md-left "));
            foreach (var element in elements)
            {
                Xunit.Assert.Contains("developers", element.Text);
            }
           // driver.Close();
        }
    }
}
