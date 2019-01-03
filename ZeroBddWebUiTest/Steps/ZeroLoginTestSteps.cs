using System;
using TechTalk.SpecFlow;

namespace ZeroBddWebUiTest.Steps
{
    [Binding]
    public class ZeroLoginTestSteps
    {
        [Given(@"I am at zerobank login page")]
        public void GivenIAmAtZerobankLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter correct login")]
        public void WhenIEnterCorrectLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter correct password")]
        public void WhenIEnterCorrectPassword()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press Sign in")]
        public void WhenIPressSignIn()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
