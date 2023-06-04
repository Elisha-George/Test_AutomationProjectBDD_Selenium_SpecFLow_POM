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
        public string url = "https://magento.softwaretestingboard.com/";


        public void DriverInitialize()
        {
            chromeDriver = new ChromeDriver();
        }

        public void classDispose()
        {
           // chromeDriver = new ChromeDriver();
           // chromeDriver.Close();
           //chromeDriver.Dispose();
            chromeDriver.Quit();

        }

        public void OpenBrowserAndUrl()
        {
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Navigate().GoToUrl(url);
        }

        //A method for all page class

       /* public void MainLogin()
        {

        }*/

    }
}
