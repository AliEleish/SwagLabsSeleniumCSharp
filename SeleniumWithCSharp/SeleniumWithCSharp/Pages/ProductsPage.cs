using OpenQA.Selenium;
using SeleniumWithCSharp.PagesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Pages
{
    public class ProductsPage : PageObjectBase
    {
        private By productsPageTitleBy = By.CssSelector("span.title");
        private By shoppingCartBy = By.CssSelector("a.shopping_cart_link");

        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }


        public bool ValidateProductsPageTitleIsDisplayed()
        {
            return isDisplayed(driver.FindElement(productsPageTitleBy));
        }

        public string GetProductsPageTitleText()
        {
            return getText(driver.FindElement(productsPageTitleBy));
        }

        public void selectProduct(string idText){

            ClickOnElement(findElementInPage(By.CssSelector(idText)));
        }

        public void clickOnShoppingCardIcon() {
            ClickOnElement(findElementInPage(shoppingCartBy));
        }

    }
}
        


    

