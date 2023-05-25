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
    internal class OrderPlace_PageClass: Baseclass
    {



        //variables 
        string email = "elisha_ali@hotmail.com";
        string firstname = "Elisha";
        string lastname = "George";
        string company = "Google";
        string street_1 = "House # 25";
        string street_2 = "Street # 25";
        string street_3 = "Brooklyn";
        string city = "New York";
        string zipcode = "9823-2332";
        string state = "Florida";
        string country = "United States";
        string phone = "0223-4221232";

        //THINGS TO DO
        // radio button
        //dropdown 


        //locators

        By Size = By.XPath("//body/div[1]/main[1]/div[3]/div[1]/div[2]/div[3]/div[1]/div[1]/ol[1]/li[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]");
        By Color = By.XPath("//div[@id='option-label-color-93-item-50']");
        By Cart = By.XPath("//header/div[2]/div[1]/a[1]");
        By btn_proceesCheckout = By.Id("top-cart-btn-checkout");
        By btn_PlaceOrder = By.XPath("//*[@id=\"checkout-payment-method-load\"]/div/div/div[2]/div[2]/div[4]/div/button");

        //Form Locators
        By Email = By.XPath("//*[@id=\"customer-email\"]");
        By FirstName = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/div[1]/div[1]/input[1]");
        By LastName = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/div[2]/div[1]/input[1]");
        By Company = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/div[3]/div[1]/input[1]");
        By Str_Add_1 = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/fieldset[1]/div[1]/div[1]/div[1]/input[1]");
        By Str_Add_2 = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/fieldset[1]/div[1]/div[2]/div[1]/input[1]");
        By Str_Add_3 = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/fieldset[1]/div[1]/div[3]/div[1]/input[1]");
        By City = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/div[4]/div[1]/input[1]");
        By ZipCode = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/div[7]/div[1]/input[1]");
        By Phone = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/div[9]/div[1]/input[1]");
        By RadioBtn_Ship = By.XPath("//tbody/tr[1]/td[1]/input[1]");
        By btn_Next = By.XPath("//body/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[2]/div[1]/div[3]/form[1]/div[3]/div[1]/button[1]");




        //Success Message
        By Success = By.XPath("//span[contains(text(),'Thank you for your purchase!')]");
        By Warning = By.XPath("//div[contains(text(),'You need to choose options for your item.')]");

       

        //Methods

        public void select_features()
        {
            Actions hover = new Actions(chromeDriver);
            hover.MoveToElement(chromeDriver.FindElement(By.XPath("//body/div[1]/main[1]/div[3]/div[1]/div[2]/div[3]/div[1]/div[1]/ol[1]/li[1]/div[1]"))).Perform();
            Thread.Sleep(1000);
            chromeDriver.FindElement(Size).Click();
            chromeDriver.FindElement(Color).Click();
            

        }
       
        //Method for Hover Add to Cart button

        public void addToCart()
        {
            //code for hover ont he div, so that the the button will appear
            Actions hover = new Actions(chromeDriver);
            hover.MoveToElement(chromeDriver.FindElement(By.XPath("//body/div[1]/main[1]/div[3]/div[1]/div[2]/div[3]/div[1]/div[1]/ol[1]/li[1]/div[1]"))).Perform();
            Thread.Sleep(1000);
            //Click on the button of att to cart
            chromeDriver.FindElement(By.XPath("//body/div[1]/main[1]/div[3]/div[1]/div[2]/div[3]/div[1]/div[1]/ol[1]/li[1]/div[1]/div[1]/div[4]/div[1]/div[1]/form[1]/button[1]")).Click();
            Thread.Sleep(4000);


        }
        public void CartProceed()
        {
            
            chromeDriver.FindElement(Cart).Click();
            chromeDriver.FindElement(btn_proceesCheckout).Click();


        }
        public void fill_form()
        {
            Thread.Sleep(7000);
            chromeDriver.FindElement(Email).SendKeys(email);
            chromeDriver.FindElement(FirstName).SendKeys(firstname);
            chromeDriver.FindElement(LastName).SendKeys(lastname);
            chromeDriver.FindElement(Company).SendKeys(company);
            chromeDriver.FindElement(Str_Add_1).SendKeys(street_1);
            chromeDriver.FindElement(Str_Add_2).SendKeys(street_2);
            chromeDriver.FindElement(Str_Add_3).SendKeys(street_3);
            chromeDriver.FindElement(City).SendKeys(city);

            //DropDown

            SelectElement selectState = new SelectElement(chromeDriver.FindElement(By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/div[5]/div[1]/select[1]")));
            selectState.SelectByText(state);
            chromeDriver.FindElement(ZipCode).SendKeys(zipcode);
            //Dropdown
            SelectElement selectCountry = new SelectElement(chromeDriver.FindElement(By.XPath("//body[1]/div[1]/main[1]/div[2]/div[1]/div[2]/div[4]/ol[1]/li[1]/div[2]/form[2]/div[1]/div[8]/div[1]/select[1]")));
            selectCountry.SelectByText(country);

            chromeDriver.FindElement(Phone).SendKeys(phone);

            chromeDriver.FindElement(RadioBtn_Ship).Click();
            chromeDriver.FindElement(btn_Next).Click();

        }
        public void placeOrder()
        {
            Thread.Sleep(4000);
            chromeDriver.FindElement(btn_PlaceOrder).Click();
        }
        public void validateSuccess()
        {
            Thread.Sleep(6000);

            Thread.Sleep(1000);
            string validateMessage = chromeDriver.FindElement(Success).Text;
            Assert.AreEqual("Thank you for your purchase!", validateMessage);

        }
        public void checkWarning()
        {
            Thread.Sleep(1000);
            string WarningMessage = chromeDriver.FindElement(Warning).Text;
            Assert.AreEqual("You need to choose options for your item.", WarningMessage);

        }
        public void emptyCart_CheckError()
        {
            
            Thread.Sleep(1000);
            string WarningMessage = chromeDriver.FindElement(By.Id("super_attribute[143]-error")).Text;
            Assert.AreEqual("This is a required field.", WarningMessage);
        }
        public void empty_addtoCart()
        {
            chromeDriver.FindElement(By.XPath("//button[@id='product-addtocart-button']")).Click();

        }






    }
}
