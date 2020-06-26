using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewordTest
{
    class FirstAccountPage
    {
        private IWebDriver _driver;

        public FirstAccountPage(IWebDriver driver)
        {
            _driver = driver;

        }


        private By _continueButton = By.Name("findFlights");


        public bool Resualt()
        {
            if (_driver.FindElements(By.XPath("//*[contains(text(), 'Use our Flight Finder')]")).Count != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public SecondAccountPage ContinueClick()
        {
            _driver.FindElement(_continueButton).Click();
            return new SecondAccountPage(_driver);
        }
    }
}
