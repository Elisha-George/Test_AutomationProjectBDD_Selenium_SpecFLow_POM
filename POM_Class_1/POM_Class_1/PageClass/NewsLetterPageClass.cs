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
    internal class NewsLetterPageClass: Baseclass
    {
        //Variables 

        //new Email Address
        string new_email = "TDD_tester@gmail.com";

        //Registered email_address
        string Reg_email = "maju@gmail.com";

        //Locators
        By Email = By.Id("newsletter");
        By Btn_Subscribe = By.XPath("//body/div[1]/footer[1]/div[1]/div[1]/div[2]/form[1]/div[2]/button[1]");
        



        //Methods
        public void NewsLetter_New()
        {
            chromeDriver.FindElement(Email).SendKeys(new_email);
        }

        public void NewsLetter_Registered()
        {
            chromeDriver.FindElement(Email).SendKeys(Reg_email);
        }
        public void clickSubscribe()
        {
            chromeDriver.FindElement(Btn_Subscribe).Click();
        }
        public void validate_successMsg()
        {
            Thread.Sleep(6000);
            string validatation_text = chromeDriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/div[2]/div[2]/div[1]/div[1]/div[1]")).Text;
            Assert.AreEqual("Thank you for your subscription.", validatation_text);
        }
        public void validate_ErrorMsg()
        {
            Thread.Sleep(6000);
            string Error_text = chromeDriver.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/div[2]/div[2]/div[1]/div[1]/div[1]")).Text;
            Assert.AreEqual("This email address is already subscribed.", Error_text);
        }

        public void validate_EmptyMsg()
        {
           
            string Error_text = chromeDriver.FindElement(By.Id("newsletter-error")).Text;
            Assert.AreEqual("This is a required field.", Error_text);
        }





    }
}
