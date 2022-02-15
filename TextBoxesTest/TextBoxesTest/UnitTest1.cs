using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewTestProjectNUnit
{
    public class Tests
    {

        WebDriver? _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void OutputFieldTest()
        {
            string url = "https://demoqa.com/text-box";
            string fullNameLocator = "//*[@id='userName']";
            string eMailLocator = "//*[@id='userEmail']";
            string currentAdressLocator = "//*[@id='currentAddress']";
            string permanentAddressLocator = "//*[@id='permanentAddress']";
            string submitButtonLocator = "//*[@id='submit']";
            string outputFieldLocator = "//*[@id='output']";
            string outputNameLocator = "//*[@id='name']";

            string userName = "New User";
            string userEmail = "mail@mail.com";
            string currentAddress = "Belarus, Minsk";
            string permanetAddress = "some other address";


            _driver.Url = url;

            WebElement fullNameField = (WebElement)_driver.FindElement(By.XPath(fullNameLocator));

            fullNameField.SendKeys(userName);

            WebElement eMailField = (WebElement)_driver.FindElement(By.XPath(eMailLocator));

            eMailField.SendKeys(userEmail);

            WebElement currentAdressField = (WebElement)_driver.FindElement(By.XPath(currentAdressLocator));

            currentAdressField.SendKeys(currentAddress);

            WebElement permanentAddressField = (WebElement)_driver.FindElement(By.XPath(permanentAddressLocator));

            permanentAddressField.SendKeys(permanetAddress);

            WebElement submitButton = (WebElement)_driver.FindElement(By.XPath(submitButtonLocator));

            submitButton.Click();

            WebElement outputField = (WebElement)_driver.FindElement(By.XPath(outputFieldLocator));

            WebElement nameOutput = (WebElement)_driver.FindElement(By.XPath(outputNameLocator));

            var inputName = nameOutput.Text;
            Assert.AreEqual("Name:" + userName, inputName);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

    }
}