using OpenQA.Selenium;
using System;
using WorkWave.TA.TestEngine;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace WorkWave.PestPac.TA
{
    public static class SalesCenterUtility
    {
        public static bool BackspaceClear(IWebElement element)
        {
            var numOfCharacters = element.GetAttribute("value").Length;

            if (numOfCharacters == 0)
            {
                numOfCharacters = element.Text.Length;
            }

            for (var i = 0; i < numOfCharacters; i++)
            {
                element.SendKeys(Keys.Backspace);
            }

            return element.GetAttribute("value") == "" && element.Text == "";
        }


        //Accepting/Dismissing alerts can affect application behavior
        public enum AlertHandlingType
        {
            Accept,
            Dismiss
        }

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
            var switched = false;
            switched = SeleniumUtility.ExplicitWaitForAction(() =>
            {
                SUT.Log.DebugFormat("Attempt to switch to frame");
                Thread.Sleep(1500);
                SUT.Web.WebDriver.SwitchTo().Frame(frame);

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => elementInFrame()),
                    TimeSpan.FromSeconds(2)))
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
            var switched = false;
            switched = SeleniumUtility.ExplicitWaitForAction(() =>
            {
                SUT.Log.DebugFormat("Attempt to switch to frame");
                Thread.Sleep(3000);
                SUT.Web.WebDriver.SwitchTo().Frame(frame);

                if (SeleniumUtility.WaitFor(SalesCenterUtility.ElementExists(frame)))
                {
                    return true;
                }

                SUT.Log.DebugFormat("Timed out looking for the element in frame");
                return false;
            }, timeout);
            return switched;
        }


        public static void ScrollToElement(IWebElement e)
        {
            try
            {

                SUT.Web.ExplicitWait.Until(CustomExpectedConditions.ElementIsVisible(() => e));

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

            if (!clicked)
                SUT.Log.ErrorFormat("Could not click element\n{0}");

            return clicked;
        }

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

        private static Func<IWebDriver, bool> ElementExists(IWebElement element)
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

        internal static void Alerts_CloseSequent(object dismiss)
        {
            throw new NotImplementedException();
        }
    }
}