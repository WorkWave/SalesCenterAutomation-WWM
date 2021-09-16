using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using WorkWave.TA.TestEngine;
using TechTalk.SpecFlow.Assist;
using WorkWave.PestPac.TA.SharedData;
using WorkWave.PestPac.TA.Model;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Interactions;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text;
using System.Threading;

namespace WorkWave.PestPac.TA
{
    public enum RecordType
    {
        Automatic,
        Manual,
        Undefined
    }

    public enum PaymentType
    {
        Cash,
        Credit
    }

    public enum TableType
    {
        Email,
        Document,
        Form,
        Letter,
        ServiceOrder,
        ServiceSetup,
        Invoice,
        Leads,
        Renewal,
        Program,
        Warranty
    }

    //Accepting/Dismissing alerts can affect application behavior
    public enum AlertHandlingType
    {
        Accept,
        Dismiss
    }
    public enum Processor
    {
        Vantiv,
        WWP,
        WWP2,
        WWPReal,
        None
    }
    public class SalesCenterUtility
    {
        public static void InitializePestPacData(Table data, ref SalesCenterData salesCenterData)
        {
            salesCenterData.Location = data.CreateInstance<Location>();

            salesCenterData.Payment = data.CreateInstance<Payment>();
            salesCenterData.Leads = data.CreateInstance<Leads>();
                    
        }

        public static Processor ConvertStringToEnum(string provider)
        {
            return provider == "Vantiv"
                        ? Processor.Vantiv
                        : provider == "WWP"
                        ? Processor.WWP
                        : provider == "WWP2" //Smoke Testing WWP2
                        ? Processor.WWP2
                         : provider == "WWPReal" //All ScriptsWWP2
                        ? Processor.WWPReal
                        : Processor.None;
                                                    
        }
        public static void ScrollToElement(IWebElement e)
        {
            try
            {
                
                SUT.Web.ExplicitWait.Until(CustomExpectedConditions.ElementIsVisible(()=>e));

                if (SUT.Web.Config.Browser.Equals("Chrome"))
                {
                    SUT.Log.DebugFormat("In ScrollTo Element");
                    SUT.Log.DebugFormat("Trying to scroll to {0}", e.ToString());
                    SUT.Web.JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", e);
                }
            }
            catch (ElementNotVisibleException exc)
            {
                SUT.Log.Error(exc.Message);
            }
        }

        public static bool SelectDropDown(IWebElement elem, string ItemName)
        {
            if (elem != null)
            {
                SelectElement select = new SelectElement(elem);
                try
                {
                    select.SelectByText(ItemName);
                    return true;
                }
                catch (Exception)
                {
                    SUT.Log.DebugFormat("Could not select item {0} from element {1}", ItemName, elem);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static Func<IWebDriver, bool> ElementIsEnabled(Func<IWebElement> element)
        {
            return (d) =>
            {
                try
                {
                    if (element() != null)
                    {
                        return element().Enabled && element().Displayed;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            };
        }
        public static bool BackspaceClear(IWebElement element)
        {
            int numOfCharacters = element.GetAttribute("value").Length;
            
            if(numOfCharacters == 0)
            {
                numOfCharacters = element.Text.Length;
            }
            for (int i = 0; i < numOfCharacters; i++)
            {
                element.SendKeys(Keys.Backspace);
            }
            if (element.GetAttribute("value") == "" && element.Text == "")
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Pass the file in that you wish to get the directory for.
        /// Note that this file has to be in the Resources folder
        /// </summary>
        /// <param name="file"></param>
        public static string GetFilePath(string file)
        {
            string workingDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string newDir = String.Format("{0}\\Resources\\{1}", workingDir, file);
            return newDir;
        }
        //public static IWebPage NewMenuOption(string MenuOption)
        //{
        //    IWebPage newpage = null;
        //    switch (MenuOption)
        //    {
        //        case "Adjustments":
        //            newpage = new PostAdjustmentPage();
        //            break;
        //        case "Create Credit Memo":
        //            newpage = new CreditMemoBatchPage();
        //            break;
        //        case "All Reports":
        //            newpage = new ReportsPage();
        //            break;
        //        case "Company Setup":
        //            newpage = new CompanySetupPage();
        //            break;
        //        case "Generate Service Orders":
        //            newpage = new GenerateServiceOrdersPage();
        //            break;
        //        case "Release Credit Card Billing":
        //            newpage = new ReleaseCCBillingPage();
        //            break;
        //        case "Lookup Tables":
        //            newpage = new LookupTablesPage();
        //            break;
        //        case "List Management":
        //            newpage = new ListManagementPage();
        //            break;
        //        case "RouteOp Dynamic Planner":
        //            newpage = new RouteOpPage();
        //            break;
        //        case "Close Period":
        //            newpage = new ClosePeriodPage();
        //            break;
        //        case "Report Writer":
        //            newpage = new ReportWriterPage();
        //            break;
        //        case "Reverse Payment":
        //            newpage = new EnterReversePaymentPage();
        //            break;
        //        case "Data Update Tools":
        //            newpage = new ToolsPage();
        //            break;
        //        case "Post Service Orders":
        //            newpage = new PostServiceOrdersPage();
        //            break;
        //        case "Executive Dashboard":
        //            newpage = new ExecutiveDashboardPage();
        //            break;
        //        case "Enter Payments":
        //            newpage = new PostPaymentPage();
        //            break;
        //        case "PestPac Business Analytics":
        //            newpage = new BusinessAnalyticsPage();
        //            break;
        //        case "Printer/Email Setup":
        //            newpage = new PrinterOrEmailSetupPage();
        //            break;
        //        case "Print Statements":
        //            newpage = new StatementsPage();
        //            break;
        //        case "Manage Collections":
        //            newpage = new CollectionManagerPage();
        //            break;
        //        case "Print Consolidated Invoices":
        //            newpage = new PrintConsolidatedInvoicePage();
        //            break;
        //        case "Vehicle Maintenance":
        //            newpage = new VehicleMaintenancePage();
        //            break;
        //        case "Service Price Increase":
        //            newpage = new ServicePriceIncreaseBatchPage();
        //            break;
        //        case "Automation":
        //            newpage = new AutomationSettingsPage();
        //            break;
        //        case "Email Queue":
        //            newpage = new ManageEmailPage();
        //            break;
        //        case "Leads":
        //            newpage = new ViewLeadsPage();
        //            break;
        //        default:
        //            throw new NotImplementedException(String.Format("Factory for {0} page not implemented", MenuOption));
        //    }
        //    return newpage;
        //}
        //public static IWebPage LookupTable(string name)
        //{
        //    switch (name)
        //    {
        //        case "Threshold Alerts":
        //            return new ThresholdAlertsPage();
        //        case "Employees":
        //            return new EmployeesLookupTablesPage();
        //        case "Branches":
        //            return new BranchesLookupTablesPage();
        //        case "Services":
        //            return new MaintainServicesPage();
        //        case "Materials":
        //            return new MaterialsLookupTablesPage();
        //        case "Work Day Calendars":
        //            return new WDCPage();
        //        case "Units of Measure":
        //            return new MaintainUnitsOfMeasurePage();
        //        case "Tax Codes":
        //            return new TaxCodeLookupTablesPage();
        //        case "Schedule Types":
        //            return new MaintainSchedulesLookupTablePage();
        //        case "Task Types":
        //            return new TaskTypesPage();
        //        case "Sales Statuses":
        //            return new MaintainSalesStatusPage();
        //        case "GL Codes":
        //            return new MaintainGLCodesPage();
        //        default:
        //            throw new NotImplementedException(String.Format("Factory for {0} page not implemented", name));
        //    }
        //}

        /// <summary>
        /// Close alert and all sequent alerts that may follow
        /// </summary>
        /// <param name="alertType">Specify how you would like to handle the alert, Accept or Dismiss</param>
        public static void Alerts_CloseSequent(AlertHandlingType alertType)
        {
            int alertCount = 0;

            while (SUT.Web.Alert != null)
            {
                alertCount++;
                SUT.Log.DebugFormat("Alert: {0}", SUT.Web.Alert.Text);

                SUT.Log.DebugFormat("{0} the alert", alertType.ToString());
                if (alertType == AlertHandlingType.Accept)
                {
                    SUT.Web.Alert_Accept();
                }
                else
                {
                    SUT.Web.Alert_Dismiss();
                }

                System.Threading.Thread.Sleep(500);
            }

            if (alertCount > 0)
            {
                SUT.Log.DebugFormat("Total Alerts found: {0}", alertCount);
            }
        }
        public static bool Frame_SafeSwitch(IWebElement frame, Func<IWebElement> elementInFrame, int timeout = 5)
        {
            bool switched = false;
            switched = SeleniumUtility.ExplicitWaitForAction(() =>
            {
                SUT.Log.DebugFormat("Attempt to switch to frame");
                Thread.Sleep(1500);
                SUT.Web.WebDriver.SwitchTo().Frame(frame);

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(()=>elementInFrame()), TimeSpan.FromSeconds(2)))
                {
                    return true;
                }
                else
                {
                    SUT.Log.DebugFormat("Timed out looking for the element in frame");
                    return false;
                }
            }, timeout);
            return switched;
        }
        public static bool Frame_SafeSwitch_without_elementInFrame(IWebElement frame, int timeout = 5)
        {
            bool switched = false;
            switched = SeleniumUtility.ExplicitWaitForAction(() =>
            {
                SUT.Log.DebugFormat("Attempt to switch to frame");
                Thread.Sleep(3000);
                SUT.Web.WebDriver.SwitchTo().Frame(frame);

                if (SeleniumUtility.WaitFor(SalesCenterUtility.ElementExists(frame)))
                {
                    return true;
                }
                else
                {
                    SUT.Log.DebugFormat("Timed out looking for the element in frame");
                    return false;
                }
            }, timeout);
            return switched;
        }
        // Temp solution since Chris will be adding this to the test engine
        public static void DbleClick(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            //action.moveToElement(element).doubleClick().perform();
            action.DoubleClick(element).Perform();

        }


        /// <summary>
        /// Pass in the window handle of the page prior to the new window.
        /// </summary>
        /// <param name="previousWindowHandle"></param>
        /// <returns></returns>
        public static bool WaitForNewWindow(string previousWindowHandle)
        {
            string expectedWindow;
            bool test = SeleniumUtility.ExplicitWaitForAction(() =>
             {
                 try
                 {
                     expectedWindow = SUT.Web.WebDriver.WindowHandles.Last();
                     SUT.Log.InfoFormat("Waiting for new Window");
                     if (previousWindowHandle != expectedWindow)
                     {
                         return true;
                     }
                     else
                     {
                         return false;
                     }
                 }
                 catch (Exception e)
                 {
                     SUT.Log.WarnFormat("Waiting for new windowHandle to Load {0}", e.Message);
                     return false;
                 }
             }, 3, 1);
            return test;
        }
        /// <summary>
        /// Shortens a string to a certain length.
        /// Several places names, descriptions, etc. are shortened and replaced by ...
        /// This will allow you to shorten the string when searching for texts.
        /// </summary>
        /// <param name="shortenNum"></param>
        /// <param name="stringToShorten"></param>
        /// <returns></returns>
        public static string ShortenString(int len, string stringToShorten)
        {
            int r = stringToShorten.Length - len;
            stringToShorten = stringToShorten.Remove(len, r);

            return stringToShorten;
        }

        public static string PDFFormatParser(string pdfFileName)
        {
            StringBuilder result = new StringBuilder();
            // Create a reader for the given PDF file
            using (PdfReader reader = new PdfReader(pdfFileName))
            {
                // Read Every page
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    SimpleTextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string pageText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
                    result.Append(pageText);

                }
            }
            string Result = result.ToString().Trim();
            return Result;
        }
        public static bool VerifyPDF(string pdftext, params string[] expectedValues)
        {
            bool textMatches = false;
            SUT.Log.Debug(pdftext);
                if (expectedValues.All(text => pdftext.Contains(text)))
                {
                    textMatches = true;
                }        
            return textMatches;
           
        }
        public void CloseOtherTabs(string _startWindowHandle)
        {
            _startWindowHandle = SUT.Web.WebDriver.CurrentWindowHandle;

            if (_startWindowHandle == null)
            {
                throw new Exception("You should include OpenPestPac if you want to use CloseTabs ");
            }

            var handles = SUT.Web.WebDriver.WindowHandles.ToList();

            foreach (var handle in handles.Where(handle => handle != _startWindowHandle))
            {
                try
                {
                    SUT.Web.WebDriver.SwitchTo().Window(handle).Close();
                }
                catch
                {
                    //TODO: Check why we are trying to close that is not existing
                }
            }
            SUT.Web.WebDriver.SwitchTo().Window(_startWindowHandle);
        }

        //TODO - This needs to be added to Test Engine so that others can use it
        /// <summary>
        /// Element needs to be visible and enabled for it to be deemed clickable
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static Func<IWebDriver, bool> ElementIsClickable(IWebElement element)
        {
            return (d) =>
            {
                try
                {
                    return element.Displayed && element.Enabled;
                }
                catch (Exception e)
                {
                    SUT.Log.DebugFormat(e.GetType().ToString() + ": element is not clickable");
                    return false;
                }
            };
        }

        public static Func<IWebDriver, bool> ElementExists(IWebElement element)
        {
            return (d) =>
            {
                try
                {
                    return (element != null);
                }
                catch (Exception e)
                {
                    SUT.Log.DebugFormat(e.GetType().ToString() + ": element does not exist");
                    return false;
                }
            };
        }

        public static bool Click(IWebElement element, bool wait = true, bool useJS = false)
         {
            bool clicked = SeleniumUtility.ExplicitWaitForAction(() =>
            {
                bool clickReady = true;

                try
                {
                    if (wait)
                    {
                        if (useJS)
                        {
                            clickReady = SeleniumUtility.WaitFor(SalesCenterUtility.ElementExists(element));
                        }
                        else
                        {
                            clickReady = SeleniumUtility.WaitFor(SalesCenterUtility.ElementIsClickable(element));
                        }
                    }

                    if (clickReady)
                    {
                        if (useJS)
                        {
                            SUT.Web.JavaScriptExecutor.ExecuteScript("arguments[0].click()", element);
                        }
                        else
                        {
                            element.Click();
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {                    
                    return false;
                }
            }, 2, 1000);

            if(!clicked)
                SUT.Log.ErrorFormat("Could not click element\n{0}");

            return clicked;
        }

    }
}

