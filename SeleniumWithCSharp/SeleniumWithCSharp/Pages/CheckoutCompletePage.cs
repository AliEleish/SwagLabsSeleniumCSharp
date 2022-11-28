using OpenQA.Selenium;
using SeleniumWithCSharp.PagesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Pages
{
    public class CheckoutCompletePage : PageObjectBase 
    {
        private By checkoutCompletePageTitle = By.CssSelector("span.title");
        private By orderPlacedSuccessfulMessage = By.CssSelector("h2[class='complete-header']");
        public CheckoutCompletePage(IWebDriver driver) : base(driver) { 
   
        }
        public bool verifyCheckOutCompletePageTitleIsDisplayed()
        {
          return  isDisplayed(findElementInPage(checkoutCompletePageTitle));
        }

        public bool verifyOrderPlaceSuccessfulMessageIsDisplayed()
        {
           return isDisplayed(findElementInPage(orderPlacedSuccessfulMessage));
        }

        public string getCheckoutCompletPageTitleText()
        {
            return getText(findElementInPage(checkoutCompletePageTitle));
        }

        public string getOrderPlaceSuccessfulMessageText()
        {
            return getText(findElementInPage(orderPlacedSuccessfulMessage));
        }
    }
}
