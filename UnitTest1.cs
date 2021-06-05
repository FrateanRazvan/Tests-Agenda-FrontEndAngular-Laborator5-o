using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        private IWebDriver _driver;
        [SetUp]
        public void SetupDriver()
        {
            _driver = new ChromeDriver("D:\\ASP.NET\\chromedriver_win32");
        }

        [Test]
        public void Login()
        {
            _driver.Url = "http://localhost:4200";

            bool findUsernameInputField = false;

           foreach(var div in _driver.FindElements(By.TagName("div"))){
            
                if(div.Text == "Welcome, to the Agenda App")
                {
                    findUsernameInputField = true;
                }
            }
            

            Assert.IsTrue(findUsernameInputField);
        }
    }
}