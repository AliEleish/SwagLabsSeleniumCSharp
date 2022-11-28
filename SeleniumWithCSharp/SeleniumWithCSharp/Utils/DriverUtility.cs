using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Utils
{
    public class DriverUtility
    {
        protected static IWebDriver? driver;

        public  IWebDriver GetDriver(string browserName)
        {

            try
            {
                driver = setDriver(browserName);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
            return driver;
        }

        private  IWebDriver setDriver(string browserName)
        {

            switch (browserName.ToLower())
            {

                case "chrome":
                    driver = InitChromeDriver();
                    ReportLog.pass("Chrome launched successfully");
                    break;
                case "firefox":
                    driver = InitFireFoxDriver();
                    ReportLog.pass("FireFox launched successfully");
                    break;
                default:
                    Assert.Fail("Invalid Browser");
                    break;
            }
            driver.Manage().Window.Maximize();
            return driver;
        }
        private  IWebDriver InitChromeDriver() => new ChromeDriver();

        private  IWebDriver InitFireFoxDriver() {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            service.Host = "::1";
            return new FirefoxDriver(service);
        }

    }
}