using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.PagesBase
{
    public class PageObjectBase
    {
       protected IWebDriver driver;

        protected PageObjectBase(IWebDriver driver) { 
        
        this.driver = driver;
        }

        public void ClickOnElement(IWebElement element) { 
         element.Click();
        }

        public void enterText(IWebElement element,string text)
        {
            element.SendKeys(text);
        }

        public bool isDisplayed(IWebElement element) {
            return element.Displayed;
        }

        public string getText(IWebElement element) {
            return  element.Text;
        }

        public IWebElement findElementInPage(By element) {
            return driver.FindElement(element);
        }
     
        public void scrollToElement(IWebElement element) {
            Actions action = new Actions(driver);
            action.MoveToElement(element);
            action.Perform();
        }

        public void clearElement(IWebElement element) { 
          element.Clear();
        }


    }
}
