using OpenQA.Selenium;
using SeleniumWithCSharp.PagesBase;
using System;


namespace SeleniumWithCSharp.Pages
{
   public class CheckOutPage : PageObjectBase
    {
        private By checkoutPageTitle = By.CssSelector("span.title");
        private By firstNameTxtField = By.Id("first-name");
        private By lastNameTxtField = By.XPath("//input[@data-test ='lastName']");
        private By zipCodeTxtField = By.CssSelector("input[id^='postal']");
        private By continueButton = By.Id("continue");
        public CheckOutPage(IWebDriver driver) : base(driver) { 
        }

        public string getCheckoutPageTitleText(){

            return findElementInPage(checkoutPageTitle).Text;
        }
        public void enterTextInFirstNameField(string firstname)
        { 
             enterText(findElementInPage(firstNameTxtField) , firstname);
        }

        public void enterTextInLastNameField(string lastname)
        {
            enterText(findElementInPage(lastNameTxtField), lastname);
        }

        public void enterTextInZipCodeField(string zipcode)
        {
            enterText(findElementInPage(zipCodeTxtField), zipcode);
        }

        public void entercheckoutFormData(string firstname, string lastname, string zipCode) {
            enterTextInFirstNameField(firstname);
            enterTextInLastNameField(lastname);
            enterTextInZipCodeField(zipCode);
        
        }

        public void clickOnContinueButton() {
            ClickOnElement(findElementInPage(continueButton));
        
        }

    }
}
