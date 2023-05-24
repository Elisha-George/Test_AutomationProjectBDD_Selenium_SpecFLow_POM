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
    public class LoginPageClass: Baseclass
    {
        //Variables



        string valid_userId = "elisha@gmail.com";
        string Valid_password = "testing@124";


        string Invalid_userId = "testing@gmail.com";
        string InValid_password = "test@124";



        //Locators

        By UserId = By.Id("email");
        By Passcode = By.Id("pass");
        By LoginButton = By.Id("send2");
      public void goto_url()
        {
            chromeDriver.FindElement(By.XPath("//header/div[1]/div[1]/ul[1]/li[2]/a[1]")).Click();
        }
        public void ValidLogin ()
        {
            chromeDriver.FindElement(UserId).SendKeys(valid_userId);
            chromeDriver.FindElement(Passcode).SendKeys(Valid_password);
            chromeDriver.FindElement(LoginButton).Click();
            
        }

        public void InvalidLogin()
        {
            chromeDriver.FindElement(UserId).SendKeys(Invalid_userId);
            chromeDriver.FindElement(Passcode).SendKeys(InValid_password);
            chromeDriver.FindElement(LoginButton).Click();

        }

        public void  SuccessfulMessageValidation()
        {
            Thread.Sleep(4000);
            string validationText = chromeDriver.FindElement(By.XPath("//header/div[1]/div[1]/ul[1]/li[1]/span[1]")).Text;
            Assert.AreEqual("Welcome, elisha ali!", validationText);
            
        }

        public void UnsuccessfulMessageValidation()
        {
            Thread.Sleep(3000);
            string validationText = chromeDriver.FindElement(By.XPath("//div[contains(text(),'The account sign-in was incorrect or your account ')]")).Text;
            Assert.AreEqual("The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later.", validationText);

        }


    }
}
