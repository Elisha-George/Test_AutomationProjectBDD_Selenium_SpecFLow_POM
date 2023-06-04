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
    internal class AdvanceSearch: Baseclass
    {
        /*1 item were found using the following search criteria
            Product Name: Radiant Tee
            SKU: WS12
            Description: Hemp, Spandex, Organic Cotton
            Short Description: Tee
            Price: 10 - 30*/


        //Variables: 

        string product_name = "Radiant Tee";
        string sku = "WS12";
        string description = "Hemp, Spandex, Organic Cotton";
        string short_description = "Tee";
        string price_1 = "10";
        string price_2 = "30";

        string invalidPrice_1 = "abcd";
        string invalidPrice_2 = "abcd";


        //Locators 

        By lnk_advanceSearch = By.XPath("//body[1]/div[1]/footer[1]/div[1]/ul[1]/li[3]/a[1]");

        By ProductName = By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/form[1]/fieldset[1]/div[1]/div[1]/input[1]");
        By SKU = By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/form[1]/fieldset[1]/div[2]/div[1]/input[1]");
        By Desc = By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/form[1]/fieldset[1]/div[3]/div[1]/input[1]");
        By ShortDesc = By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/form[1]/fieldset[1]/div[3]/div[1]/input[1]");
        By FirstPrice = By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/form[1]/fieldset[1]/div[5]/div[1]/div[1]/div[1]/div[1]/input[1]");

        By SecondPrice = By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/form[1]/fieldset[1]/div[5]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]");

        By EmptyError = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[2]/div[1]/div[1]/div[1]");
        
        
        By SuccessMessage = By.XPath("");
       
        
        By InvalidFieldError = By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/form[1]/fieldset[1]/div[5]/div[1]/div[1]/div[1]/div[1]/div[1]");

        By btn_Search = By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/form[1]/div[1]/div[1]/button[1]");

        //Methods

        //Please enter a valid number.
        //Enter a search term and try again.

        public void navigateToAdvanceSearch()
        {
            chromeDriver.FindElement(lnk_advanceSearch).Click();
        }
        public void FillFormDetails()
        {
            Thread.Sleep(3000);

            chromeDriver.FindElement(ProductName).SendKeys(product_name);
            chromeDriver.FindElement(SKU).SendKeys(sku);
            chromeDriver.FindElement(Desc).SendKeys(description);
            chromeDriver.FindElement(ShortDesc).SendKeys(short_description);
            chromeDriver.FindElement(FirstPrice).SendKeys(price_1);
            chromeDriver.FindElement(SecondPrice).SendKeys(price_2);

        }
        public void ClickSearch()
        {
            chromeDriver.FindElement(btn_Search).Click();
        }
        public void ValidateSuccess()
        {
            Thread.Sleep(4000);
            string Successs = chromeDriver.FindElement(By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/div[2]")).Text;
            Assert.AreEqual("1 item were found using the following search criteria", Successs);
        }
        public void InvliadPrice()
        {
            Thread.Sleep(2000);
            chromeDriver.FindElement(FirstPrice).SendKeys(invalidPrice_1);
            chromeDriver.FindElement(SecondPrice).SendKeys(invalidPrice_2);
        }
        public void FillNameOnly()
        {
            Thread.Sleep(2000);
            chromeDriver.FindElement(ProductName).SendKeys(product_name);
        }
        public void CheckEmptyError()
        {
            Thread.Sleep(4000);
            string EmptyError = chromeDriver.FindElement(By.XPath("//body[1]/div[1]/main[1]/div[2]/div[2]/div[1]/div[1]/div[1]")).Text;
            Assert.AreEqual("Enter a search term and try again.", EmptyError);
        }
        public void CheckPriceError()
        {
            Thread.Sleep(4000);
            string PriceError = chromeDriver.FindElement(By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/form[1]/fieldset[1]/div[5]/div[1]/div[1]/div[1]/div[1]/div[1]")).Text;
            Assert.AreEqual("Enter a search term and try again.", EmptyError);

        }



    }
}
