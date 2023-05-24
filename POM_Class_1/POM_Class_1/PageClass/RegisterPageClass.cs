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
using OpenQA.Selenium.Chrome;

namespace POM_Class_1.PageClass
{
    internal class RegisterPageClass: Baseclass
    {
        //Variables valid information   

        string valid_FirstName = "james";
        string Valid_LastName = "harrison";
        string valid_email = "harry_gmail@gmail.com";
        string valid_password = "harry@123";
        string valid_confirmPassword = "harry@123";


        //Variables Invalid information   

        string Invalid_FirstName = "123456";
        string Invalid_LastName = "123456";
        string Invalid_email = "elisha@gmail.com";
        string Invalid_password = "testing@123";
        string Invalid_confirmPassword = "testing@123";


        //Locators

        By FirstName = By.Id("firstname");
        By LastName = By.Id("lastname");
        By Email = By.Id("email_address");
        By Password = By.Id("password");
        By ConfirmPassword = By.Id("password-confirmation");

        By CreateButton = By.CssSelector("body.customer-account-create.page-layout-1column:nth-child(2) div.page-wrapper:nth-child(4) main.page-main div.columns:nth-child(4) div.column.main form.form.create.account.form-create-account:nth-child(3) div.actions-toolbar:nth-child(4) div.primary > button.action.submit.primary");


       public void goto_url()
        {
            chromeDriver.FindElement(By.XPath("//header/div[1]/div[1]/ul[1]/li[3]/a[1]")).Click();
        }

        public void ValidRegister()
        {
            chromeDriver.FindElement(FirstName).SendKeys(valid_FirstName);
            chromeDriver.FindElement(LastName).SendKeys(Valid_LastName);;
            chromeDriver.FindElement(Email).SendKeys(valid_email);
            chromeDriver.FindElement(Password).SendKeys(valid_password);
            chromeDriver.FindElement(ConfirmPassword).SendKeys(valid_confirmPassword);
        }
        
        public void InvlaidSing_inInfo()
        {
            chromeDriver.FindElement(FirstName).SendKeys(valid_FirstName);
            chromeDriver.FindElement(LastName).SendKeys(Valid_LastName); ;
            chromeDriver.FindElement(Email).SendKeys(Invalid_email);
            chromeDriver.FindElement(Password).SendKeys(Invalid_password);
            chromeDriver.FindElement(ConfirmPassword).SendKeys(Invalid_confirmPassword);
        }

        public void ClickCreate()
        {
            chromeDriver.FindElement(CreateButton).Click();
        }

        public void SuccessfulMessageValidation()
        {
            Thread.Sleep(4000);
            string validationText = chromeDriver.FindElement(By.XPath("//span[contains(text(),'My Account'  )]")).Text;
            Assert.AreEqual("My Account", validationText);

        }

        public void Unsuccessful_invalidmessage()
        {
            Thread.Sleep(300);
            string validationText = chromeDriver.FindElement(By.XPath("//body/div[1]/main[1]/div[2]/div[2]/div[1]/div[1]")).Text;
            Assert.AreEqual("There is already an account with this email address. If you are sure that it is your email address, click here to get your password and access your account.", validationText);
        }

        public void Empty_validation()
        {
            Thread.Sleep(300);
            string validationText = chromeDriver.FindElement(By.Id("firstname-error")).Text;
            Assert.AreEqual("This is a required field.", validationText);
        }
    }
}
