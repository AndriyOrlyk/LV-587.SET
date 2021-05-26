using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver browser = new ChromeDriver();
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            browser.Navigate().GoToUrl("http:www.google.com");
            browser.Manage().Window.Maximize();
            browser.FindElement(By.Name("q")).Clear();
            browser.FindElement(By.Name("q")).SendKeys("filmix zone");

            browser.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            browser.FindElement(By.XPath("//div[@class='TbwUpd NJjxre']")).Click();

            browser.FindElement(By.Id("auth")).Click();
            browser.FindElement(By.Name("login_name")).SendKeys("vanya.martiniv777");
            browser.FindElement(By.Name("login_password")).SendKeys("Vanya@775577vanya1111");
            browser.FindElement(By.ClassName("enter")).Click();
            System.Threading.Thread.Sleep(1000); //Only for presentation
            browser.FindElement(By.Id("search")).SendKeys("Побег из Шоушенка" + Keys.Enter);
            System.Threading.Thread.Sleep(1000); //Only for presentation
            browser.FindElement(By.ClassName("go")).SendKeys(Keys.Enter);
            browser.FindElement(By.XPath("//a[@href='https://filmix.zone/filmi/drama/5898-pobeg-iz-shoushenka-the-shawshank-redemption-1994.html']")).Click();
            
            Assert.AreEqual("Побег из Шоушенка", browser.FindElement(By.ClassName("name")).Text);

            browser.Quit();
        }
    }
}
