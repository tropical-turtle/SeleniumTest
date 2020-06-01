using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;



namespace SeleniumTest
{

    [TestFixture]
    public class TestWithFirefox

    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public string Test_CDN_Application()
        {
            string possibleException = null;
            try
            {
                driver.Navigate().GoToUrl("https://seacertsblazor.azurewebsites.net/");
                driver.Manage().Window.Size = new System.Drawing.Size(1296, 1000);
                driver.FindElement(By.LinkText("Next")).Click();
                driver.FindElement(By.Id("CDN-Surname")).Click();
                driver.FindElement(By.Id("CDN-Surname")).SendKeys("Delanois");
                driver.FindElement(By.Id("CDN-Givennames")).SendKeys("Paul");

                driver.FindElement(By.Id("CDN-Initials")).SendKeys("Pd");
                driver.FindElement(By.Id("CDN-DateOfBirth")).Click();
                driver.FindElement(By.Id("CDN-DateOfBirth")).SendKeys("01-06-2090");
                driver.FindElement(By.Id("CDN-Nationalty")).Click();
                driver.FindElement(By.Id("CDN-Nationalty")).SendKeys("Canada");
                driver.FindElement(By.CssSelector(".custom-control:nth-child(1)")).Click();
                driver.FindElement(By.CssSelector(".btn:nth-child(7)")).Click();

                WaitIfElementIsNotLoaded_ById("ApartmentUnitNumber");

                driver.FindElement(By.Id("ApartmentUnitNumber")).Click();
                driver.FindElement(By.Id("ApartmentUnitNumber")).SendKeys("1");
                driver.FindElement(By.Id("StreetNumber")).Click();
                driver.FindElement(By.Id("StreetNumber")).SendKeys("330");
                driver.FindElement(By.Id("Street")).SendKeys("Spark");
                driver.FindElement(By.Id("POBox")).Click();
                driver.FindElement(By.Id("POBox")).SendKeys("101");
                driver.FindElement(By.Id("City")).Click();
                driver.FindElement(By.Id("City")).SendKeys("Ottawa");
                driver.FindElement(By.Id("Province")).Click();
                driver.FindElement(By.Id("Province")).SendKeys("Ontario");
                driver.FindElement(By.CssSelector("form:nth-child(1) > .form-group:nth-child(2)")).Click();
                driver.FindElement(By.Id("PostalCode")).Click();
                driver.FindElement(By.Id("PostalCode")).SendKeys("A1B 2C3");
                driver.FindElement(By.Id("Country")).Click();
                driver.FindElement(By.Id("Country")).SendKeys("Canada");
                driver.FindElement(By.CssSelector(".form-group:nth-child(7)")).Click();
                driver.FindElement(By.Id("Telephone")).Click();
                driver.FindElement(By.Id("Telephone")).SendKeys("6134567898");
                driver.FindElement(By.Id("Email")).Click();
                driver.FindElement(By.Id("Email")).SendKeys("paul@tc.gc.ca");
                driver.FindElement(By.CssSelector(".btn:nth-child(11)")).Click();
                driver.FindElement(By.LinkText("Next")).Click();
                driver.FindElement(By.LinkText("Submit")).Click();

                driver.Close();
                driver.Quit();

                possibleException = "Test completed Successfully !";

            }
            catch(Exception ex)
            {
                possibleException = ex.Message + "\"" + ex.StackTrace;

            }

            return possibleException;
        }


        private void WaitIfElementIsNotLoaded_ByLinkText(string linkText)
        {
            bool isNotLoaded = true;

            while (isNotLoaded)
            {
                try
                {
                    driver.FindElement(By.LinkText(linkText));
                    isNotLoaded = false;
                }
                catch (Exception ex)
                {
                    Thread.Sleep(100);
                }

            }
            Thread.Sleep(300);
        }

        private void WaitIfElementIsNotLoaded_ById(string Id)
        {
            bool isNotLoaded = true;

            while (isNotLoaded)
            {
                try
                {
                    driver.FindElement(By.Id(Id));
                    isNotLoaded = false;
                }
                catch (Exception ex)
                {
                    Thread.Sleep(100);
                }

            }
            Thread.Sleep(300);
        }
    }



}
