using OpenQA.Selenium;
using PrepMajorCareerPortal.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrepMajorCareerPortal.PageObjects
{
    class AccountPage
    {
        public IWebDriver driver;
        private By SigninButton = By.CssSelector("ul.nav:nth - child(3) > li:nth - child(5) > div:nth - child(1) > ul:nth - child(1) > li:nth - child(1) > div:nth - child(2) > div:nth - child(1) > div:nth - child(3) > a:nth - child(1)");
        private By UserName = By.Id("user_login351096");
        private By Password = By.Id("user_pass351096");
        private By LoginButton = By.CssSelector("#ControlForm_351096 > label:nth-child(3) > input:nth-child(1)");
        private By LogOutButton = By.CssSelector(".account-menu > li:nth-child(10) > a:nth-child(1)");
        public AccountPage()
        {
            driver = WebHook.driver;
        }

        public void ClickSigninButton()
        {
            driver.FindElement(SigninButton).Click();
        }

        public void TypeToUserName(string v)
        {
            driver.FindElement(UserName).SendKeys("UserName");
        }
         public void TypeToPassword(string v)
        {
            driver.FindElement(Password).SendKeys("Password");
        }

        public void ClickLoginButon()
        {
            driver.FindElement(LoginButton).Click();
        }

        public bool IsAccountPageDisplayed()
        {
            return driver.Url.Contains ("Skills Percentage");
        }

        public void ClickLogOutButton()
        {
            driver.FindElement(LogOutButton).Click();
        }

        public bool IsRegistrationDashboardDisplayed()
        {
            return driver.Url==("https://career.prepmajor.com/candidate-dashboard/");
        }

        
        
        
        

        
       
        
    }
}
