using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomewordTest
{
    [TestFixture]
    class AvtoTests
    {
        string Url;
        IWebDriver driver;
        string username;
        string password;
        string falseusername;
        string falsepassword;
        GenerateWords Genword = new GenerateWords();

        [OneTimeSetUp]

        public void OneTimeSetUp()
        {
            
            username = Genword.GetRandomWord(6) ;
            password = Genword.GetRandomWord(6);
            falseusername = Genword.GetRandomWord(5);
            falsepassword = Genword.GetRandomWord(5);
            Url = "http://newtours.demoaut.com/mercurywelcome.php";
        }

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl(Url);
    }
        [Test]
        public void PositiveTest()
        {
            
            SucRegistr sucRegistr = new SucRegistr(driver);
            MainPage MainPage = new MainPage(driver);
            RegisterPage registerPage = new RegisterPage(driver);
            SucRegistr SucRegistr = new SucRegistr(driver);
            SingInPage singInPage = new SingInPage(driver);
            FirstAccountPage firstAccountPage = new FirstAccountPage(driver);
            SecondAccountPage secondAccountPage = new SecondAccountPage(driver);
            ThirdAccountPage thirdAccountPage = new ThirdAccountPage(driver);
            LastAccountPage lastAccountPage = new LastAccountPage(driver);
       
            registerPage = MainPage.RegisterButtonClick();
            SucRegistr = registerPage.AllMetods(username, password);
            singInPage = sucRegistr.SingInClick();
            firstAccountPage = singInPage.AllMetods(username,password);
            secondAccountPage = firstAccountPage.ContinueClick();
            thirdAccountPage = secondAccountPage.ContinueClick();
            lastAccountPage = thirdAccountPage.ContinueClick();
            singInPage = lastAccountPage.SingInClick();
       
            Assert.IsTrue(singInPage.Resualt());
        }

        [Test]
        public void SingInCheckTest()
        {
            MainPage MainPage = new MainPage(driver);
            FirstAccountPage firstAccountPage = new FirstAccountPage(driver);

            MainPage.EnterData(username,password);
            firstAccountPage = MainPage.SingInButtonClick();
            Assert.IsTrue(firstAccountPage.Resualt());
        }

        [Test]
        public void SingInCheckFalseTest()
        {
            MainPage MainPage = new MainPage(driver);
            FirstAccountPage firstAccountPage = new FirstAccountPage(driver);
            MainPage.EnterData(falseusername, falsepassword);
            firstAccountPage = MainPage.SingInButtonClick();
            Assert.IsFalse(firstAccountPage.Resualt());
        }
        [Test]
        public void SingInCheckEmptyTest()
        {
            MainPage MainPage = new MainPage(driver);
            FirstAccountPage firstAccountPage = new FirstAccountPage(driver);
            firstAccountPage = MainPage.SingInButtonClick();
            Assert.IsFalse(firstAccountPage.Resualt());
        }

        [TearDown]

       public void TearDown()
        {
            driver.Quit();
        }
    }
}
