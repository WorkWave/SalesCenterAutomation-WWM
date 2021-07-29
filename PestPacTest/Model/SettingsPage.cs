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

        [FindsBy(How = How.XPath, Using = "//div[text()='Auto Sales manager1']/descendant::button")]
        private IWebElement ThreeDotsIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[contains(@class,'MuiTypography-root MuiListItemText-primary')])[2]/..")]
        private IWebElement DeleteOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='presentation']/following-sibling::div[22]/following-sibling::div/descendant::button[2]")]
        private IWebElement Deletebutton { get { return PageFactory.Load(this); } }

        #endregion Roles and Permission 

        #region Sales funnel

        [FindsBy(How = How.XPath, Using = "//span[text()='Add Sales Funnel']")]
        private IWebElement ClickOnSalesFunnelButton { get { return PageFactory.Load(this); } }
       
       [FindsBy(How = How.XPath, Using = "//label[text()='Name']/following::input[1]")]
        private IWebElement SalesFunnelNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Save']")]
        private IWebElement ClickFunnelSavebutton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Automation funnel1']/../following-sibling::div/child::button")]
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

        [FindsBy(How = How.XPath, Using = "//li[text()='AutomationTestingRole']")]
        private IWebElement SelectRolename { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='+ Add Sales Team']/..")]
        private IWebElement ClickAddSalesTeamOption { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[@id='mui-component-select-salesTeamAssignments[0].salesTeamId']/..")]
        private IWebElement ClickSalesTeamField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='AutoTestingSalesTeam']")]
        private IWebElement SelectSalesTeamname { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Sales Manager']/..")]
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

        [FindsBy(How = How.XPath, Using = "//li[text()='Sales Center Test Branch']")]
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
            SettingsGearIcon.Click();
            Thread.Sleep(3000);
        }

        public void ClickonCompanySetUpLink()
        {
            CompanySetUpLink.Click();
            Thread.Sleep(3000);
           
        }

        public void ClickonRolesAndPermissionLink()
        {

            RolesandPermissionLink.Click();
            Thread.Sleep(3000);
        }

        public void ClickonUsersAndAccessLink()
        {

            UsersandAccessLink.Click();
            Thread.Sleep(3000);

           
        }

        public void ClickonSalesFunnelsLink()
        {
            SalesFunnelsLink.Click();
             Thread.Sleep(3000);
        }

        public void ClickonSalesTeamsLink()
        {
            PestPacUtility.ScrollToElement(SalesTeamsLink);
            SalesTeamsLink.Click();
            Thread.Sleep(3000);
        }

        //public void EnterRolesName(string name)
        //{
        //    if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => RoleName_Field)))
        //    {
        //        RoleName_Field.SendKeys(name);
        //    }

        //}

        public void ClickOnAddRoleMainButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddRolebutton)))
            {
                ClickAddRoleMainbutton.Click();
            }
        }



        public void ClickOnAllLink()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => All_Link)))
            {
                All_Link.Click();
            }
        }

        public void ClickOnAddRoleSaveButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddRoleSaveButton)))
            {
                ClickAddRoleSaveButton.Click();
            }
        }


        public void EnterRoleName(string name)
        {
            RoleName_Field.SendKeys(name);
        }

        public void ClickOnThreeDots()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ThreeDotsIcon)))
            {
                PestPacUtility.ScrollToElement(ThreeDotsIcon);
                ThreeDotsIcon.Click();
                Thread.Sleep(2000);
               
            }
        }

        public void ClickOnDeleteOption()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DeleteOption)))
            {
                DeleteOption.Click();
                Thread.Sleep(2000);
            }
        }

        public void ClickOnDeletebutton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => Deletebutton)))
            {
                Deletebutton.Click();
                Thread.Sleep(2000);
            }
        }

        //Add Sales Funnel 

        public void ClickAddSalesFunnelButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOnSalesFunnelButton)))
            {
                ClickOnSalesFunnelButton.Click();
            }
        }

        public void EnterSalesFunnelName(string name)
        {
            SalesFunnelNamefield.SendKeys(name);
        }

        public void ClickOnFunnelSaveButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickFunnelSavebutton)))
            {
                ClickFunnelSavebutton.Click();
                Thread.Sleep(2000);
            }
        }

        public void ClickOnThreeDotsIconforSalesFunnel()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIcon)))
            {
                ClickThreeDotsIcon.Click();
                Thread.Sleep(2000);
            }
        }

        public void ClickOnDeleteOptionforSalesFunel()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteOption)))
            {
                ClickDeleteOption.Click();
                Thread.Sleep(2000);
            }
        }

    //Add and Delete Unmapped user


    public void ClickAddUnmappedButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOnUnmappedButton), TimeSpan.FromSeconds(5)))
            {
                ClickOnUnmappedButton.Click();
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
            ClickRoleField.Click();
            Thread.Sleep(2000);
            PestPacUtility.ScrollToElement(SelectRolename);
            SelectRolename.Click();

        }

        public void ClickAddSalesTeamoption()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddSalesTeamOption)))
            {
                ClickAddSalesTeamOption.Click();
                Thread.Sleep(2000);
            }
        }

        public void SelectSalesTeamFromTheDropDown()
        {
            ClickSalesTeamField.Click();
            Thread.Sleep(2000);
            PestPacUtility.ScrollToElement(SelectSalesTeamname);
            SelectSalesTeamname.Click();

        }

        public void ClickSalesTeamPosition()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SelectSalesTeamPosition)))
            {
                PestPacUtility.ScrollToElement(SelectSalesTeamPosition);
                SelectSalesTeamPosition.Click();
                Thread.Sleep(2000);
            }
        }

        public void ClickSaveButtonInUserSlider()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButton)))
            {
                ClickSaveButton.Click();
                Thread.Sleep(8000);
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
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconforUnmappedUser)))
            {

                PestPacUtility.ScrollToElement(ClickThreeDotsIconforUnmappedUser);
                ClickThreeDotsIconforUnmappedUser.Click();
                Thread.Sleep(2000);
            }
        }

        public void ClickOnDeleteOptionforUnMappedUser()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DeleteoptionforAddedUser)))
            {
                DeleteoptionforAddedUser.Click();
                Thread.Sleep(2000);
            }
        }

        public void ClickDeleteButtonInPopup()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeletebuttonInPopup)))
            {
                ClickDeletebuttonInPopup.Click();
                Thread.Sleep(2000);
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
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => AddSalesTeamButton)))
            {
                AddSalesTeamButton.Click();
                Thread.Sleep(2000);
            }
        }

        public void EnterSalesTeamName(string salesteamname)
        {
            SalesTeamNamefield.SendKeys(salesteamname);
        }

        public void SelectBranch()
        {
            ClickBranchField.Click();
            Thread.Sleep(2000);
            SelectBranchName.Click();

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
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconforSalesTeam)))
            {
                ClickThreeDotsIconforSalesTeam.Click();
                Thread.Sleep(2000);
            }
        }

        public void ClickOnDeleteOptionforSalesTeam()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DeleteoptionforSalesTeam)))
            {
                DeleteoptionforSalesTeam.Click();
                Thread.Sleep(2000);
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

    }




}
#endregion