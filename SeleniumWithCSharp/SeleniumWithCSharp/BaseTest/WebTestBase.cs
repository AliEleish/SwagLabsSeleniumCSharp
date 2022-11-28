using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using SeleniumWithCSharp.Utils;
using NUnit.Framework.Interfaces;

namespace SeleniumWithCSharp.BaseTest
{
    [TestFixture]
    public class WebTestBase
    {

        protected IWebDriver? driver;
        protected DriverUtility driverUtil;
        private const string URL = "https://www.saucedemo.com/";
        private const string BROWSER = "Chrome";

        [OneTimeSetUp]
        public void OneTimeSetUp() {
          driverUtil =  new DriverUtility();
          ExtentTestManager.createParentTest(GetType().Name);

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ExtentService.getExtent().Flush();
        }

        [SetUp]
        public void SetUp()
        {
            ExtentTestManager.createChildTest(TestContext.CurrentContext.Test.Name);
            driver = driverUtil.GetDriver(BROWSER);
            driver.Navigate().GoToUrl(URL);

        }
        [TearDown]
        public  void tearDown()
        {
            try
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var errorMessage = string.IsNullOrEmpty(TestContext.CurrentContext.Result.Message)
                ? ""
                    : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.Message);

                var stackTrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                ? ""
                    : string.Format("<pre>{0}</pre>", TestContext.CurrentContext.Result.StackTrace);

                switch (status)
                {

                    case TestStatus.Failed:
                        ReportLog.fail("Test Failed");
                        ReportLog.fail(errorMessage);
                        ReportLog.fail(stackTrace);
                        ReportLog.fail("Screenshot", captureScreenshot(TestContext.CurrentContext.Test.Name));
                        break;

                    case TestStatus.Skipped:
                        ReportLog.skip("Test Skipped");
                        break;

                    case TestStatus.Passed:
                        ReportLog.pass("Test Passed");
                        break;

                    default:
                        break;
                }
            }
            catch (Exception e) {

                throw new Exception("Exception: " + e);
            }
            finally
            {
                driver.Quit();
            }
        }
        public MediaEntityModelProvider captureScreenshot(string name) {

            var screenShot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenShot,name).Build();
        }
    }
}
