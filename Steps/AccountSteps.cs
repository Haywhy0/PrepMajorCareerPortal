using FluentAssertions;
using OpenQA.Selenium;
using PrepMajorCareerPortal.Hooks;
using PrepMajorCareerPortal.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace PrepMajorCareerPortal.Steps
{
    [Binding]
    public class AccountSteps
    {
        public IWebDriver driver = WebHook.driver;
        AccountPage _accountPage = new AccountPage();

        [Given(@"I Navigate to  https://career\.prepmajor\.com")]
        public void GivenINavigateToHttpsCareer_Prepmajor_Com()
        {
            driver.Navigate().GoToUrl("https://career.prepmajor.com");
        }
        
        [When(@"I click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            _accountPage.ClickSigninButton();
        }
        
        //[When(@"a log in page is displayed")]
        //public void WhenALogInPageIsDisplayed()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        [When(@"I enter the username ""(.*)""")]
        public void WhenIEnterTheUsername(string UserName)
        {
            _accountPage.TypeToUserName("Username");
        }
        
        [When(@"I enter my password ""(.*)""")]
        public void WhenIEnterMyPassword(string p0)
        {
            _accountPage.TypeToPassword("Password");
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            _accountPage.ClickLoginButon();
        }
        
        [Then(@"accountpage is displayed")]
        public void ThenAccountpageIsDisplayed()
        {
            _accountPage.IsAccountPageDisplayed().Should().BeTrue();
        }
        
        [Then(@"I click on log out")]
        public void ThenIClickOnLogOut()
        {
            _accountPage.ClickLogOutButton();
        }
        
        [Then(@"registration dashboard is displayed")]
        public void ThenRegistrationDashboardIsDisplayed()
        {
           _accountPage.IsRegistrationDashboardDisplayed();
        }
    }
}
