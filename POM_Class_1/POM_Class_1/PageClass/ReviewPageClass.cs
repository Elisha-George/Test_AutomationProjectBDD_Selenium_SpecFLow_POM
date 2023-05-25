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

namespace POM_Class_1.PageClass
{
    internal class ReviewPageClass: Baseclass
    {
        // Varaiables
        string nickname = "Testing_spy";
        string summary = "Review About the Product";
        string review = "This is the best product and I like it very much ........";


        //Locators 

        By btn_Review = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[3]/div[1]/div[5]/a[1]");

        By Rating = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[3]/div[1]/div[6]/div[2]/div[2]/form[1]/fieldset[1]/fieldset[1]/div[1]/div[1]/div[1]/div[1]/label[5]");
        By NickName = By.Id("nickname_field");
        By Summary = By.Id("summary_field");
        By Review = By.Id("review_field");

        By btn_submit = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[3]/div[1]/div[6]/div[2]/div[2]/form[1]/div[1]/div[1]/button[1]");
        By Success = By.XPath("//*[@id=\"maincontent\"]/div[1]/div[2]/div/div/div");
        By Error = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[3]/div[1]/div[6]/div[2]/div[2]/form[1]/fieldset[1]/fieldset[1]/div[1]/div[2]");


        public void goToProductDetail()
        {
            //code for hover ont he div, so that the the button will appear
            Actions hover = new Actions(chromeDriver);
            hover.MoveToElement(chromeDriver.FindElement(By.XPath("//body/div[1]/main[1]/div[3]/div[1]/div[2]/div[3]/div[1]/div[1]/ol[1]/li[1]/div[1]"))).Perform();
            Thread.Sleep(1000);
            //Click on the button of att to cart
            chromeDriver.FindElement(By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/div[2]/div[3]/div[1]/div[1]/ol[1]/li[1]/div[1]")).Click();
            Thread.Sleep(4000);
        }

        public void clickReviewsSection()
        {
            chromeDriver.FindElement(btn_Review).Click();
            Thread.Sleep(2000);

        }
        public void reviewFormSubmission()
        {
            chromeDriver.FindElement(Rating).Click();
            chromeDriver.FindElement(NickName).SendKeys(nickname);
            chromeDriver.FindElement(Summary).SendKeys(summary);
            chromeDriver.FindElement(Review).SendKeys(review);

        }
        public void clickSubmit()
        {
            chromeDriver.FindElement(btn_submit).Click();
            Thread.Sleep(4000);
        }
        public void validateSuccessMessage()
        {
            string message = chromeDriver.FindElement(Success).Text;
            Assert.AreEqual("You submitted your review for moderation.", message);
        }

        public void checkErrorMessage()
        {
            string message = chromeDriver.FindElement(Error).Text;
            Assert.AreEqual("Please select one of each of the ratings above.", message);
        }

    }
}
