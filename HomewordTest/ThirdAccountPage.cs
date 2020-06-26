using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewordTest
{
    class ThirdAccountPage
    {
        IWebDriver _driver;
        public ThirdAccountPage(IWebDriver driver)
        {
            _driver = driver;

        }

        private By _securePurchaseButton = By.Name("buyFlights");


        public LastAccountPage ContinueClick()
        {
            _driver.FindElement(_securePurchaseButton).Click();
            return new LastAccountPage(_driver);
        }
    }
}
