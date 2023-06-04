using NUnit.Framework;
using OpenQA.Selenium;
using POM_Class_1.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace POM_Class_1.PageClass
{
    internal class LogoutPageClass: Baseclass
    {


        string valid_userId = "elisha@gmail.com";
        string Valid_password = "testing@124";


        string Invalid_userId = "testing@gmail.com";
        string InValid_password = "test@124";



        //Locators

        By UserId = By.Id("email");
        By Passcode = By.Id("pass");
        By LoginButton = By.Id("send2");

        By btnLogout = By.Id("");

        //Methods

        public void goto_url()
        {
            chromeDriver.FindElement(By.XPath("//header/div[1]/div[1]/ul[1]/li[2]/a[1]")).Click();
        }

        public void ValidLogin()
        {
            chromeDriver.FindElement(UserId).SendKeys(valid_userId);
            chromeDriver.FindElement(Passcode).SendKeys(Valid_password);
            chromeDriver.FindElement(LoginButton).Click();

        }

        public void click_logout()
        {
            //change logout
            chromeDriver.FindElement(btnLogout).Click();
        }
        public void SuccessfulMessageValidation()
        {
            //change the x path
            Thread.Sleep(4000);
            string validationText = chromeDriver.FindElement(By.XPath("//header/div[1]/div[1]/ul[1]/li[1]/span[1]")).Text;
            Assert.AreEqual("Welcome, elisha ali!", validationText);

        }


    }
}
