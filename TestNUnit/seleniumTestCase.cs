using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using Selenium;

namespace SeleniumTests
{
    [TestFixture]
    public class seleniumTestCase
    {
        private ISelenium selenium;
        private StringBuilder verificationErrors;

        [SetUp]
        public void SetupTest()
        {
            selenium = new DefaultSelenium("localhost", 4444, "*chrome", "https://www.google.com/");
            selenium = new DefaultSelenium("localhost", 4444, "*firefox C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe", "https://www.google.com/");
            selenium.Start();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                selenium.Stop();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheSeleniumTestCaseTest()
        {
            selenium.Open("/?gws_rd=ssl");
            selenium.Type("id=gbqfq", "selenium");
            selenium.Click("id=gbqfb");
            selenium.Click("link=Selenium - Web Browser Automation");
            selenium.WaitForPageToLoad("9000");
            selenium.Type("id=q", "c#");
            selenium.Click("id=submit");
            selenium.WaitForPageToLoad("9000");
            selenium.Click("xpath=(//a[contains(text(),'Downloads')])[2]");
            selenium.WaitForPageToLoad("9000");
            selenium.Click("//a[contains(text(),'source\n  code')]");
            selenium.WaitForPageToLoad("9000");
        }
    }
}
