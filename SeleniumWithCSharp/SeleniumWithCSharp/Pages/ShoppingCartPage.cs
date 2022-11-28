using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumWithCSharp.PagesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.Pages
{
   public class ShoppingCartPage : PageObjectBase 
    {
        
        [FindsBy(How = How.CssSelector, Using = "span.title")]
        public IWebElement ShoppingCartPageTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button[data-test='checkout']")]
        public IWebElement CheckOutButton { get; set; }

        
        [FindsBy(How = How.CssSelector, Using = "div.cart_item")]
        public IList<IWebElement> ProductsInCart { get; set; }

        public ShoppingCartPage(IWebDriver driver) : base(driver) {
            PageFactory.InitElements(driver, this);
                }

        public string getPageTitleText() {

            return ShoppingCartPageTitle.Text;
        }

        public void clickOnCheckoutButton() {
            ClickOnElement(CheckOutButton);
        }

        public int getNumberOfProductInCart() { 
           return ProductsInCart.Count;
        }



    }
}
