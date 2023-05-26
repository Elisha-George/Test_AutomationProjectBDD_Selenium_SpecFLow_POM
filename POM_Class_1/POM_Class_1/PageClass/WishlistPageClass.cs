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
using OpenQA.Selenium.Interactions;
using System.Drawing;

namespace POM_Class_1.PageClass
{
    internal class WishlistPageClass: Baseclass
    {
        // variables
        string userId = "elisha@gmail.com";
        string password = "testing@124";

        //locators

        By WishList = By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[1]/div/div/div[4]/div/div[2]/a[1]");
        By ProductDiv = By.XPath("//*[@id=\"maincontent\"]/div[3]/div/div[2]/div[3]/div/div/ol/li[1]/div");
        
        By ErrorMsg = By.XPath("//*[@id=\"maincontent\"]/div[2]/div[2]/div/div/div");
        By Email = By.Id("email");
        By Password = By.Id("pass");
        By btn_Login = By.Id("send2");

        By SuccessMsg = By.XPath("//*[@id=\"maincontent\"]/div[1]/div[2]/div/div/div");

        //To validtae if one product is added to the wish list
        By NoOfItmes = By.XPath("//*[@id=\"maincontent\"]/div[2]/div[1]/div[3]/div/p/span");


            
        //methods


        public void addItemsToWishlist()
        {
            Actions hover = new Actions(chromeDriver);
            hover.MoveToElement(chromeDriver.FindElement(ProductDiv)).Perform();
            Thread.Sleep(1000);

            chromeDriver.FindElement(WishList).Click();


        }
        public void checkErrorMessage()
        {
            Thread.Sleep(5000);
            string errorMsg =  chromeDriver.FindElement(ErrorMsg).Text;
            Assert.AreEqual("You must login or register to add items to your wishlist.", errorMsg);

        }
        public void loginToAddWishlist()
        {
            chromeDriver.FindElement(Email).SendKeys(userId);
            chromeDriver.FindElement(Password).SendKeys(password);

            chromeDriver.FindElement(btn_Login).Click();

        }
        public void validateSuccessrMessage()
        {
            Thread.Sleep(5000);
            string errorMsg = chromeDriver.FindElement(SuccessMsg).Text;
            Assert.AreEqual("Radiant Tee has been added to your Wish List. Click here to continue shopping.", errorMsg);

        }
    }
}
