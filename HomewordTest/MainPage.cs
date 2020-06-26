using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewordTest
{
    class MainPage
    {
        private IWebDriver _driver;
        private By _registerlink = By.XPath("//td[@width='77']");

        private By _usernameInput = By.Name("userName");
        private By _passwordInput = By.Name("password");
        private By _singinButton = By.Name("login");

        public MainPage(IWebDriver driver)
        {
            _driver = driver;

        }

        private void EnterUsername(string username)
        {
            _driver.FindElement(_usernameInput).SendKeys(username);


        }
        private void EnterPassword(string password)
        {
            _driver.FindElement(_passwordInput).SendKeys(password);
        }

        public void EnterData(string username, string password)
        {
            _driver.FindElement(_usernameInput).SendKeys(username);
            _driver.FindElement(_passwordInput).SendKeys(password);

        }
        public FirstAccountPage SingInButtonClick()
        {
            _driver.FindElement(_singinButton).Click();
            return new FirstAccountPage(_driver);
        }
        public RegisterPage RegisterButtonClick()
        {
            _driver.FindElement(_registerlink).Click();
            return new RegisterPage(_driver);
        }
    }
}
