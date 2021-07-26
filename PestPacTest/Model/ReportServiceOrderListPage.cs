using System;
using OpenQA.Selenium;
using WorkWave.TA.TestEngine.PageFactory;
using WorkWave.TA.TestEngine;

namespace WorkWave.PestPac.TA.Model
{
    public class ReportServiceOrderListPage : IWebPage
    {
        #region Page Factory

        [FindsBy(How = How.CssSelector, Using = "#page-header")]
        private IWebElement PageHeader { get { return PageFactory.Load(this); } }

        #endregion Page Factory

        private readonly string PageHeaderText = "Service Order List";



        public virtual bool IsLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(PageHeader)))
            {
                if (PageHeader.Text.Contains(PageHeaderText))
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
        #region behaviors

        #endregion behaviors

    }
}
