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
        [Test]
        public void Login()
        {

            IWebElement SignINBUtton = driver.FindElement(By.XPath("/html/body/div[@class='container']/div[@class='row'][3]/div[@class='col-sm-6 text-center'][1]/a"));
            if (SignINBUtton.Displayed && SignINBUtton.Enabled)
            {
                SignINBUtton.Click();

            }
            System.Threading.Thread.Sleep(4000);

            IWebElement formSignIN = driver.FindElement(By.Name("username"));
            if (formSignIN.Displayed && formSignIN.Enabled)
            {
                formSignIN.SendKeys(TestData_Username);

            }
            IWebElement passwordSignIn = driver.FindElement(By.Name("password"));
            if (passwordSignIn.Displayed && passwordSignIn.Enabled)
            {
                passwordSignIn.SendKeys(TestData_Password);

            }
            IWebElement loginButton = driver.FindElement(By.Name("login"));
            if (loginButton.Displayed && loginButton.Enabled)
            {
                loginButton.Click();

            }
            System.Threading.Thread.Sleep(4000);


        }
        [Test]
        public void CheckCartIsEmty()
        {
            Login();
            IWebElement viewedShopingCart = driver.FindElement(By.XPath("/html/body/div[@class='navbar navbar-default']/div[@class='container']/ul[@class='nav navbar-nav navbar-right']/li[1]/a"));
            if (viewedShopingCart.Displayed && viewedShopingCart.Enabled)
            {
                viewedShopingCart.Click();

            }
            IWebElement alert = driver.FindElement(By.XPath("/html/body/div[@class='alert alert-warning']"));
            if (alert.Displayed && alert.Enabled)
            {
                Assert.Pass();

            }
            else
            {
                Assert.Fail("Test nije prosao'");
            }
            

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
