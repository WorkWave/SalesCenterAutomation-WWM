using System;
using System.Reflection;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WorkWave.TA.TestEngine.PageFactory;
using WorkWave.TA.TestEngine;

namespace WorkWave.PestPac.TA.Model
{
    class MainPage : IWebPage
    {
        #region Page Factory

        [FindsBy(How = How.CssSelector, Using = "#headertop")]
        public IWebElement Header { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Dashboard']")]
        public IWebElement CompanyName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = ".loggedin-wrapper")]
        public IWebElement LoggedInMessage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.LinkText, Using = "Advanced Search")]
        public IWebElement AdvancedSearchLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.ClassName, Using = "quick-search-line-two")]
        public IList<IWebElement> QuickSearchResult_Text { get { return PageFactory.LoadList(this); } }

        [FindsBy(How = How.XPath, Using = "//img[@title='Go Home']")]
        public IWebElement GoHome_WorkWaveLogo { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.ClassName, Using = "sidebar-add-leads")]
        public IWebElement AddNewLead_GoldenButton_SideBar { get { return PageFactory.Load(this); } }

        #region userMenu

        [FindsBy(How = How.ClassName, Using = "pp-user-widget")]
        public IWebElement UserDropDown { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.ClassName, Using = "logout")]
        public IWebElement LogoutButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.ClassName, Using = "announcements")]
        public IWebElement AnnouncementsButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.ClassName, Using = "profile")]
        public IWebElement ProfileButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.ClassName, Using = "license-mgmt")]
        public IWebElement LicenseMgmtButton { get { return PageFactory.Load(this); } }

        #endregion userMenu

        #region menu

        [FindsBy(How = How.CssSelector, Using = ".links-menu .topMenu")]
        public IList<IWebElement> TopMenu { get { return PageFactory.LoadList(this); } }

        [FindsBy(How = How.CssSelector, Using = ".pp-menu .primary")]
        public IWebElement MenuOptions { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.ClassName, Using = "pp-menu-trigger")]
        public IWebElement Menu_Button { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "button[class='pp-menu-trigger bound']")]
        public IWebElement Menu_Hidden { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.ClassName, Using = "flyout")]
        public IWebElement Flyout { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "div[class='panel'")]
        public IWebElement Flyout_Panel { get { return PageFactory.Load(this); } }
        #endregion menu

        #region favorites menu

        [FindsBy(How = How.CssSelector, Using = "#quicksearchfield")]
        public IWebElement QuickSearchField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.ClassName, Using = "quick-search-parent")]
        public IWebElement QuickSearchParent { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = ".quick-search-parent .quick-search-results div[class*=quick-search-result]")]
        public IList<IWebElement> QuickSearchResults { get { return PageFactory.LoadList(this); } }

        [FindsBy(How = How.CssSelector, Using = "#favorites-column #leftnav")]
        public IList<IWebElement> FavoritesMenu { get { return PageFactory.LoadList(this); } }

        [FindsBy(How = How.CssSelector, Using = "#favorites-column #leftnav tr")]
        public IList<IWebElement> FavoritesMenuItems { get { return PageFactory.LoadList(this); } }

        [FindsBy(How = How.CssSelector, Using = "#favorites-column #config-wrapper")]
        public IWebElement CurrentConfigLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#favorites-column #config-wrapper")]
        public IWebElement LocationSearchLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "a[class=sidebar-add-customer]")]
        public IWebElement AddCustomerSidebar { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "div[accordion-type=QuickLinksAccordion]")]
        public IWebElement QuickLinks { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "div[accordion-type=LocationHistoryAccordion]")]
        public IWebElement LocationHistory_Accordion { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "a[class='accordion-link-wrapper chevron right']")]
        public IList<IWebElement> LocationHistory_Links { get { return PageFactory.LoadList(this); } }
        //[FindsBy(How = How.CssSelector, Using = "div[class~=chevron] a")]
        [FindsBy(How = How.CssSelector, Using = "a[class*=chevron]")]
        public IList<IWebElement> QuickLinksItems { get { return PageFactory.LoadList(this); } }

        #endregion favorites menu

        #endregion Page Factory

        private string PageHeaderTitle ="Dashboard";

        public bool IsLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CompanyName), TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1)))
            {
                if (CompanyName.Text.Contains(PageHeaderTitle))
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

        #region Behaviors

        /*public IWebPage CompanySetup()
        {
            return Click_CompanySetup();
        }

        public IWebPage LeadDashboard()
        {
            return Click_LeadDashboard();
        } */

        //public AdvancedSearchPage AdvancedSearch()
        //{
        //    AdvancedSearchLink.Click();
        //    return new AdvancedSearchPage();
        //}

        //public AddCustomerPage AddCustomer()
        //{
        //    AddCustomer_Click();
        //    return new AddCustomerPage();
        //}

        //public ProfilePage Profile()
        //{
        //    Click_UserDropDown();
        //    Click_Profile();
        //    return new ProfilePage();
        //}
        //public DesktopInspectionUtilityPage DesktopInspectionUtility()
        //{
        //    SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + DesktopInspectionUtilityPage.UrlPath);
        //    return new DesktopInspectionUtilityPage();
        //}

        //public LocationSearchPage LocationSearch()
        //{
        //    return Click_LocationSearch();
        //}

        //public CompanyConfigurationPage CurrentConfig()
        //{
        //    Click_CurrentConfig();
        //    return new CompanyConfigurationPage();
        //}

        public bool IsLocationHistoryOpen()
        {
            bool isOpen = false;

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LocationHistory_Accordion)))
            {
                if (LocationHistory_Accordion.GetAttribute("class") == "accordion open")
                {
                    isOpen = true;
                }
            }

            return isOpen;
        }

        public bool LocationHistoryExpand()
        {
            bool isOpen = true;

            if (!IsLocationHistoryOpen())
            {
                if (!PestPacUtility.Click(LocationHistory_Accordion, wait: true, useJS: false))
                {
                    isOpen = false;
                    SUT.Log.ErrorFormat("Unable to expand the location history menu");
                }
            }

            return isOpen;
        }
        //public LocationPage MostRecentLocation(int order)
        //{

        //    //make sure location history is expanded
        //    LocationHistoryExpand();
        //    LocationHistory_Links[order].Click();
        //    return new LocationPage();
        //}
        //public LocationPage LocationHistory(string accountNumber)
        //{
        //    LocationPage locPage = null;
        //    bool clickedLocation = true;

        //    //make sure location history is expanded
        //    LocationHistoryExpand();

        //    foreach (IWebElement e in LocationHistory_Links)
        //    {
        //        if (e.GetAttribute("title") == accountNumber)
        //        {
        //            if (!PestPacUtility.Click(e, wait: true)) //if Selenium click fails
        //            {
        //                clickedLocation = PestPacUtility.Click(e, wait: true, useJS: true); //try using JS
        //            }

        //            if(clickedLocation)
        //            {
        //                locPage = new LocationPage();
        //            }
        //            else
        //            {
        //                locPage = QuickSearch(accountNumber);  //if Location History click fails, use quick search
        //            }

        //            if (SUT.Web.Alert != null)
        //            {
        //                if (SUT.Web.Alert.Text == "")
        //                {
        //                    PestPacUtility.Alerts_CloseSequent(AlertHandlingType.Accept);
        //                }
        //                else
        //                {
        //                    PestPacUtility.Alerts_CloseSequent(AlertHandlingType.Dismiss);
        //                }
        //            }
        //            break;
        //        }

        //    }
        //    return locPage;
        //}

        ///TODO - add param to decide to enter exact (like account number) or find a match in results and click it
        //public LocationPage QuickSearch(string query)
        //{
        //    LocationPage page = null;
        //    //Dismiss any alerts that may be blocking the ability to enter in the quick search field
        //    SUT.Log.DebugFormat("Dismissing any alerts before entering quick search.");
        //    PestPacUtility.Alerts_CloseSequent(AlertHandlingType.Dismiss);
        //    //check if menu is open and covering the quicksearch field
        //    if (MenuDisplayed())
        //    {
        //        //Closes Menu
        //        Menu();
        //    }
        //    //Attempt to type the query in the quick search field
        //    if (!QuickSearch_TypeQuery(query))
        //    {
        //        return page;
        //    }

        //    //it was noticed that on some rare instances, only after the keys were entered into the quick search field would the alert present itself
        //    //so, we will check for that case here and dismiss any alerts

        //    PestPacUtility.Alerts_CloseSequent(AlertHandlingType.Dismiss);
        //    SUT.Log.DebugFormat("Dismissing any alerts after entering in quick search field.");

        //    //Finally, submit the query
        //    if (QuickSearch_SubmitResult())  //TODO - select result
        //    {
        //        if (SUT.Web.Alert != null)
        //        {
        //            if (SUT.Web.Alert.Text == "")
        //            {
        //                PestPacUtility.Alerts_CloseSequent(AlertHandlingType.Accept);
        //            }
        //            else
        //            {
        //                PestPacUtility.Alerts_CloseSequent(AlertHandlingType.Dismiss);
        //            }
        //        }
        //        SUT.Log.DebugFormat("Quick search submitted query \"{0}\" successfully", query);
        //        page = new LocationPage();
        //    }
        //    else
        //    {
        //        SUT.Log.DebugFormat("Quick search failed to submit query \"{0}\"", query);
        //    }
        //    return page;
        //}

        //public TaskManagerPage Tasks()
        //{
        //    IWebElement element;
        //    SeleniumUtility.ExplicitWaitForAction(() =>
        //    {
        //        element = SeleniumUtility.FindFirstElementMatchingText(QuickLinksItems, "Tasks");
        //        if (element != null)
        //        {
        //            SUT.Log.DebugFormat("Tasks element: {0}", element.ToString());
        //            PestPacUtility.ScrollToElement(element);
        //            element.Click();
        //        }
        //        return true;
        //    },
        //    2000);

        //    return new TaskManagerPage();
        //}
        //public ViewCallsPage Calls()
        //{
        //    Calls_Click();
        //    return new ViewCallsPage();
        //}
        //public ViewLeadsPage Leads()
        //{
        //    Leads_Click();
        //    return new ViewLeadsPage();
        //}
        //public ApptSchedulerPage ApptSchedulerQuickLink()
        //{
        //    SeleniumUtility.ExplicitWaitForAction(() =>
        //    {

        //        IWebElement el = SeleniumUtility.FindFirstElementMatchingText(QuickLinksItems, "Appt. Scheduler");
        //        if (el.Displayed)
        //        {
        //            el.Click();
        //            return true;
        //        }
        //        else
        //            return false;
        //    }, 250, 5);


        //    return new ApptSchedulerPage();
        //}

        public bool GoHome()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => GoHome_WorkWaveLogo)))
            {
                GoHome_WorkWaveLogo.Click();
                SUT.Log.Debug("Go Home - WorkWave Logo clicked!");

                return true;
            }

            SUT.Log.Error("Unable to click Go Home - WorkWave Logo!");
            return false;
        }

        #endregion Behaviors

        public bool IsLoggedIn()
        {
            bool isLoggedIn = false;

            try
            {
                //if (LoggedInMessage.Displayed)
                if (IsLoaded())
                {
                    isLoggedIn = true;
                    SUT.Log.Info("User is logged in");
                }
                else
                {
                    SUT.Log.Info("User is NOT logged in");
                }
            }
            catch (NoSuchElementException)
            {
                isLoggedIn = false;
                SUT.Log.Info("User is NOT logged in");
            }

            return isLoggedIn;
        }

        public bool IsQuickLinksOpen()
        {
            bool isOpen = false;

            if (QuickLinks.GetAttribute("class") == "divider-line accordion open")
            {
                isOpen = true;
            }
            else if (QuickLinks.GetAttribute("class") == "divider-line accordion")
            {
                isOpen = false;
            }

            return isOpen;
        }

        /// <summary>
        /// Open/Close the Quick Links in the left Nav bar.  Will return the page instance in order to chain
        /// the selection of sub-menu items under the QuickLinks.
        /// </summary>
        /// <param name="open">Provide a boolean true to open the Quick Links menu, false
        /// to close it.</param>
        public MainPage QuickLinksOpen(bool open)
        {
            if (!QuickLinks.Displayed)
            {
                SUT.Log.Debug("QuickLinks not being displayed, scrolling into view");
                PestPacUtility.ScrollToElement(QuickLinks);
            }

            if (IsQuickLinksOpen() != open)
            {
                QuickLinks_Click();
            }

            return this;
        }
        #region NewMenu 
        public MainPage Menu()
        {
            MainPage page = null;
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => Menu_Button)))
            {
                Menu_Button.Click();
                page = this;
                SUT.Log.Info("opening the menu");
            }
            else
            {
                SUT.Log.ErrorFormat("Could not open menu from {0}", MethodBase.GetCurrentMethod().Name);
            }
            return page;
        }
        public IWebPage MenuSelectOption(string menuOption, string subMenuOption)
        {
            IWebPage page = null;

            if (!MenuDisplayed())
            {
                Menu();
            }
            IList<IWebElement> menuList = MenuOptions.FindElements(By.TagName("li"));
            IWebElement selectedMenuOption = SeleniumUtility.FindFirstElementContainingText(menuList, menuOption);
            SUT.Log.DebugFormat(selectedMenuOption.ToString());

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => selectedMenuOption)) &&
                SeleniumUtility.WaitFor((d) => selectedMenuOption.Displayed))

            {
                selectedMenuOption.Click();

                if (!SeleniumUtility.WaitFor((x) => selectedMenuOption.GetAttribute("class") == "active"))
                {
                    return page;
                }
            }
            else
            {
                SUT.Log.DebugFormat("Could not select {0} from menu", selectedMenuOption.ToString());
                return page;
            }

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => Flyout_Panel)))
            {
                IList<IWebElement> subMenuList = Flyout_Panel.FindElements(By.TagName("a"));
                IWebElement value = SeleniumUtility.FindFirstElementContainingText(subMenuList, subMenuOption);
                if (value == null)
                    return page;

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => value)) &&
                    SeleniumUtility.WaitFor((d) => value.Enabled))
                {
                    value.Click();
                    //   page = PestPacUtility.NewMenuOption(subMenuOption);
                }
            }
            if (SUT.Web.Alert != null)
            {
                if (SUT.Web.Alert.Text == "")
                {
                    PestPacUtility.Alerts_CloseSequent(AlertHandlingType.Accept);
                }
                else
                {
                    PestPacUtility.Alerts_CloseSequent(AlertHandlingType.Dismiss);
                }
            }
            return page;
        }

        public bool VerifySubMenuOptions(string menuOption, string subMenuOptions)
        {
            IList<IWebElement> menuList = MenuOptions.FindElements(By.TagName("li"));
            IWebElement selectedMenuOption = SeleniumUtility.FindFirstElementContainingText(menuList, menuOption);
            SUT.Log.Debug("Menu Option to be selected: " + selectedMenuOption.ToString());

            //Select Mene Option
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => selectedMenuOption)) &&
                SeleniumUtility.WaitFor((d) => selectedMenuOption.Displayed))
            {
                selectedMenuOption.Click();
                SUT.Log.Debug(selectedMenuOption.ToString() + " selected");

                IWebElement subMenuOptionElem = null;

                //Verify Sub Menu Option
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => Flyout_Panel)))
                {
                    if (subMenuOptions.Contains(","))
                    {
                        string[] subMenuOptions_arr = subMenuOptions.Split(',');

                        for (int i = 0; i < subMenuOptions_arr.Length; i++)
                        {
                            SUT.Log.Debug("Sub Menu Option to be verified: " + subMenuOptions[i].ToString());
                            IList<IWebElement> subMenuList = Flyout_Panel.FindElements(By.TagName("a"));
                            subMenuOptionElem = SeleniumUtility.FindFirstElementContainingText(subMenuList, subMenuOptions[i].ToString());

                            if (subMenuOptionElem == null)
                            {
                                SUT.Log.Debug("Unable to verify Sub Menu Option: " + subMenuOptionElem.Text.ToString());
                                return false;
                            }
                        }
                    }
                    else
                    {
                        IList<IWebElement> subMenuList = Flyout_Panel.FindElements(By.TagName("a"));
                        subMenuOptionElem = SeleniumUtility.FindFirstElementContainingText(subMenuList, subMenuOptions);
                        SUT.Log.Debug("Sub Menu Option to be verified: " + subMenuOptionElem.Text.ToString());

                        if (subMenuOptionElem == null)
                        {
                            SUT.Log.Debug("Unable to verify Sub Menu Option: " + subMenuOptionElem.Text.ToString());
                            return false;
                        }
                    }

                    SUT.Log.Debug("Sub Menu Option verified");
                    return true;
                }
            }

            SUT.Log.Debug("Unable to verify Sub Menu Option");
            return false;
        }

        #endregion NewMenu


        public bool Logout()
        {
            try
            {

                if (Click_UserDropDown() &&
                Click_Logout())
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                SUT.Log.InfoFormat(e.Message);
                return false;
            }
            return false;
        }

        public bool VerifyAddNewLeadButtonInPestPacSideBar()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => AddNewLead_GoldenButton_SideBar)))
            {
                SUT.Log.Debug("+ New Lead Golden Button is visible");
                return true;
            }

            SUT.Log.Debug("+ New Lead Golden Button is not visible");
            return false;
        }

        #region Selenium
        private bool MenuDisplayed()
        {
            bool isdisplayed;
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => Menu_Hidden)))
            {
                isdisplayed = false;
                SUT.Log.Info("Menu is not displayed");
            }
            else
            {
                SUT.Log.Info("Menu is displayed");
                isdisplayed = true;
            }
            return isdisplayed;
        }
        /*
        public CompanySetupPage gotoCompanySetupPage()
        {
            SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/sysSetup/sysDefaults.asp");
            return new CompanySetupPage();
        }
        public LookupTablesPage gotoLookupTablesPage()
        {
            SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/lookup/lookups.asp");
            return new LookupTablesPage();
        }
        */
        public MainPage GoToPageIndex(string suffix)
        {
            SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + suffix);
            return this;
        }
        private void QuickLinks_Click()
        {
            PestPacUtility.ScrollToElement(QuickLinks);
            QuickLinks.Click();
        }


        private void Click_Profile()
        {
            ProfileButton.Click();
        }
        private CompanySetupPage Click_CompanySetup()
        {
            List<IWebElement> companyDropDown = new List<IWebElement>();
            IWebElement el = SeleniumUtility.FindElementInListByText(TopMenu, By.CssSelector("li"), "Company");
            companyDropDown.Add(el);

            IWebElement companySetup = SeleniumUtility.FindElementInListByText(companyDropDown, By.CssSelector("li"), "Company Setup");
            companySetup.Click();

            return new CompanySetupPage();
        }

        private void Leads_Click()
        {
            IWebElement element = SeleniumUtility.FindFirstElementMatchingText(QuickLinksItems, "Leads");
            element.Click();
        }
        private void Calls_Click()
        {
            IWebElement element = SeleniumUtility.FindFirstElementMatchingText(QuickLinksItems, "Calls");
            element.Click();
        }

        private void AddCustomer_Click()
        {
            AddCustomerSidebar.Click();
        }

        //private LocationSearchPage Click_LocationSearch()
        //{
        //    IWebElement locSearch = SeleniumUtility.FindElementInListByText(FavoritesMenuItems, null, "Location Search");
        //    locSearch.Click();
        //    return new LocationSearchPage();
        //}

        private void Click_CurrentConfig()
        {
            CurrentConfigLink.Click();
        }

        /// <summary>
        /// Type the query in the quick search field
        /// </summary>
        /// <param name="query"></param>
        /// <returns>boolean, if query was entered into the quick search field</returns>
        private bool QuickSearch_TypeQuery(string query)
        {
            const int resultsDelay = 500;  //backend enforced delay after each key
            TimeSpan timeOut = TimeSpan.FromSeconds(3);
            bool result = false;

            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => QuickSearchField), timeOut))
                {
                    QuickSearchField.Clear();
                    QuickSearchField.SendKeys(query);
                    // The following delay accounts for the 500ms enforced delay on the application's backend when populating the results after keys.
                    // Rather than us polling for results when we know it won't be ready, we will just add a delay here to match the app.
                    System.Threading.Thread.Sleep(resultsDelay);
                    SUT.Log.DebugFormat("Sent the query \"{0}\" to the quick search field", query);
                    result = true;
                }
                else
                {
                    SUT.Log.DebugFormat("Quick search failed, not able to find the quick search field in {0} milliseconds", timeOut);
                    result = false;
                }
            }
            catch (Exception ex)
            {
                SUT.Log.DebugFormat("Quick search failed, not able to enter query {0} in quick search field", query);
                SUT.Log.Debug(ex.Message);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Submit the query to quick search.
        /// </summary>
        /// <returns>boolean, based upon whether the result was submitted</returns>
        private bool QuickSearch_SubmitResult(string query = "")
        {
            bool submitted = false;
            TimeSpan timeOut = TimeSpan.FromSeconds(5);
            bool selectResult = !String.IsNullOrEmpty(query);

            // Wait for the results elements to be generated, before we submit
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => QuickSearchParent), timeOut))
            {
                SUT.Log.Debug("Quick search results displayed");
                if (selectResult)
                {
                    SUT.Log.DebugFormat("Attempting to select the result for \"{0}\" in the results panel", query);
                    IWebElement e = SeleniumUtility.FindFirstElementContainingText(QuickSearchResult_Text, query);
                    if (null != e)
                    {
                        if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => e)))
                        {
                            e.Click();
                            SUT.Log.DebugFormat("Clicked the result matching the query \"{0}\"", query);
                            submitted = true;
                        }
                        else
                        {
                            SUT.Log.DebugFormat("Failed to find a match for \"{0}\" in the quick search results", query);
                            submitted = false;
                        }
                    }
                    else
                    {
                        SUT.Log.DebugFormat("Failed to find a match for \"{0}\" in the quick search results", query);
                        submitted = false;
                    }
                }
                else
                {
                    if (SeleniumUtility.WaitFor((d) => QuickSearchField.Enabled) &&
                        SeleniumUtility.WaitFor((d) => QuickSearchField.Displayed))
                    {
                        QuickSearchField.SendKeys(Keys.Enter);
                    }

                }
                submitted = true;
            }
            else
            {
                SUT.Log.DebugFormat("Quick Search failed to present the results within {0} milliseconds", timeOut.Milliseconds);
                submitted = false;
            }

            return submitted;
        }

        private bool Click_UserDropDown()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UserDropDown)))
            {
                UserDropDown.Click();
                return true;
            }
            return false;
        }

        private bool Click_Logout()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LogoutButton)))
            {
                LogoutButton.Click();
                return true;
            }
            return false;
        }

        #endregion Selenium
    }
}
