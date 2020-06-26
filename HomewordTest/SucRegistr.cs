using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewordTest
{
    class SucRegistr
    {
        private IWebDriver _driver;

        public SucRegistr(IWebDriver driver)
        {
            _driver = driver;

        }
        private By _singinbutton = By.XPath("//a[@href='mercurysignon.php']");

        public SingInPage SingInClick()
        {
            _driver.FindElement(_singinbutton).Click();
            return new SingInPage(_driver);
        }


    }
}
