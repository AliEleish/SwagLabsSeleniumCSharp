using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCSharp.BaseTest;
using SeleniumWithCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithCSharp.SwagLabTests
{
    [TestFixture]
    public class SwagLabOrderItemsTests : WebTestBase
    {
       
        LoginPage? loginPageObj;
        ProductsPage? productsPageObj;
        ShoppingCartPage? shoppingCartPageObj;
        CheckOutPage? checkOutPageObj;
        CheckoutOverviewPage? checkoutOverviewPageObj;
        CheckoutCompletePage? checkoutCompletePageObj;
     

        [TestCase]
        public void testItemsSuccessfulOrder() {
                
                loginPageObj = new LoginPage(driver);
                loginPageObj.loginSuccessfully("standard_user", "secret_sauce");
                productsPageObj = new ProductsPage(driver);
                productsPageObj.selectProduct("#add-to-cart-sauce-labs-bike-light");
                productsPageObj.clickOnShoppingCardIcon();
                shoppingCartPageObj = new ShoppingCartPage(driver);
                Assert.That(shoppingCartPageObj.getPageTitleText().Equals("YOUR CART"));
                Assert.That(shoppingCartPageObj.getNumberOfProductInCart(), Is.EqualTo(1));
                shoppingCartPageObj.clickOnCheckoutButton();
                checkOutPageObj = new CheckOutPage(driver);
                Assert.IsTrue(checkOutPageObj.getCheckoutPageTitleText().Equals("CHECKOUT: YOUR INFORMATION"));
                checkOutPageObj.entercheckoutFormData("Mohamed", "Adel", "00000");
                checkOutPageObj.clickOnContinueButton();
                checkoutOverviewPageObj = new CheckoutOverviewPage(driver);
                Assert.IsTrue(checkoutOverviewPageObj.getCheckOutPageOverviewTitleText().Equals("CHECKOUT: OVERVIEW"));
                checkoutOverviewPageObj.clickOnFinishButton();
                checkoutCompletePageObj = new CheckoutCompletePage(driver);
                Assert.IsTrue(checkoutCompletePageObj.verifyCheckOutCompletePageTitleIsDisplayed());
                Assert.IsTrue(checkoutCompletePageObj.getCheckoutCompletPageTitleText().Equals("CHECKOUT: COMPLETE!"));
                Assert.IsTrue(checkoutCompletePageObj.verifyOrderPlaceSuccessfulMessageIsDisplayed());
                Assert.IsTrue(checkoutCompletePageObj.getOrderPlaceSuccessfulMessageText().Equals("THANK YOU FOR YOUR ORDER"));
            }
        }

    }

