using System;
using System.Reflection;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using log4net;
using WorkWave.TA.TestEngine;
using WorkWave.TA.TestEngine.PageFactory;
using System.Threading;

namespace WorkWave.PestPac.TA.Model
{

    class LoginPage : IWebPage
    {

        #region Page Factory

        [FindsBy(How = How.XPath, Using = "//form[@action='#']")]
        private IWebElement LoginForm { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Username { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement LoginButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = ".copyright")]
        private IList<IWebElement> Copyright { get { return PageFactory.LoadList(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='alert']")]
        private IWebElement LoginError_Creds { get { return PageFactory.Load(this); } }

        
       

       

        public virtual bool IsLoaded()
        {
            //Timeout is increased here because we often experience longer page load times right after
            //PP is deployed in the pipeline.  Increasing the timeout here is more efficient as all subsequent 
            //smoke tests after this are expected to pass and most importantly, it is faster than the time 
            //it would take for tests to run with failure, dev seeing the failure and then having to re-run the 
            //smoke test steps.            

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LoginForm), TimeSpan.FromSeconds(10)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region behaviors

        public string GetInvalidCredentialsError()
        {        
            return LoginError_Creds.Text;
        }

       
      
        public MainPage LoginAttempt(string uname, string pwd)
        {
            EnterCredentials(uname, pwd);
            SubmitLogin();
           
            return new MainPage();
        }

        #endregion behaviors

        #region Selenium

        private void EnterCredentials(string username, string password)
        {
            //if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(()=>CompanyKey)))
            //{ CompanyKey.SendKeys(key); }

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => Username)))
            { Username.SendKeys(username); }

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => Password)))
            { Password.SendKeys(password); }
        }

        private bool SubmitLogin()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => LoginButton)))
            {
                LoginButton.Click();
                Thread.Sleep(2000);
                return true;
            }
            else
            {
                SUT.Log.ErrorFormat("Login button not enabled in {0}", MethodBase.GetCurrentMethod().Name);
                return false;
            }
        }

        //public bool IsLoaded()
        //{
        //    throw new NotImplementedException();
        //}

        #endregion Selenium
    }
}
#endregion