using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NTest
{
    public class Tests
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("file:///C:/Temp/ispp45/ISRPO/ISRPO/LabWork7/LW%2310/LabWork10.html");
        }

        [Test]
        public void TestGetImage()
        {
            IWebElement searchInput = driver.FindElement(By.Id("searchText"));
            IWebElement submitButton = driver.FindElement(By.Id("submit"));

            searchInput.SendKeys("https://avatars.mds.yandex.net/i?id=836329e0ba8b22146ca4ecae5f1bd050b14372af-4359838-images-thumbs&n=13");
            submitButton.Click();

            Assert.Equals(true, true);
        }

        [Test]
        public void TestGetErrorMessage()
        {
            IWebElement messageButton = driver.FindElement(By.CssSelector(".button-class"));

            messageButton.Click();

            IWebElement welcomeMessage = driver.FindElement(By.Id("error-message"));
            ClassicAssert.AreEqual("Ошибка через 3 секунды: nonExistentVariable is not defined", welcomeMessage.Text);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
