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
    public class TestWithChrome
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
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

            string exceptionMessage = null;
            try
            {

                driver.Navigate().GoToUrl("https://seacertsblazor.azurewebsites.net/");

                driver.Manage().Window.Size = new System.Drawing.Size(1296, 1000);

                driver.FindElement(By.LinkText("Next")).Click();
                //Thread.Sleep(500);
 

                WaitIfElementIsNotLoaded_ById("CDN-Surname");//***************

                driver.FindElement(By.Id("CDN-Surname")).Click();

                driver.FindElement(By.Id("CDN-Surname")).SendKeys("Phung");

                driver.FindElement(By.Id("CDN-Givennames")).Click();

                driver.FindElement(By.Id("CDN-Givennames")).SendKeys("Tibo");

                driver.FindElement(By.Id("CDN-Initials")).Click();

                driver.FindElement(By.Id("CDN-Initials")).SendKeys("Tb");

                driver.FindElement(By.Id("CDN-DateOfBirth")).Click();

                driver.FindElement(By.Id("CDN-DateOfBirth")).SendKeys("27-05-1990");

                driver.FindElement(By.Id("CDN-Nationalty")).Click();

                driver.FindElement(By.Id("CDN-Nationalty")).SendKeys("Canada");

                driver.FindElement(By.CssSelector(".btn:nth-child(7)")).Click();

                //Thread.Sleep(1000);


                WaitIfElementIsNotLoaded_ById("ApartmentUnitNumber");  //**************
                driver.FindElement(By.Id("ApartmentUnitNumber")).Click();

                driver.FindElement(By.Id("ApartmentUnitNumber")).SendKeys("1");

                driver.FindElement(By.Id("StreetNumber")).Click();

                driver.FindElement(By.Id("StreetNumber")).SendKeys("330");

                driver.FindElement(By.Id("Street")).Click();

                driver.FindElement(By.Id("Street")).SendKeys("Spark");

                driver.FindElement(By.Id("City")).Click();

                driver.FindElement(By.Id("City")).SendKeys("Ottawa");

                driver.FindElement(By.Id("Province")).Click();

                driver.FindElement(By.Id("Province")).SendKeys("Ontario");

                driver.FindElement(By.Id("PostalCode")).Click();

                driver.FindElement(By.Id("PostalCode")).SendKeys("A1B 2C3");

                driver.FindElement(By.Id("Country")).Click();

                driver.FindElement(By.Id("Country")).SendKeys("Canada");

                driver.FindElement(By.Id("Telephone")).Click();

                driver.FindElement(By.Id("Telephone")).SendKeys("613-1234-567");

                driver.FindElement(By.Id("Email")).Click();

                driver.FindElement(By.Id("Email")).SendKeys("tibo@tc.gc.ca");
 
                driver.FindElement(By.CssSelector(".btn:nth-child(11)")).Click();


                WaitIfElementIsNotLoaded_ByLinkText("Next");
                driver.FindElement(By.LinkText("Next")).Click();


                WaitIfElementIsNotLoaded_ByLinkText("Submit"); 
                //  Thread.Sleep(500);
                driver.FindElement(By.LinkText("Submit")).Click();
                driver.FindElement(By.CssSelector(".pagedetails")).Click();
                driver.Close();
                driver.Quit();

                exceptionMessage = "Test Successful !";
            }
            catch(Exception ex)
            {
                exceptionMessage = ex.Message +"\"" +
                                    ex.StackTrace ;

                
            }



            return exceptionMessage;
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


        //                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        //        wait.Until(driver.FindElement(By.LinkText("Next")));

    }

}
