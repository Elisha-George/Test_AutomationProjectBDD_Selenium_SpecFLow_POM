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
    internal class ContactUSPageClass: Baseclass
    {
        //Variables
        string name = "tester";
        string email = "tester@gmail.com";
        string phone = "0200-2002299";
        string message = "hey There! I hate your products";


        //Locators

        By Name = By.Id("name");
        By Email = By.Id("email");
        By Phone = By.Id("telephone");
        By Message = By.Id("comment");

        By link_contactUs = By.XPath("//a[contains(text(),'Contact Us')]");
        By btn_submit = By.XPath("//body/div[1]/main[1]/div[3]/div[1]/form[1]/div[1]/div[1]/button[1]");


        //Methods

        public void navigate_contactus()
        {
            chromeDriver.FindElement(link_contactUs).Click();
        }

        public void Fill_Fullform()
        {
            chromeDriver.FindElement(Name).SendKeys(name);
            chromeDriver.FindElement(Email).SendKeys(email);
            chromeDriver.FindElement(Phone).SendKeys(phone);
            chromeDriver.FindElement(Message).SendKeys(message);

        }
        public void notRequiredData()
        {            
            chromeDriver.FindElement(Phone).SendKeys(phone);
        }
        public void submitForm()
        {
            chromeDriver.FindElement(btn_submit).Click();
        }

        public void validateSuccessResponce()
        {
            Thread.Sleep(2000);
            string validationText = chromeDriver.FindElement(By.XPath("//div[contains(text(),'Thanks for contacting us with your comments and qu')]")).Text;
            Assert.AreEqual("Thanks for contacting us with your comments and questions. We'll respond to you very soon.", validationText);
        }
        public void checkError()
        {
            Thread.Sleep(2000);
            string validationText = chromeDriver.FindElement(By.Id("name-error")).Text;
            Assert.AreEqual("This is a required field.", validationText);
        }
    }
}
