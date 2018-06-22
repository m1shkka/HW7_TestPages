using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace Google_POM
{
    class Program
    {
           static void Main(string[] args)
           {
            string text="";
            Console.WriteLine("input text");
            text = Console.ReadLine();

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys(text);
            element.Submit();
           }
    }
}
