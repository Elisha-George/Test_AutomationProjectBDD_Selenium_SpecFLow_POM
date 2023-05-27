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

        string product_name = "";
        string sku = "";
        string description = "";
        string short_description = "";
        int price_1 = 10;
        int price_2 = 30;

        string invalidPrice_1 = "abcd";
        string invalidPrice_2 = "abcd";


        //Locators
        By lnk_advanceSearch = By.XPath("");

        By ProductName = By.XPath("");
        By SKU = By.XPath("");
        By Desc = By.XPath("");
        By ShortDesc = By.XPath("");
        By FirstPrice = By.XPath("");
        By SecondPrice = By.XPath("");

        By EmptyError = By.XPath("//body[1]/div[1]/main[1]/div[2]/div[2]/div[1]/div[1]/div[1]");
        By SuccessMessage = By.XPath("");
        By InvalidFieldError = By.XPath("//body[1]/div[1]/main[1]/div[3]/div[1]/form[1]/fieldset[1]/div[5]/div[1]/div[1]/div[1]/div[1]/div[1]");


        //Methods

        //Please enter a valid number.
        //Enter a search term and try again.

        public void navigateToAdvanceSearch()
        {

        }
        public void FileFormDetails()
        {

        }
        public void ClickSearch()
        {

        }
        public void ValidateSuccess()
        {

        }
        public void InvliadPrice()
        {

        }
        public void FillNameOnly()
        {

        }
        public void CheckEmptyError()
        {

        }
        public void CheckPriceError()
        {

        }



    }
}
