using OpenQA.Selenium;
using SeleniumWithCSharp.PagesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Pages
{
    public  class CheckoutOverviewPage : PageObjectBase
    {
        private By CheckoutOverViewPageTitle = By.CssSelector("span.title");
        private By finishButton = By.Id("finish");
        public CheckoutOverviewPage(IWebDriver driver) : base(driver) {
        
        }

        public string getCheckOutPageOverviewTitleText()
        {
            return getText(findElementInPage(CheckoutOverViewPageTitle));
        }

        public void clickOnFinishButton() {
            scrollToElement(findElementInPage(finishButton));
            ClickOnElement(findElementInPage(finishButton));
        }
    }
}
