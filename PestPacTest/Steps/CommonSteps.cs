using NUnit.Framework;
using System;
using System.IO;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.PestPac.TA.Model;
using WorkWave.PestPac.TA.SharedData;
using WorkWave.TA.TestEngine;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;


namespace WorkWave.PestPac.TA.Steps
{
    [Binding]
    public class CommonSteps : TestSteps
    {
        MainPage mainPage;

        PestPacData pestPacData;
        private CompanySetupPage companySetupPage;

        private static string primaryWindow = "";

        public CommonSteps(PestPacData pestPacData)
        {
            this.pestPacData = pestPacData;
            mainPage = new MainPage();
        }

        #region hooks

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            SUT.Initialize();

            SUT.Web.CreateNewDriver();
            SUT.Log.Info("Created Web Driver: " + SUT.Web.WebDriver.GetType());
            primaryWindow = SUT.Web.WebDriver.CurrentWindowHandle;
            SUT.Log.DebugFormat("Primary browser window opened: {0}", primaryWindow);
            SUT.Log.DebugFormat("Window resolution is {0} x {1}",
                SUT.Web.WebDriver.Manage().Window.Size.Height,
                SUT.Web.WebDriver.Manage().Window.Size.Width);

            //PestPac config
            PestPacSupport.InitializePestPacConfig();
            if (SUT.Web.Config.Browser == "Firefox")
            {
                Thread.Sleep(9000);
            }

        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            SUT.Web.WebDriver.Quit();
        }
        [BeforeScenario(Order = 1)]
        public static void BeforeScenario_ReInitializ()
        {
            if (SUT.Web.Config.Browser == "Firefox")
            {
                FirefoxProfile profile = new FirefoxProfile();
                profile.SetPreference("capability.policy.default.Window.QueryInterface", "allAccess");
                profile.SetPreference("capability.policy.default.Window.frameElement.get", "allAccess");
                SUT.Web.ExplicitWait.Timeout = TimeSpan.FromMilliseconds(9000);
                SUT.Log.DebugFormat("Firefox interval {0}", SUT.Web.ExplicitWait.Timeout);
                SUT.Web.ExplicitWait.PollingInterval = TimeSpan.FromMilliseconds(SUT.Web.Config.ExplicitWait_DefaultPollingIntervalMilliSec);


            }
            if (SUT.Web.Config.Browser == "Chrome")
            {
                //http errors
                SUT.Web.ExplicitWait.Timeout = TimeSpan.FromMinutes(3);
                SUT.Web.WebDriver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(120));//45 sec
            }
        }
        [BeforeScenario(Order = 2)]
        [Scope(Tag = "ReportPDF")]
        public static void BeforeScenario_DeleteDownloadedReportPDF()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string localpath = appData + "\\Downloads";
            string[] filePaths = Directory.GetFiles(@localpath, "*.pdf");
            foreach (string filePath in filePaths)
            {
                File.Delete(filePath);
            }
        }

        [AfterScenario(Order = 1)]
        [Obsolete]
        public static void AfterScenario_ReInitialize()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                SUT.Log.DebugFormat("Scenario {0}: {1}", ScenarioContext.Current.ScenarioInfo.Title, ScenarioContext.Current.TestError.Message);
                string filePath = SeleniumUtility.SaveScreenshot(FeatureContext.Current.FeatureInfo.Title.ToString(), ScenarioContext.Current.ScenarioInfo.Title.ToString());
                SUT.Log.DebugFormat("Screenshot saved to {0}.", filePath);
            }
            SUT.Web.ExplicitWait.Timeout = TimeSpan.FromMilliseconds(SUT.Web.Config.ExplicitWait_DefaultTimeoutMilliSec);
            SUT.Web.ExplicitWait.PollingInterval = TimeSpan.FromMilliseconds(SUT.Web.Config.ExplicitWait_DefaultPollingIntervalMilliSec);
        }

        [AfterScenario(Order = 2)]
        [Obsolete]
        //Remove any alert or window that could possibly be hanging around from unexpected conditions that may have caused scenario to fail.
        //We do not want the alert blocking test runs
        public static void AfterScenario_CleanAlertsAndWindows()
        {
            //since it is not possible to account for all PestPac alerts and their specific needs, accepting vs alerting can affect behavior,
            //as well as possibility of mulitple sequent alerts, we will quit the instance.
            //Quit instead of close to account alerts on nth window, and not have to maintain number of windows open and switching context
            if (ScenarioContext.Current.TestError != null)
            {
                SUT.Log.DebugFormat("Scenario {0}: {1}", ScenarioContext.Current.ScenarioInfo.Title, ScenarioContext.Current.TestError.Message);


                if (SUT.Web.Alert != null)
                {
                    SUT.Web.WebDriver.Quit();
                    SUT.Web.CreateNewDriver();
                    primaryWindow = SUT.Web.WebDriver.CurrentWindowHandle;
                    SUT.Log.DebugFormat("Primary browser window opened: {0}", primaryWindow);
                }
                else
                {
                    int numWindows = SUT.Web.WebDriver.WindowHandles.Count;
                    SUT.Log.DebugFormat("{0} open windows", numWindows);

                    if (numWindows > 2)
                    {
                        string[] windows = new string[numWindows];
                        SUT.Web.WebDriver.WindowHandles.CopyTo(windows, 0);

                        for (int i = windows.Length - 1; i >= 0; i--)
                        {
                            if (!windows[i].Equals(primaryWindow))
                            {
                                SUT.Log.DebugFormat("Closing window: {0}", windows[i]);
                                SUT.Web.WebDriver.SwitchTo().Window(windows[i]).Close();
                            }
                        }
                    }
                }
            }
            //SUT.Web.WebDriver.SwitchTo().Window(primaryWindow);
            //http error webdriver - kill the driver and recreate again chrome driver v90 
            //aftersceanrio steps handle in this method - since we kill the direver at the end.
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("ReportPDF"))
            {
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string localpath = appData + "\\Downloads";
                string[] filePaths = Directory.GetFiles(@localpath, "*.pdf");
                foreach (string filePath in filePaths)
                {
                    File.Delete(filePath);
                }
            }

            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("GLCode"))
            {
                MainPage mainPage = new MainPage();
                CompanySetupPage companySetupPage = new CompanySetupPage();

                companySetupPage = mainPage.MenuSelectOption("Settings", "Company Setup") as CompanySetupPage;
                Assert.True(companySetupPage.IsLoaded(), "Company Setup Page is not loaded");
                companySetupPage.Click_GeneralLedger();
                companySetupPage.Set_UseGeneralLedger(false);
                // LocationSearchPage locSearch = companySetupPage.Save();

            }

            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("BlankBranch"))
            {
                MainPage mainPage = new MainPage();
                CompanySetupPage companySetupPage = new CompanySetupPage();

                companySetupPage = mainPage.MenuSelectOption("Settings", "Company Setup") as CompanySetupPage;
                Assert.True(companySetupPage.IsLoaded(), "Company Setup Page is not loaded");
                companySetupPage.Click_DefaultsForNewAccount();
                companySetupPage.Set_BlankBranch(false);
                // LocationSearchPage locSearch = companySetupPage.Save();

            }


            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("multiunit"))
            {
                SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/license.asp"); //goes to LicenseManagerPage
                                                                                                //  LicenseManagerPage licensePage = new LicenseManagerPage();
                                                                                                //   Assert.True(licensePage.IsLoaded(), "Expected to be on License Page, {0}", licensePage.GetType());
                SUT.Log.DebugFormat("i am in license manager page");
                //   licensePage.Override_Config();
                SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/utility/config.asp"); //goes to CompanyConfigurationPage
                                                                                                       //   CompanyConfigurationPage configPage = new CompanyConfigurationPage();
                                                                                                       // Assert.True(configPage.IsLoaded(), "Expected to be on Company Configuration Page, {0}", configPage.GetType());
                SUT.Log.DebugFormat("i am in Company Config page");
                //  configPage.Config_Multiunit(false);
                //   LocationSearchPage locationSearchPage = configPage.Save();
                Thread.Sleep(5000);
                //  Assert.True(locationSearchPage.IsLoaded(), "Expected to be on Location Search Page, {0}", locationSearchPage.GetType());

            }
            SUT.Web.WebDriver.Quit();
            SUT.Web.CreateNewDriver();
        }

        //[AfterScenario()]
        //[Scope(Tag = "ReportPDF")]
        //public static void AfterScenario_DeleteDownloadedReportPDF()
        //{
        //    string appData = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        //    string localpath = appData + "\\Downloads";
        //    string[] filePaths = Directory.GetFiles(@localpath, "*.pdf");
        //    foreach (string filePath in filePaths)
        //    {
        //        File.Delete(filePath);
        //    }
        //}

        //[AfterScenario()]
        //[Scope(Tag = "GLCode")]

        //public static void AfterScenario_UncheckUseGeneralLedger()
        //{
        //    MainPage mainPage = new MainPage();
        //    CompanySetupPage companySetupPage = new CompanySetupPage();

        //    companySetupPage = mainPage.MenuSelectOption("Settings", "Company Setup") as CompanySetupPage;
        //    Assert.True(companySetupPage.IsLoaded(), "Company Setup Page is not loaded");
        //    companySetupPage.Click_GeneralLedger();
        //    companySetupPage.Set_UseGeneralLedger(false);
        //    LocationSearchPage locSearch = companySetupPage.Save();
        //}

        //[AfterScenario()]
        //[Scope(Tag = "BlankBranch")]
        //public static void AfterScenario_UncheckBlankBranch()
        //{
        //    MainPage mainPage = new MainPage();
        //    CompanySetupPage companySetupPage = new CompanySetupPage();

        //    companySetupPage = mainPage.MenuSelectOption("Settings", "Company Setup") as CompanySetupPage;
        //    Assert.True(companySetupPage.IsLoaded(), "Company Setup Page is not loaded");
        //    companySetupPage.Click_DefaultsForNewAccount();
        //    companySetupPage.Set_BlankBranch(false);
        //    LocationSearchPage locSearch = companySetupPage.Save();
        //}

        //[AfterScenario()]
        //[Scope(Tag = "multiunit")]
        //public static void AfterScenario_UncheckConfigMultiunit()
        //{
        //    SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/license.asp"); //goes to LicenseManagerPage
        //    LicenseManagerPage licensePage = new LicenseManagerPage();
        //    Assert.True(licensePage.IsLoaded(), "Expected to be on License Page, {0}", licensePage.GetType());
        //    SUT.Log.DebugFormat("i am in license manager page");
        //    licensePage.Override_Config();
        //    SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/utility/config.asp"); //goes to CompanyConfigurationPage
        //    CompanyConfigurationPage configPage = new CompanyConfigurationPage();
        //    Assert.True(configPage.IsLoaded(), "Expected to be on Company Configuration Page, {0}", configPage.GetType());
        //    SUT.Log.DebugFormat("i am in Company Config page");
        //    configPage.Config_Multiunit(false);
        //    LocationSearchPage locationSearchPage = configPage.Save();
        //    Thread.Sleep(5000);
        //    Assert.True(locationSearchPage.IsLoaded(), "Expected to be on Location Search Page, {0}", locationSearchPage.GetType());
        //}
        #endregion hooks


        [Given(@"Home page")]
        public void GivenHomePage()
        {
            WebConfig config = SUT.Web.Config;
            LoginPage loginPage = new LoginPage();
            SUT.Web.WebDriver.Navigate().GoToUrl(config.HomePage);

            try
            {
                Assert.True(loginPage.IsLoaded(), "Failed to navigate to {0}", config.HomePage);
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException e)
            {
                Assert.Fail("The login page at {0} failed to load after waiting {1} seconds.  {2}",
                    config.HomePage,
                    SUT.Web.ExplicitWait.Timeout,
                    e.StackTrace);
            }
        }

        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            Support_GivenIAmLoggeIn();
        }

        [Given(@"I am logged in and navigate to company setup page and verify the Payment method")]
        public void GivenIAmLoggedInAndNavigateToCompanySetupPageAndVerifyThePaymentMethod()
        {
            Support_GivenIAmLoggeIn();
            companySetupPage = mainPage.MenuSelectOption("Settings", "Company Setup") as CompanySetupPage;
            Assert.True(companySetupPage.IsLoaded(), "Company Setup Page is not loaded");
            //companySetupPage.ShowAll();
            companySetupPage.paymentMethodLink();
            Assert.True(companySetupPage.IsLoaded(), "Company Setup Page is not loaded");
            var currURL = SUT.Web.WebDriver.Url;
            SUT.Log.Debug(currURL);
            companySetupPage.setProcessor();
        }



        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn(Table table)
        {
            Support_GivenIAmLoggeIn(table);
        }

        private void Support_GivenIAmLoggeIn(Table table = null)
        {
            if (SUT.Web.Config.Browser == "Chrome")
            {
                Thread.Sleep(100);
            }
            if (!mainPage.IsLoggedIn())
            {
                LoginPage loginPage = new LoginPage();
                WebConfig config = SUT.Web.Config;
                SUT.Web.WebDriver.Navigate().GoToUrl(config.HomePage);
                Assert.True(loginPage.IsLoaded(),
                    "Failed to verify that the login page at {0} has been loaded", config.HomePage);

                if (table != null)
                {
                    LoginFields loginFields = table.CreateInstance<LoginFields>();
                    mainPage = loginPage.LoginAttempt(loginFields.Username, loginFields.Password);
                }
                else
                {
                    mainPage = loginPage.LoginAttempt(PestPacSupport.DefaultUsername,
                        PestPacSupport.DefaultPassword);
                }
                Assert.True(mainPage.IsLoaded(), "Failed to detect the main page after login attempt on {0}", config.HomePage);
            }
        }

        //[Given(@"Location\s{1}(\S*)")]
        //public void GivenLocationAccountNumber(string accountNumber)
        //{
        //    locationPage = mainPage.QuickSearch(accountNumber);         
        //    Assert.True(locationPage.IsLoaded(), "Failed to verify expected page, Location {0} is loaded", accountNumber);
        //    StringAssert.IsMatch(accountNumber, locationPage.GetAccountNumber(), "Failed to load the Location {0} page", accountNumber);
        //}

        //[Given(@"Location ID (.*)")]
        //public void GivenLocationID(string id)
        //{
        //    locationPage = locationPage.Load(id);
        //}




        //[When(@"Show History")]
        //public void WhenShowHistory()
        //{
        //    Assert.True(locationPage.IsLoaded(), "Cannot Show History, expecting to be on a location page");
        //    locationPage.ShowHistory();
        //}

        [Given(@"Menu Open")]
        public void OpenNewMenu()
        {
            Assert.NotNull(mainPage.Menu(), "Unable to Open Main Menu");
        }
        [When(@"Page reload")]
        [Obsolete]
        public void WhenPageReload()
        {
            ScenarioContext.Current.Pending();
        }

        //[When(@"Company Configuration is saved")]
        //public void WhenCompanyConfigurationIsSaved()
        //{
        //    CompanyConfigurationPage config = new CompanyConfigurationPage();
        //    LocationSearchPage locSearch = new LocationSearchPage();
        //    Assert.NotNull(locSearch = config.Save(), "Could not save Company Config page");
        //}

        //TODO move me to location feature when it gets created, here for now
        //[Then(@"History is displayed")]
        //public void ThenHistoryIsDisplayed()
        //{
        //    Assert.NotNull(locationPage, "Expecting a location page");
        //    Assert.True(locationPage.IsHistoryVisible(), "Expecting for History section to be visible but it is set to 'hidden'");
        //    //same button, hit again to 'Hide History'
        //    locationPage.ShowHistory();
        //}
        [Then(@"Log Out")]
        public void LogOut()
        {
            mainPage.Logout();
        }
        //[Then(@"Page loaded successfully")]
        //public void ThenPageLoadedSuccessfully()
        //{
        //    //When "Company Configuration is saved" goes to locSearch
        //    LocationSearchPage locSearch = new LocationSearchPage();
        //    Assert.True(locSearch.IsLoaded());
        //}
        //[Given(@"Multiunit is checked")]
        //public void CheckMultiunit()
        //{
        //    SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/license.asp");
        //    SUT.Log.DebugFormat("license manager added to the url");
        //    LicenseManagerPage licensePage = new LicenseManagerPage();
        //    Assert.True(licensePage.IsLoaded(), "Expected to be on License Page, {0}", licensePage.GetType());
        //    SUT.Log.DebugFormat("i am in license manager page");
        //    licensePage.Override_Config();
        //    SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/utility/config.asp"); //goes to CompanyConfigurationPage
        //    CompanyConfigurationPage configPage = new CompanyConfigurationPage();
        //    Assert.True(configPage.IsLoaded(), "Expected to be on Company Configuration Page, {0}", configPage.GetType());
        //    SUT.Log.DebugFormat("i am in Company Config page");
        //    configPage.Config_Multiunit(true);
        //    LocationSearchPage locationSearchPage = configPage.Save();
        //    System.Threading.Thread.Sleep(5000);
        //    Assert.True(locationSearchPage.IsLoaded(), "Expected to be on Location Search Page, {0}", locationSearchPage.GetType());
        //}

        //[Given(@"Use Marketing Automation is Unchecked")]
        //public void GivenUseMarketingAutomationIsUnchecked()
        //{
        //    SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/license.asp");
        //    SUT.Log.DebugFormat("license manager added to the url");
        //    LicenseManagerPage licensePage = new LicenseManagerPage();
        //    Assert.True(licensePage.IsLoaded(), "Expected to be on License Page, {0}", licensePage.GetType());
        //    SUT.Log.DebugFormat("i am in license manager page");
        //    licensePage.Override_Config();
        //    SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/utility/config.asp"); //goes to CompanyConfigurationPage
        //    CompanyConfigurationPage configPage = new CompanyConfigurationPage();
        //    Assert.True(configPage.IsLoaded(), "Expected to be on Company Configuration Page, {0}", configPage.GetType());
        //    SUT.Log.DebugFormat("i am in Company Config page");

        //    //Uncheck - UseMarketingAutomation
        //    configPage.Config_UseMarketingAutomation(false);
        //    //Uncheck - UseMarketingAutomation
        //    configPage.Config_UseRefGo(false);

        //    LocationSearchPage locationSearchPage = configPage.Save();
        //    System.Threading.Thread.Sleep(5000);
        //    Assert.True(locationSearchPage.IsLoaded(), "Expected to be on Location Search Page, {0}", locationSearchPage.GetType());
        //}

        //[When(@"Navigate to current user's profile")]
        //public void WhenNavigateToCurrentUserSProfile()
        //{
        //    profilePage = mainPage.Profile() as ProfilePage;
        //    //Wait till Maintain Profile get loads
        //    Thread.Sleep(8000);
        //    Assert.True(profilePage.IsLoaded(), "Failed to load Maintain Profile page");
        //}

        //[Given(@"Config Page")]
        //public void GivenConfigPage()
        //{
        //    SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/license.asp");
        //    SUT.Log.DebugFormat("license manager added to the url");
        //    Assert.True(licensePage.IsLoaded(), "Expected to be on License Page, {0}", licensePage.GetType());
        //    SUT.Log.DebugFormat("i am in license manager page");
        //    licensePage.Override_Config();
        //    SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/utility/config.asp"); //goes to CompanyConfigurationPage
        //    Assert.True(configPage.IsLoaded(), "Expected to be on Company Configuration Page, {0}", configPage.GetType());
        //    SUT.Log.DebugFormat("i am in Company Config page");
        //}

        //[Then(@"Update Config Option")]
        //public void ThenUpdateConfigOption(Table data)
        //{
        //    pestPacData.CompanyConfiguration = data.CreateInstance<CompanyConfiguration>();
        //    string configOption = pestPacData.CompanyConfiguration.ConfigOption;
        //    string optionValue = pestPacData.CompanyConfiguration.ConfigOptionValue;

        //    if (configOption.Equals("UsePlainPaper"))
        //    {
        //        Assert.True(configPage.Config_UsePlainPaper(Convert.ToBoolean(optionValue)), "Unable to set option value as " + optionValue);
        //    }
        //    if (configOption.Equals("UseADAuth"))
        //    {
        //        Assert.True(configPage.Config_UseADAuth(Convert.ToBoolean(optionValue)), "Unable to set option value as " + optionValue);
        //    }
        //    if (configOption.Equals("UsePowerBI"))
        //    {
        //        Assert.True(configPage.Config_UsePowerBI(Convert.ToBoolean(optionValue)), "Unable to set option value as " + optionValue);
        //    }
        //    if (configOption.Equals("Dupcreditcards"))
        //    {
        //        Assert.True(configPage.Dupcreditcards(Convert.ToBoolean(optionValue)), "Unable to set option value as " + optionValue);
        //    }
        //    if (configOption.Equals("UseAutomation"))
        //    {
        //        Assert.True(configPage.Config_UseAutomation(Convert.ToBoolean(optionValue)), "Unable to set option value as " + optionValue);
        //    }
        //    if (configOption.Equals("UseFormsManager"))
        //    {
        //        Assert.True(configPage.Config_UseFormsManager(Convert.ToBoolean(optionValue)), "Unable to set option value as " + optionValue);
        //    }
        //    if (configOption.Equals("ultdcustfrmmanagerusrs"))
        //    {
        //        Assert.True(configPage.Config_ultdcustfrmmanagerusrs(Convert.ToBoolean(optionValue)), "Unable to set option value as " + optionValue);
        //    }
        //    if (configOption.Equals("custfrmmanagerusrs"))
        //    {
        //        configPage.Config_custfrmmanagerusrs(optionValue);
        //    }
        //    if (configOption.Equals("UseSalesCenterSetup"))
        //    {
        //        configPage.UseSalesCenterSetup(Convert.ToBoolean(optionValue));
        //    }
        //    if (configOption.Equals("UseSalesCenterLive"))
        //    {
        //        configPage.UseSalesCenterLive(Convert.ToBoolean(optionValue));
        //    }
        //    if (configOption.Equals("UseFormQueue"))
        //    {
        //        Assert.True(configPage.Config_UseFormsQueue(Convert.ToBoolean(optionValue)), "Unable to set option value as " + optionValue);
        //    }
        //    if (configOption.Equals("dupcreditcards"))
        //    {
        //        Assert.True(configPage.Config_UsePlainPaper(Convert.ToBoolean(optionValue)), "Unable to set option value as " + optionValue);
        //    }
        //    if (configOption.Equals("UseNewRouteOp"))
        //    {
        //        Assert.True(configPage.Config_UseNewRouteOp(Convert.ToBoolean(optionValue)), "Unable to set option value as " + optionValue);
        //    }

        //    //Save changed options
        //    LocationSearchPage locationSearchPage = configPage.Save();
        //    Thread.Sleep(9000);
        //    Assert.True(locationSearchPage.IsLoaded(), "Expected to be on Location Search Page, {0}", locationSearchPage.GetType());
        //}

        [When(@"Go Home")]
        public void WhenGoHome()
        {
            //Refresh Page
            SUT.Web.WebDriver.Navigate().Refresh();

            Assert.True(mainPage.GoHome(), "Unable to navigate to PestPac Home Page!");
        }

        //[When(@"Clear Config field Text")]
        //public void WhenClearConfigFieldText(Table data)
        //{
        //    pestPacData.CompanyConfiguration = data.CreateInstance<CompanyConfiguration>();

        //    string[] configFieldsToBeCleared = pestPacData.CompanyConfiguration.ConfigFieldsToBeCleared.Split(',');

        //    for (int p=0; p < configFieldsToBeCleared.Count(); p++)
        //    {
        //        Assert.True(configPage.ClearFieldText(configFieldsToBeCleared[p]), "Unable to clear the field text!");
        //    }

        //    //Save changed options
        //    LocationSearchPage locationSearchPage = configPage.Save();
        //    Thread.Sleep(5000);
        //    Assert.True(locationSearchPage.IsLoaded(), "Expected to be on Location Search Page, {0}", locationSearchPage.GetType());
        //}

        [Then(@"Close Report Window")]
        public void ThenCloseReportWindow()
        {
            var win = SUT.Web.WebDriver.WindowHandles;
            SUT.Log.Debug("windows count right before before window" + win.Count);
            //Close Report Window
            if (win.Count > 1)
            {

                SUT.Web.WebDriver.SwitchTo().Window(SUT.Web.WebDriver.WindowHandles.Last()).Close();
                SUT.Log.Debug("Report window closed.");
                //Switch back to PP Window
                SUT.Web.WebDriver.SwitchTo().Window(SUT.Web.WebDriver.WindowHandles.Last());
                SUT.Log.Debug("Switched bact to PP window.");
            }
        }

        [When(@"Switch to default content")]
        public void WhenSwitchToDefaultContent()
        {
            //Switch to default content
            SUT.Web.WebDriver.SwitchTo().DefaultContent();
        }

        [Given(@"Wait Time (.*)")]
        public void GivenWaitTime(int waitTime)
        {
            Thread.Sleep(waitTime);
        }

        [Then(@"Close Window based on WindowHandle")]
        public void ThenCloseWindowBasedOnWindowHandle()
        {
            var currentWindowURL = "";
            int activeWindowCount;

            //Get Active Window Count
            activeWindowCount = SUT.Web.WebDriver.WindowHandles.Count;
            SUT.Log.DebugFormat("Active Window Count: {0}", activeWindowCount);

            if (activeWindowCount > 1)
            {
                for (int i = 1; i <= activeWindowCount; i++)
                {
                    //Switching to Parent/Main Window
                    SUT.Web.WebDriver.SwitchTo().Window(SUT.Web.WebDriver.WindowHandles[0]);
                    //Switching to Default Content
                    SUT.Web.WebDriver.SwitchTo().DefaultContent();

                    //Switch and Close Last Window
                    SUT.Web.WebDriver.SwitchTo().Window(SUT.Web.WebDriver.WindowHandles.Last());
                    //Fetch and Display Window URL
                    currentWindowURL = SUT.Web.WebDriver.Url;
                    SUT.Log.DebugFormat("Current Window URL: {0}", currentWindowURL);
                    SUT.Web.WebDriver.SwitchTo().Window(SUT.Web.WebDriver.WindowHandles.Last()).Close();

                    //Get Active Window Count
                    activeWindowCount = SUT.Web.WebDriver.WindowHandles.Count;
                    SUT.Log.DebugFormat("Active Window Count: {0}", activeWindowCount);

                    if (activeWindowCount > 1)
                    {
                        continue;
                    }
                    else
                    {
                        //Switching to Parent/Main Window
                        SUT.Web.WebDriver.SwitchTo().Window(SUT.Web.WebDriver.WindowHandles[0]);
                        //Switching to Default Content
                        SUT.Web.WebDriver.SwitchTo().DefaultContent();

                        break;
                    }
                }
            }

        }

        //[When(@"Switch to slow network")]
        //public void WhenSwitchToslowNetwork()
        //{

        //    IWebDriver iWebDriver = SUT.Web.WebDriver;
        //    ChromeNetworkConditions conditions = new ChromeNetworkConditions();
        //    conditions.IsOffline = true;
        //    conditions.DownloadThroughput = 45 * 1000;
        //    conditions.UploadThroughput = 10 * 1000;
        //    conditions.Latency = TimeSpan.FromMilliseconds(1);
        //    (iWebDriver as ChromeDriver).NetworkConditions = conditions;
        //    //we can also manage the speed by using the pageload but this is not my first choice.
        //    //SUT.Web.WebDriver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(100000000));
        //    SUT.Web.WebDriver.Navigate().Refresh();
        //    Assert.True(noInternetPage.IsLoaded(), "Could not load the {0}", noInternetPage.GetType());
        //}

        [Then(@"Switch to normal network")]
        public void ThenSwitchTonormalNetwork()
        {

            IWebDriver iWebDriver = SUT.Web.WebDriver;
            ChromeNetworkConditions conditions = new ChromeNetworkConditions();
            conditions.IsOffline = false;
            conditions.DownloadThroughput = 45 * 1000;
            conditions.UploadThroughput = 10 * 1000;
            conditions.Latency = TimeSpan.FromMilliseconds(1);
            (iWebDriver as ChromeDriver).NetworkConditions = conditions;
            SUT.Web.WebDriver.Navigate().Refresh();
            Assert.False(SUT.Web.WebDriver.PageSource.Contains("No Internet"), "Collection History Not have the Event!");

        }

        [Then(@"Set Network to: (.*)")]
        public void ThenSetNetworkTo(string setNetworkTo)
        {
            IWebDriver iWebDriver = SUT.Web.WebDriver;
            ChromeNetworkConditions conditions = new ChromeNetworkConditions();

            if (setNetworkTo.Equals("Offline"))
            {
                conditions.IsOffline = true;
                SUT.Log.Debug("Set Network to Offline!");
            }
            else if (setNetworkTo.Equals("Online"))
            {
                conditions.IsOffline = false;
                SUT.Log.Debug("Set Network to Online!");
            }

            conditions.DownloadThroughput = 45 * 1000;
            conditions.UploadThroughput = 10 * 1000;
            conditions.Latency = TimeSpan.FromMilliseconds(1);
            (iWebDriver as ChromeDriver).NetworkConditions = conditions;
        }

        //[Then(@"Use WorkWave payment account updater")]
        //public void ThenUseWorkWavePaymentAccountUpdater(Table data)
        //{
        //    pestPacData.CompanyConfiguration = data.CreateInstance<CompanyConfiguration>();
        //    configPage.wwPaymentUpdater(pestPacData.CompanyConfiguration.WWPaymentUpdater);
        //}


        [Given(@"Endpoint (.*)")]
        public void GivenEndpoint(string endpoint)
        {
            UtilityClass.SetUrl1(endpoint);
        }
        [Given(@"a Endpoint (.*)")]
        public void GivenAEndpoint(string endpoint)
        {
            UtilityClass.SetUrl1(endpoint);
        }

        [Given(@"I am AuthorizeWWP2 (.*) and (.*) and (.*) and (.*)")]
        public void GivenIAmAuthorizeWWP2(string headerName, string getHeaders, string PostIDSer, string childToken)
        {
            UtilityClass.AuthorizeWWP2(headerName, getHeaders, PostIDSer, childToken);
        }

        //[When(@"Use copesan option")]
        //public void WhenUseCopesanOption(Table data)
        //{
        //    pestPacData.CompanyConfiguration = data.CreateInstance<CompanyConfiguration>();
        //    configPage.copesan(pestPacData.CompanyConfiguration.copesan);

        //    LocationSearchPage locationSearchPage = configPage.Save();
        //    Thread.Sleep(9000);
        //    Assert.True(locationSearchPage.IsLoaded(), "Expected to be on Location Search Page, {0}", locationSearchPage.GetType());
        //}


        //[Given(@"URL")]
        //public void GivenURL()
        //{
        //    SUT.Web.WebDriver.Navigate().GoToUrl(SUT.Web.Config.HomePage + "/scheduler/?BatchID=53");//68
        //    plannerPage.MoveFirstOrderInTimelineForTech();
        //}
        [When(@"I make GET call (.*) and (.*)")]
        public void WhenIMakeGETCall(string name, string token)
        {
            string path = UtilityClass.GetFilePath(name);
            UtilityClass.GetRequest(path, token);
        }

        [Then(@"Switch to Default Content")]
        public void ThenSwitchToDefaultContent()
        {
            SUT.Web.WebDriver.SwitchTo().DefaultContent();
        }

        //[When(@"Use ScanFiles Option")]
        //public void WhenUseScanFilesOption(Table data)
        //{
        //    pestPacData.Documents = data.CreateInstance<Documents>();
        //    configPage.scanFIlesOption(pestPacData.Documents.ScanFiles);
        //    //Save changed options
        //    LocationSearchPage locationSearchPage = configPage.Save();
        //    Thread.Sleep(9000);
        //    Assert.True(locationSearchPage.IsLoaded(), "Expected to be on Location Search Page, {0}", locationSearchPage.GetType());

        //}

        //This step can be used to ACCEPT any alert appears
        //Apart from that the Alert.Text will be verified
        [Given(@"Accept Alert: (.*)")]
        public void GivenAcceptAlert(string alertText)
        {
            if (SUT.Web.Alert != null && SUT.Web.Alert.Text.Contains(alertText))
            {
                SUT.Web.Alert_Accept();
                SUT.Log.Debug("Alert Accepted: " + alertText);
            }

            SUT.Log.Debug("No alerts present to handle!");
        }
    }
}
