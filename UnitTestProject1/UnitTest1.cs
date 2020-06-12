using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver(@"c:\");
            driver.Navigate().GoToUrl("https://www.globalsqa.com/samplepagetest/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("g2599-name")).SendKeys("Hello");
            driver.FindElement(By.Id("g2599-email")).SendKeys("ozturk@gmail.com");

            driver.FindElement(By.ClassName("checkbox-multiple")).Click();

            driver.FindElement(By.Name("g2599-comment")).SendKeys("Test Comments");

            

            driver.Close();
        }
    }
}
