using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewordTest
{
    class LastAccountPage
    {
        IWebDriver _driver;
        public LastAccountPage(IWebDriver driver)
        {
            _driver = driver;

        }

        private By _logOutButton = By.XPath("//*[@src='/images/forms/Logout.gif']");

        public SingInPage SingInClick()
        {
            _driver.FindElement(_logOutButton).Click();
            return new SingInPage(_driver);
        }
    }
}
