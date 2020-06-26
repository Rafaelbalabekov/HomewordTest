using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewordTest
{
    class RegisterPage
    {
        private IWebDriver _driver;

        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;

        }

        private By _usernameInput = By.XPath("//input[@id ='email']");
        private By _passwordInput = By.XPath("//input[@name='password']");
        private By _confirmPasswordInput = By.XPath("//input[@name='confirmPassword']");
        private By _submitButton = By.XPath("//input[@src='/images/forms/submit.gif']");
        private void EnterEmail(string username)
        {
            _driver.FindElement(_usernameInput).SendKeys(username);

           
        }
        private void EnterPassword(string password)
        {
            _driver.FindElement(_passwordInput).SendKeys(password);
            _driver.FindElement(_confirmPasswordInput).SendKeys(password);
        }


        public SucRegistr AllMetods(string username, string password)
        {
            EnterEmail(username);
            EnterPassword(password);
            //SubmitClick();
            _driver.FindElement(_submitButton).Click();
            return new SucRegistr(_driver);
        }
    }
}
