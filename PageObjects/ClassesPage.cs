using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;

namespace DriveBCPOM.PageObjects
{
    class ClassesPage
    {
        private IWebDriver _driver;
        public ClassesPage(IWebDriver driver) => _driver = driver;
        string Title => (_driver.Title);
        public string GetTitleText() => Title;
    }
}
