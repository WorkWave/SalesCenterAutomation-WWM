using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using WorkWave.PestPac.TA.Model;
using WorkWave.TA.TestEngine;
using WorkWave.PestPac.TA.SharedData;
namespace WorkWave.PestPac.TA.Steps
{
    [Binding]
    public class LoginSteps : TestSteps
    {
        LoginPage loginPage = new LoginPage();
        MainPage mainPage = new MainPage();

        LoginFields _loginFields;
        public LoginSteps(LoginFields loginFields)
        {
            _loginFields = loginFields;
        }
        [When(@"Login attempt")]
        public void WhenLoginAttempt()
        {
            mainPage = loginPage.LoginAttempt(SalesCenterSupport.DefaultUsername,
                SalesCenterSupport.DefaultPassword);
        }

        [When(@"Login attempt")]
        public void WhenLoginAttempt(Table table)
        {
            LoginFields loginFields = table.CreateInstance<LoginFields>();
            mainPage = loginPage.LoginAttempt(loginFields.Username, loginFields.Password);
        }

        [When(@"Login attempt (.*) (.*)")]
        public void WhenLoginAttempt(string username, string password)
        {

            mainPage = loginPage.LoginAttempt(username, password);
        }

        [Then(@"Login successful")]
        public void ThenLoginSuccessful()
        {
            Assert.True(mainPage.IsLoaded(), "Failed to verify the main page loaded after login attempt");
        }

        [Then(@"Login failed due to invalid credentials (.*)")]
        public void LoginFailedDueToInvalidCredentials(string expectedError)
        {
            Assert.True(loginPage.IsLoaded(), "Failed login should return back to login page, but did not");

            string actualError = loginPage.GetInvalidCredentialsError();
            StringAssert.Contains(expectedError, actualError);
        }

       
        #region hooks

        [AfterScenario()]
        [Scope(Tag = "Smoke_WWP")]
        public void ThenLocationIsDeleted()
        {

            // if (licensePage.IsLoaded())
            {
                //    licensePage.OverrideLogout();

            }

        }
        #endregion hooks
    }
}
