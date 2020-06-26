using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewordTest
{
    class SingInPage
    {
        private IWebDriver _driver;

        public SingInPage(IWebDriver driver)
        {
            _driver = driver;

        }

        private By _usernameInput = By.Name("userName");
        private By _passwordInput = By.Name("password");
        private By _submitButton = By.Name("login");

        private void EnterEmail(string username)
        {
            _driver.FindElement(_usernameInput).SendKeys(username);

        }
        private void EnterPassword(string password)
        {
            _driver.FindElement(_passwordInput).SendKeys(password);
        }
        public bool Resualt()
        {
            if (_driver.FindElements(By.XPath("//*[contains(text(), 'Welcome back to')]")).Count != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public FirstAccountPage AllMetods(string username, string password)
        {
            EnterEmail(username);
            EnterPassword(password);
            _driver.FindElement(_submitButton).Click();
            return new FirstAccountPage(_driver);
        }
    }
}
