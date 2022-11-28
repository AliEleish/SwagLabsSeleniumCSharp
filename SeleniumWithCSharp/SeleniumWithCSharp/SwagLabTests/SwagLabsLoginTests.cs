using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithCSharp.BaseTest;
using SeleniumWithCSharp.Pages;

namespace SeleniumWithCSharp.SwagLabTests {
    [TestFixture]
    public class SwagLabsLoginTests : WebTestBase
    {

        LoginPage? loginPageObj;
        ProductsPage? productsPageObj;
        ITakesScreenshot? tsc;

        [Test]
        [TestCaseSource(nameof(testDataProvider))]
        public void testSuccessfulLogin(String url)
        {


            loginPageObj = new LoginPage(driver);
            loginPageObj.loginSuccessfully("standard_user", "secret_sauce");

            productsPageObj = new ProductsPage(driver);
            Assert.IsTrue(productsPageObj.ValidateProductsPageTitleIsDisplayed());
            Assert.That(productsPageObj.GetProductsPageTitleText, Is.EqualTo("PRODUCTS"));


        }
        public static IList testDataProvider()
        {

            ArrayList urlsList = new ArrayList();
            urlsList.Add("https://www.saucedemo.com/");
            return urlsList;

        }

        [Test]
        public void testLockedOutLogin()
        {
                
                loginPageObj = new LoginPage(driver);
                loginPageObj.loginSuccessfully("locked_out_user", "secret_sauce");
                Assert.IsTrue(loginPageObj.getLockedoutLoginErrorMessage().Equals("Epic sadface: Sorry, this user has been locked out."));
                
        }
        
    }
}
