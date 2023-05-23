using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace POM_Class_1.BaseClass
{
   public class Baseclass
    {
        public ChromeDriver chromeDriver;
        public string url = "https://magento.softwaretestingboard.com/customer/account/login/referer/aHR0cHM6Ly9tYWdlbnRvLnNvZnR3YXJldGVzdGluZ2JvYXJkLmNvbS8%2C/";


        public void DriverInitialize()
        {
            chromeDriver = new ChromeDriver();
        }

        public void classDispose()
        {
            //chromeDriver = new ChromeDriver();
            chromeDriver.Close();
            chromeDriver.Dispose();
        }

        public void OpenBrowserAndUrl()
        {
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(url);
        }

    }
}
