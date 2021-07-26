using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using WorkWave.TA.TestEngine.PageFactory;
using WorkWave.TA.TestEngine;
using NUnit.Framework;
using System.Threading;

using OpenQA.Selenium.Support.UI;


namespace WorkWave.PestPac.TA.Model
{
    class RolesandPermissionSetUpPage : IWebPage
    {

        #region Page Factory

        [FindsBy(How = How.XPath, Using = "//p[text()='Roles & Permissions']")]
        private IWebElement PageHeader { get { return PageFactory.Load(this); } }

        #endregion Page Factory

        private string PageHeaderTitle = "Roles & Permissions";
        public virtual bool IsLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PageHeader)))
            {
                if (PageHeader.Text.Contains(PageHeaderTitle))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

