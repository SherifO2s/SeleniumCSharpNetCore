using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNetCore
{
    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Url = "http://executeautomation.com/sign-in";
            
            Assert.Fail();
            Assert.Pass();
        }
    }
}