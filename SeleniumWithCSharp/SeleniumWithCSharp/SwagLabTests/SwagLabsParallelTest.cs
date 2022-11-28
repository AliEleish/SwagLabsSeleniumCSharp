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
    public class SwagLabsParallelTest : WebTestBase
    {

        LoginPage? loginPageObj;
        ProductsPage? productsPageObj;


        [Test, Category("UAT Testing"), Category("Module1")]
        public void ProblemUser_LoginTest1()
        {
            loginPageObj = new LoginPage(driver);
            loginPageObj.loginSuccessfully("problem_user", "secret_sauce");
            productsPageObj = new ProductsPage(driver);
            Assert.IsTrue(productsPageObj.ValidateProductsPageTitleIsDisplayed());
            Assert.That(productsPageObj.GetProductsPageTitleText, Is.EqualTo("PRODUCTS"));

        }


        [Test, Category("UAT Testing"), Category("Module1")]
        public void ProblemUser_LoginTest2()
        {
            loginPageObj = new LoginPage(driver);
            loginPageObj.loginSuccessfully("problem_user", "secret_sauce");
            productsPageObj = new ProductsPage(driver);
            Assert.IsTrue(productsPageObj.ValidateProductsPageTitleIsDisplayed());
            Assert.That(productsPageObj.GetProductsPageTitleText, Is.EqualTo("PRODUCTS"));

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void ProblemUser_LoginTest3()
        {
            loginPageObj = new LoginPage(driver);
            loginPageObj.loginSuccessfully("problem_user", "secret_sauce");
            productsPageObj = new ProductsPage(driver);
            Assert.IsTrue(productsPageObj.ValidateProductsPageTitleIsDisplayed());
            Assert.That(productsPageObj.GetProductsPageTitleText, Is.EqualTo("PRODUCTS"));

        }


        [Test, Category("UAT Testing"), Category("Module1")]
        public void ProblemUser_LoginTest4()
        {
            loginPageObj = new LoginPage(driver);
            loginPageObj.loginSuccessfully("problem_user", "secret_sauce");
            productsPageObj = new ProductsPage(driver);
            Assert.IsTrue(productsPageObj.ValidateProductsPageTitleIsDisplayed());
            Assert.That(productsPageObj.GetProductsPageTitleText, Is.EqualTo("PRODUCTS"));

        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void ProblemUser_LoginTest5()
        {
            loginPageObj = new LoginPage(driver);
            loginPageObj.loginSuccessfully("problem_user", "secret_sauce");
            productsPageObj = new ProductsPage(driver);
            Assert.IsTrue(productsPageObj.ValidateProductsPageTitleIsDisplayed());
            Assert.That(productsPageObj.GetProductsPageTitleText, Is.EqualTo("PRODUCTS"));

        }
    }
}
