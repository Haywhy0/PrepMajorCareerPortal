using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PrepMajorCareerPortal.Hooks
{
    [Binding]
    public  class WebHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver(@"C:\Users\badmu\source\repos\PrepMajorCareerPortal\bin\Debug\netcoreapp");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
