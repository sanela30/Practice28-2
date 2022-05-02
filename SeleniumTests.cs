using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Practice28_2
{
    internal class SeleniumTests
    {
        IWebDriver driver;
        WebDriverWait wait;
        private string TestData_Email = "nekiemail@hdmi.com";    //UsefulFunction.RandomEmail();
        private string TestData_Password = "SuperSnaznaSifra123"; //UsefulFunction.RandomPassword();
        private string TestData_Username = "korisnickoIme";

        [Test]
      public void Registration()
       {
            IWebElement register = driver.FindElement(By.XPath("//div[@class='col-sm-6 text-center'][2]/a"));
            if (register.Displayed && register.Enabled)
            {
                register.Click();
            }

            IWebElement nameFromForm = driver.FindElement(By.Name("ime"));
            if (nameFromForm.Displayed && nameFromForm.Enabled)
            {
                nameFromForm.SendKeys("Petar");

            }
            IWebElement lastnameFromForm = driver.FindElement(By.Name("prezime"));
            if (lastnameFromForm.Displayed && lastnameFromForm.Enabled)
            {
                lastnameFromForm.SendKeys("Petrovic");

            }
            IWebElement emailFromForm = driver.FindElement(By.Name("email"));
            if (emailFromForm.Displayed && emailFromForm.Enabled)
            {
                emailFromForm.SendKeys(TestData_Email);

            }
            IWebElement usernameFromForm = driver.FindElement(By.Name("korisnicko"));
            if (usernameFromForm.Displayed && usernameFromForm.Enabled)
            {
                usernameFromForm.SendKeys(TestData_Username);

            }
            IWebElement passwordFromForm = driver.FindElement(By.Name("lozinka"));
            if (passwordFromForm.Displayed && passwordFromForm.Enabled)
            {
                passwordFromForm.SendKeys(TestData_Password);

            }
            IWebElement confirmPasswordFromForm = driver.FindElement(By.Name("lozinkaOpet"));
            if (confirmPasswordFromForm.Displayed && confirmPasswordFromForm.Enabled)
            {
                confirmPasswordFromForm.SendKeys(TestData_Password);

            }

            IWebElement registerBUtton = driver.FindElement(By.ClassName("nemari"));
            if (registerBUtton.Displayed && registerBUtton.Enabled)
            {
                registerBUtton.Click();

            }
            System.Threading.Thread.Sleep(4000);
        }

      [SetUp]
      public void SetUp()
      {

        driver = new ChromeDriver();
        wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://shop.qa.rs/");

       }


      [TearDown]
      public void TearDown()
      {
        driver.Close();
      }
    }
}
