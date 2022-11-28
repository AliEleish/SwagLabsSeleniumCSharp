using OpenQA.Selenium;
using SeleniumWithCSharp.PagesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Pages
{
    public class LoginPage : PageObjectBase
    {

        private By usernameBy = By.CssSelector("input#user-name");
        private By passwordBy = By.CssSelector("input[data-test='password']");
        private By loginButtonBy = By.Id("login-button");
        private By lockedOutLoginErrorMessageBy = By.CssSelector("h3[data-test='error']");

        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        public void enterTextInUsername(string username)
        {
            enterText(driver.FindElement(usernameBy), username);
        }
        public void enterTextInPassword(string password)
        {
            enterText(driver.FindElement(passwordBy), password);
        }

        public void ClickOnLoginButton() {
            ClickOnElement(driver.FindElement(loginButtonBy));
        }

        public void loginSuccessfully(string username, string password) {
            enterTextInUsername(username);
            enterTextInPassword(password);
            Thread.Sleep(3000);
            ClickOnLoginButton();

        }

        public string getLockedoutLoginErrorMessage() { 
            return getText(findElementInPage(lockedOutLoginErrorMessageBy));
        
        
        }
    }
}