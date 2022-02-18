using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WorkWave.TA.TestEngine.PageFactory;
using WorkWave.TA.TestEngine;
using OpenQA.Selenium.Interactions;
using System.Threading;
using NUnit.Framework;
using System.Reflection;
using System.Text.RegularExpressions;

namespace WorkWave.PestPac.TA.Model
{
    class CommonFunctionsDetailsPage
    {
        #region PageFactory

        [FindsBy(How = How.XPath, Using = "//div[@role='tooltip']//div[1]")]
        private IWebElement ToastMessage { get { return PageFactory.Load(this); } }




        #endregion PageFactory



        public bool VerifyToastmessage(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ToastMessage)))
            {
                SUT.Log.Debug("Toast  message is displayed");
                Assert.True(ToastMessage.Text.Contains(message), "Toast  message is not displayed");
                Thread.Sleep(4000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Toast  message is not displayed");
                return false;
            }
        }

    }
}
