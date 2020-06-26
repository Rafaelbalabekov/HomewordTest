using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewordTest
{
    class SecondAccountPage
    {
        private IWebDriver _driver;

        public SecondAccountPage(IWebDriver driver)
        {
            _driver = driver;
        }


        private By _continueButton = By.Name("reserveFlights");


        public ThirdAccountPage ContinueClick()
        {
            _driver.FindElement(_continueButton).Click();
            return new ThirdAccountPage(_driver);
        }
    }

}
