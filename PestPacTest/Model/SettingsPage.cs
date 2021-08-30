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

namespace WorkWave.PestPac.TA.Model
{
    public class SettingsPage : IWebPage
    {

        #region Page Factory

        [FindsBy(How = How.XPath, Using = "(//p[text()='Settings Home'])[2]")]
        private IWebElement SettingsForm { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@type='button'])[4]")]
        private IWebElement SettingsGearIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Settings Home'])[2]")]
        private IWebElement SettingsHomePage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Company Setup']")]
        private IWebElement CompanySetUpLink { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//p[text()='Roles & Permissions']")]
        private IWebElement RolesandPermissionLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Users & Access']")]
        private IWebElement UsersandAccessLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Sales Funnels']")]
        private IWebElement SalesFunnelsLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Sales Teams']")]
        private IWebElement SalesTeamsLink { get { return PageFactory.Load(this); } }

        #region Roles and Permission 


        [FindsBy(How = How.XPath, Using = "//span[text()='Add Role']")]
        private IWebElement ClickAddRoleMainbutton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//label[text()='Role Name']/following::input[1]")]
        private IWebElement RoleName_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='All']")]
        private IWebElement All_Link { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[@type='button']/child::span[contains(text(),'Add Role')]")]
        private IWebElement ClickAddRolebutton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Add Role'])[3]")]
        private IWebElement ClickAddRoleSaveButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='Sales manager1']/descendant::button")]
        private IWebElement ThreeDotsIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@class,'MuiTypography-root MuiListItemText-primary')])[2]/..")]
        private IWebElement DeleteOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@id='root']/following-sibling::div[5]/descendant::button[2]")]
        private IWebElement Deletebutton { get { return PageFactory.Load(this); } }

        #endregion Roles and Permission 

        #region Sales funnel

        [FindsBy(How = How.XPath, Using = "//span[text()='Add Sales Funnel']")]
        private IWebElement ClickOnSalesFunnelButton { get { return PageFactory.Load(this); } }
       
       [FindsBy(How = How.XPath, Using = "//label[text()='Name']/following::input[1]")]
        private IWebElement SalesFunnelNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Save']")]
        private IWebElement ClickFunnelSavebutton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Automation funnel']/../following-sibling::div/child::button")]
        private IWebElement ClickThreeDotsIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Delete']/../..")]
        private IWebElement ClickDeleteOption { get { return PageFactory.Load(this); } }


        #endregion Sales funnel

        #region Users and Access

        [FindsBy(How = How.XPath, Using = "//span[text()='Add Unmapped User']/..")]
        private IWebElement ClickOnUnmappedButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement UserFirstNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement UserLastNamefield { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.Id, Using = "emailAddress")]
        private IWebElement UserEmailNamefield { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[@id='mui-component-select-role']/..")]
        private IWebElement SelectRoleName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@id='mui-component-select-role']/..")]
        private IWebElement ClickRoleField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='SalesManager']")]
        private IWebElement SelectRolename { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='+ Add Sales Team']/..")]
        private IWebElement ClickAddSalesTeamOption { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[@id='mui-component-select-salesTeamAssignments[0].salesTeamId']/..")]
        private IWebElement ClickSalesTeamField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Secondary south sales Team']")]
        private IWebElement SelectSalesTeamname { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Lead']/..")]
        private IWebElement SelectSalesTeamPosition { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Save']/..")]
        private IWebElement ClickSaveButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='alert']")]
        private IWebElement ValidationConfirm_Txt { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//td[text()='Automation user']/preceding-sibling::td")]
        private IWebElement ClickThreeDotsIconforUnmappedUser { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Delete'])[2]")]
        private IWebElement DeleteoptionforAddedUser { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Delete']")]
        private IWebElement ClickDeletebuttonInPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='User deleted']")]
        private IWebElement DeleteConfirm_Txt { get { return PageFactory.Load(this); } }


        #endregion Users and Access



        #region Sales Team

        [FindsBy(How = How.XPath, Using = "//span[text()='Add Sales Team']/..")]
        private IWebElement AddSalesTeamButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//label[text()='Name']/following::input[1]")]
        private IWebElement SalesTeamNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'MuiSelect-root MuiSelect-select')]/..")]
        private IWebElement ClickBranchField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='North Branch']")]
        private IWebElement SelectBranchName { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[text()='Sales Team created']")]
        private IWebElement SalesTeamCreatedValidationConfirm_Txt { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='autosalesteam']/../following-sibling::div/descendant::button[2]")]
        private IWebElement ClickThreeDotsIconforSalesTeam { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiListItemText-root MuiListItemText-dense']//span)[2]")]
        private IWebElement DeleteoptionforSalesTeam { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='Sales Team deleted.']")]
        private IWebElement SalesTeamDeleteConfirm_Txt { get { return PageFactory.Load(this); } }

        #endregion Sales Team

        #region Add position

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'autosalesteam')]/../following-sibling::div/descendant::button")]
        private IWebElement ClickAddPositionButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//label[text()='Title']/following::input")]
        private IWebElement TitleNamefield { get { return PageFactory.Load(this); } }


        #endregion Add position


        public virtual bool IsLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SettingsForm), TimeSpan.FromSeconds(10)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ClickonSettingsGearIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SettingsGearIcon)))
                {
                    SettingsGearIcon.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Settings gear icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Settings gear icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Settings gear icon is not clicked");
            }
        }

        public void ClickonCompanySetUpLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CompanySetUpLink)))
                {
                    CompanySetUpLink.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Company setup link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Company setup link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Company setup link is not clicked");
            }
        }

        public void ClickonRolesAndPermissionLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => RolesandPermissionLink)))
                {
                    RolesandPermissionLink.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Roles and permission is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Roles and permission is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Roles and permission is not clicked");
            }
        }

        public void ClickonUsersAndAccessLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UsersandAccessLink)))
                {
                    UsersandAccessLink.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("User and access link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("User and access link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("User and access link is not clicked");
            }
        }

        public void ClickonSalesFunnelsLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SalesFunnelsLink)))
                {
                    SalesFunnelsLink.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Sales funnel link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales funnel link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales funnel link is not clicked");
            }
        }

        public void ClickonSalesTeamsLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SalesTeamsLink)))
                {
                    PestPacUtility.ScrollToElement(SalesTeamsLink);
                    SalesTeamsLink.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Sales team link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team link is not clicked");
            }
        }
      
        public void ClickOnAddRoleMainButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddRoleMainbutton)))
                {
                    ClickAddRoleMainbutton.Click();
                    SUT.Log.DebugFormat("AddRole main button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("AddRole main button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("AddRole main button is not clicked");
            }
        }


        public void ClickOnAllLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => All_Link)))
                {
                    All_Link.Click();
                    SUT.Log.DebugFormat("All link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("All link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("All link is not clicked");
            }
        }

        public void ClickOnAddRoleSaveButton()
        {
            try { 
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddRoleSaveButton)))
            {
                ClickAddRoleSaveButton.Click();
                  SUT.Log.DebugFormat("AddRole save button is clicked");
                }
            else
            {
                SUT.Log.ErrorFormat("AddRole save button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
            }
        }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("AddRole save button is not clicked");
            }
        }

        public void EnterRoleName(string name)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => RoleName_Field)))
                {
                    RoleName_Field.SendKeys(name);
                    SUT.Log.DebugFormat("AddRole save button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("AddRole save button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("AddRole save button is not clicked");
            }
        }

        public void ClickOnThreeDots()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ThreeDotsIcon)))
                {
                    PestPacUtility.ScrollToElement(ThreeDotsIcon);
                    ThreeDotsIcon.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Three dots icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Three dots icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Three dots icon is not clicked");
            }
        }

        public void ClickOnDeleteOption()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DeleteOption)))
                {
                    DeleteOption.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delete option is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Delete option is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Delete option is not clicked");
            }
        }

        public void ClickOnDeletebutton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => Deletebutton)))
                {
                    Deletebutton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delete button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Delete button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Delete button is not clicked");
            }
        }

        //Add Sales Funnel 

        public void ClickAddSalesFunnelButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOnSalesFunnelButton)))
                {
                    ClickOnSalesFunnelButton.Click();
                    SUT.Log.DebugFormat("Add sales funnel button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add sales funnel button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add sales funnel button is not clicked");
            }
        }

        public void EnterSalesFunnelName(string name)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SalesFunnelNamefield)))
                {
                    SalesFunnelNamefield.SendKeys(name);
                    SUT.Log.DebugFormat("Sales funnel name is entered");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales funnel name is not entered {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales funnel name is not entered");
            }
        }


        public void ClickOnFunnelSaveButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickFunnelSavebutton)))
                {
                    ClickFunnelSavebutton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Sales funnel save button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales funnel save button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales funnel save button is not clicked");
            }
        }

        public void ClickOnThreeDotsIconforSalesFunnel()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIcon)))
                {
                    ClickThreeDotsIcon.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Threedot icon for sales funnel is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Threedot icon for sales funnel is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Threedot icon for sales funnel is not clicked ");
            }
        }

        public void ClickOnDeleteOptionforSalesFunel()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteOption)))
                {
                    ClickDeleteOption.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delete option for sales funnel is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Delete option for sales funnel is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Delete option for sales funnel is not clicked ");
            }
        }

    //Add and Delete Unmapped user


    public void ClickAddUnmappedButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOnUnmappedButton), TimeSpan.FromSeconds(5)))
                {
                    ClickOnUnmappedButton.Click();
                    SUT.Log.DebugFormat("Add unmapped button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add unmapped button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add unmapped button is not clicked ");
            }
        }
        public void EnterUserDetails(string firstname, string lastname, string email)
        {
            UserFirstNamefield.SendKeys(firstname);
            UserLastNamefield.SendKeys(lastname);
            UserEmailNamefield.SendKeys(email);
        }

        public void SelectRoleDropdown(String rolename)
        {
            PestPacUtility.SelectDropDown(SelectRoleName, rolename);
        }
            
        public void SelectRoleFromTheDropDown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickRoleField), TimeSpan.FromSeconds(5)))
                {
                    ClickRoleField.Click();
                    Thread.Sleep(2000);
                    PestPacUtility.ScrollToElement(SelectRolename);
                    SelectRolename.Click();
                    SUT.Log.DebugFormat("Role is selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Role is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Role is not selected from the droddown ");
            }
        }

        public void ClickAddSalesTeamoption()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddSalesTeamOption)))
                {
                    ClickAddSalesTeamOption.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Sales team option is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team option is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team option is not clicked");
            }
        }
     
        public void SelectSalesTeamFromTheDropDown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesTeamField)))
                {
                    ClickSalesTeamField.Click();
                    Thread.Sleep(2000);
                    PestPacUtility.ScrollToElement(SelectSalesTeamname);
                    SelectSalesTeamname.Click();
                    SUT.Log.DebugFormat("Sales team is selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team is not selected from the droddown");
            }
        }

        public void ClickSalesTeamPosition()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SelectSalesTeamPosition)))
                {
                    PestPacUtility.ScrollToElement(SelectSalesTeamPosition);
                    SelectSalesTeamPosition.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Sales team position is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team position is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team position is not clicked");
            }
        }

        public void ClickSaveButtonInUserSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButton)))
                {
                    ClickSaveButton.Click();
                    Thread.Sleep(8000);
                    SUT.Log.DebugFormat("Save button is clicked in user slider");
                }
                else
                {
                    SUT.Log.ErrorFormat("Save button is not clicked in user slider {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Save button is not clicked in user slider");
            }
        }

        public bool VerifyConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ValidationConfirm_Txt)))
            {
                SUT.Log.Debug("Validation  message is displayed");
                Assert.True(ValidationConfirm_Txt.Text.Contains(message), "Validation message is not matching");
                Thread.Sleep(8000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Validation message is displayed");
                return false;
            }
        }

        public void ClickOnThreeDotsIconforAddedUser()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconforUnmappedUser)))
                {
                    PestPacUtility.ScrollToElement(ClickThreeDotsIconforUnmappedUser);
                    ClickThreeDotsIconforUnmappedUser.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Three dots icon is clicked for added user");
                }
                else
                {
                    SUT.Log.ErrorFormat("Three dots icon is not clicked for added user {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Three dots icon is not clicked for added user");
            }
        }

        public void ClickOnDeleteOptionforUnMappedUser()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DeleteoptionforAddedUser)))
                {
                    DeleteoptionforAddedUser.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delete option is clicked for unmapped user");
                }
                else
                {
                    SUT.Log.ErrorFormat("Delete option is not clicked for unmapped user {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Delete option is not clicked for unmapped user");
            }
        }

        public void ClickDeleteButtonInPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeletebuttonInPopup)))
                {
                    ClickDeletebuttonInPopup.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delet button is clicked in the popup");
                }
                else
                {
                    SUT.Log.ErrorFormat("Delete button is not clicked in the popup {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Delete button is not clicked in the popup");
            }
        }

        public bool VerifyDeleteConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DeleteConfirm_Txt)))
            {
                SUT.Log.Debug("User is deleted message is displayed");
                Assert.True(DeleteConfirm_Txt.Text.Contains(message), "Message is not matching");
                Thread.Sleep(7000);
                return true;
            }
            else
            {
                SUT.Log.Debug("User is deleted message is displayed");
                return false;
            }
        }

        //Add and Delete Sales team

        public void ClickAddSalesTeamButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => AddSalesTeamButton)))
                {
                    AddSalesTeamButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Add sales team button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add sales team button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add sales team button is not clicked");
            }
        }

        public void EnterSalesTeamName(string salesteamname)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SalesTeamNamefield)))
                {
                    SalesTeamNamefield.SendKeys(salesteamname);
                    SUT.Log.DebugFormat("Sales Team name is entered");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales Team name is not entered {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales Team name is not entered");
            }
        }
        
        public void SelectBranch()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickBranchField)))
                {
                    ClickBranchField.Click();
                    Thread.Sleep(2000);
                    SelectBranchName.Click();
                    SUT.Log.DebugFormat("Branch is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Branch is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Branch is not selected");
            }
        }

        public bool VerifySalesTeamCreatedConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ValidationConfirm_Txt)))
            {
                SUT.Log.Debug("Validation  message is displayed");
                Assert.True(ValidationConfirm_Txt.Text.Contains(message), "Validation message is not matching");
                Thread.Sleep(8000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Validation message is displayed");
                return false;
            }
        }

        public void ClickOnThreeDotsIconforAddedSalesTeam()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconforSalesTeam)))
                {
                    ClickThreeDotsIconforSalesTeam.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Three dots icon is clicked for added sales team");
                }
                else
                {
                    SUT.Log.ErrorFormat("Three dots icon is not clicked for added sales team {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Three dots icon is not clicked for added sales team ");
            }

        }

        public void ClickOnDeleteOptionforSalesTeam()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DeleteoptionforSalesTeam)))
                {
                    DeleteoptionforSalesTeam.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delete option is clicked for added sales team");
                }
                else
                {
                    SUT.Log.ErrorFormat("Delete option is not clicked for added sales team {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Delete option is not clicked for added sales team ");
            }

        }

        public bool VerifySalesTeamDeleteConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SalesTeamDeleteConfirm_Txt)))
            {
                SUT.Log.Debug("User is deleted message is displayed");
                Assert.True(SalesTeamDeleteConfirm_Txt.Text.Contains(message), "Message is not matching");
                Thread.Sleep(7000);
                return true;
            }
            else
            {
                SUT.Log.Debug("User is deleted message is displayed");
                return false;
            }
        }

        //Add position to sales team

        public void ClickOnAddPositionButton()
        {           
                try
                {                 
                    if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddPositionButton)))
                    {
                        ClickAddPositionButton.Click();
                        Thread.Sleep(2000);
                        SUT.Log.DebugFormat("Add position button is clicked");
                    }
                    else
                    {
                        SUT.Log.ErrorFormat("Add position button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                    }
                }
                catch (WebDriverTimeoutException)
                {
                    SUT.Log.ErrorFormat("Add position button is not clicked");
                }
        }

        public void EnterPositionTitle(string titlename)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => TitleNamefield)))
                {
                    TitleNamefield.SendKeys(titlename);
                    SUT.Log.DebugFormat("Position title is entered");
                }
                else
                {
                    SUT.Log.ErrorFormat("Position title is not entered {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Position title is not entered");
            }
        }
    }




}
#endregion