using System;
using System.Linq;
using System.Text.RegularExpressions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using WorkWave.TA.TestEngine;
using NUnit.Framework;
using System.Collections.Generic;

namespace WorkWave.PestPac.TA.Model
{
    class DocumentViewPage : WebPage
    {
        #region Page Factory
        [FindsBy(How = How.CssSelector, Using = "#page-header")]
        private IWebElement PageHeader { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#butContinue")]
        private IWebElement Continue_Button { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#Name")]
        private IWebElement LetterName_Field { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#butSave")]
        private IWebElement LetterSave_Button { get; set; }
        #endregion Page Factory

        private readonly string PageHeaderText = "Letter";

        public DocumentViewPage()
        {
            InitializePageFactoryElements();
        }

        public virtual void InitializePageFactoryElements()
        {
            PageFactory.InitElements(WebApplication.Instance.WebDriver, this);
        }

        public bool VerifyPageIsLoaded()
        {
            try
            {
                if (WebApplication.Instance.ExplicitWait.Until(CustomExpectedConditions.ElementIsVisible(PageHeader)))
                {
                    if (PageHeader.Text.TrimStart().Contains(PageHeaderText))
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
            catch (NoSuchElementException ex)
            {
                WebApplication.Log.Error(ex.Message);
                return false;
            }
            catch (StaleElementReferenceException ex)
            {
                WebApplication.Log.Error(ex.Message);
                return false;
            }
        }
        #region behavior

        #endregion behavior
        #region Selenium 

        #endregion Selenium 
    }
}