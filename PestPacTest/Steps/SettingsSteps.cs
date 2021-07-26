using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using WorkWave.PestPac.TA.Model;
using WorkWave.TA.TestEngine;
using WorkWave.PestPac.TA.SharedData;
namespace WorkWave.PestPac.TA.Steps
{
    [Binding]
    public class SettingsSteps : TestSteps
    {
        private PestPacData pestPacData;
        SettingsPage settingpage = new SettingsPage();
        CompanySetupPage companysetuppage = new CompanySetupPage();
        RolesandPermissionSetUpPage rolespermissionsetupuppage = new RolesandPermissionSetUpPage();
        UserandAccessPage useraccesspage = new UserandAccessPage();
        SalesFunnelsPage salesfunnelpage = new SalesFunnelsPage();
        SalesTeamsPage salesteamspage = new SalesTeamsPage();

        public object RandomStringTransformer { get; private set; }

        public SettingsSteps(PestPacData pestPacData)
        {
            this.pestPacData = pestPacData;

            SettingsPage settingpage = new SettingsPage();


        }

        [When(@"I click on Settings Gear Icon")]
        public void WhenIClickOnSettingsGearIcon()
        {
            settingpage.ClickonSettingsGearIcon();
        }

        [Then(@"Settings page should be displayed")]
        public void ThenSettingsPageShouldBeDisplayed()
        {
            Assert.True(settingpage.IsLoaded(), "Failed to verify the settings page loaded after click on Settings Gear icon");
        }

        [Then(@"I click on Company Setup link")]
        public void ThenIClickOnCompanySetupLink()
        {
            settingpage.ClickonCompanySetUpLink();
        }

        [Then(@"Company Setup page should be displayed")]
        public void ThenCompanySetupPageShouldBeDisplayed()
        {
            Assert.True(companysetuppage.IsLoaded(), "Failed to verify the Company setup page loaded after click on Company setup link");
        }

        [Then(@"I click on Roles and Permissions link")]
        public void ThenIClickOnRolesAndPermissionsLink()
        {
            settingpage.ClickonRolesAndPermissionLink();
        }

        [Then(@"Roles and Permissions page should be displayed")]
        public void ThenRolesAndPermissionsPageShouldBeDisplayed()
        {
            Assert.True(rolespermissionsetupuppage.IsLoaded(), "Failed to verify the Roles and Permissions page loaded after click on Roles and Permissions link");
        }

        [Then(@"I click on User and Access link")]
        public void ThenIClickOnUserAndAccessLink()
        {
            settingpage.ClickonUsersAndAccessLink();
        }

        [Then(@"User and Access page should be displayed")]
        public void ThenUserAndAccessPageShouldBeDisplayed()
        {
            Assert.True(useraccesspage.IsLoaded(), "Failed to verify the Users and Access page loaded after click on Users and Access link");
        }

        [Then(@"I click on Sales Funnels link")]
        public void ThenIClickOnSalesFunnelsLink()
        {
            settingpage.ClickonSalesFunnelsLink();
        }

        [Then(@"Sales Funnels page should be displayed")]
        public void ThenSalesFunnelsPageShouldBeDisplayed()
        {
            Assert.True(salesfunnelpage.IsLoaded(), "Failed to verify the Users and Access page loaded after click on Users and Access link");
        }

        [Then(@"I click on Sales Teams link")]
        public void ThenIClickOnSalesTeamsLink()
        {
            settingpage.ClickonSalesTeamsLink();
        }

        [Then(@"Sales Teams page should be displayed")]
        public void ThenSalesTeamsPageShouldBeDisplayed()
        {
            Assert.True(salesteamspage.IsLoaded(), "Failed to verify the Users and Access page loaded after click on Users and Access link");
        }


        //Add the Role

        [Then(@"I Click on Add Role button")]
        public void ThenIClickOnAddRoleButton()
        {
            settingpage.ClickOnAddRoleMainButton();
        }

        [Then(@"I enter the role name (.*)")]
        public void ThenIEnterTheRoleNameSalesManager(String name)
        {
            settingpage.EnterRoleName(name);
            settingpage.ClickOnAllLink();
        }

        [When(@"I click on Add Role button in slider")]
        public void WhenIClickOnAddRoleButtonInSlider()
        {
            settingpage.ClickOnAddRoleSaveButton();
        }


        //[Then(@"Validation message should be displayed")]
        //public void ThenValidationMessageShouldBeDisplayed()  
        //{

        //}

        [When(@"i click on three dots icon")]
        public void WhenIClickOnThreeDotsIcon()
        {
            settingpage.ClickOnThreeDots();
        }

        [When(@"I click on Delete option")]
        public void WhenIClickOnDeleteOption()
        {
            settingpage.ClickOnDeleteOption();
        }


        [When(@"I click on Delete button in popup")]
        public void WhenIClickOnDeleteButtonInPopup()
        {
            settingpage.ClickOnDeletebutton();
        }


        //[Then(@"Validation mesage hould be displayed")]
        //public void ThenValidationMesageHouldBeDisplayed()
        //{

        //}

        //Adding Sales Funel

        [Then(@"I Click on Add Sales Funnel button")]
        public void ThenIClickOnAddSalesFunnelButton()
        {
            settingpage.ClickAddSalesFunnelButton();
        }


        [Then(@"I enter the sales funnel name (.*)")]
        public void ThenIEnterTheSalesFunnelNameTestingFunnel(String salesfunnelname)
        {
            settingpage.EnterSalesFunnelName(salesfunnelname);
        }



        [When(@"I click on Save button in add sales funnel slider")]
        public void WhenIClickOnSaveButtonInAddSalesFunnelSlider()
        {
            settingpage.ClickOnFunnelSaveButton();
        }

        [When(@"I click on three dots icon for ales funnel")]
        public void WhenIClickOnThreeDotsIconForAlesFunnel()
        {
            settingpage.ClickOnThreeDotsIconforSalesFunnel();
        }

        [When(@"I click on Delete option for sales funnel")]
        public void WhenIClickOnDeleteOptionForSalesFunnel()
        {
            settingpage.ClickOnDeleteOptionforSalesFunel();
        }

        //Adding UnMapped user 

        [Then(@"I Click on Add UnMapped User button")]
        public void ThenIClickOnAddUnMappedUserButton()
        {
            settingpage.ClickAddUnmappedButton();
        }

        [Then(@"I enter the user details (.*) (.*) (.*)")]
        public void ThenIEnterTheUserDetailsTestTestGmail_Com(string firstname, string lastname, string email)
        {
            settingpage.EnterUserDetails(firstname, lastname, email);
        }


        [Then(@"I select the User Role (.*)")]
        public void ThenISelectTheUserRoleAutomationTestingRole(string rolename)
        {

            settingpage.SelectRoleFromTheDropDown();
            //settingpage.SelectRoleDropdown(rolename);
        }

        [Then(@"I click on Add Sales Team option")]
        public void ThenIClickOnAddSalesTeamOption()
        {
            settingpage.ClickAddSalesTeamoption();
        }


        [Then(@"I select the Sales Team (.*)")]
        public void ThenISelectTheSalesTeam(string salesteamname)
        {
            settingpage.SelectSalesTeamFromTheDropDown();
        }


        [Then(@"I select the team position")]
        public void ThenISelectTheTeamPosition()
        {
            settingpage.ClickSalesTeamPosition();
        }


        [When(@"I click on Save button in add unmapped user slider")]
        public void WhenIClickOnSaveButtonInAddUnmappedUserSlider()
        {
            settingpage.ClickSaveButtonInUserSlider();
        }

        //[Then(@"Validation message should be displayed")]
        //public void ThenValidationMessageShouldBeDisplayed(string message)
        //{


        //}

        [Then(@"Validation message should be displayed (.*)")]
        public void ThenValidationMessageShouldBeDisplayedUserCreated_WelcomeEmailSent_(string message)
        {
            settingpage.VerifyConfirmMsg(message);
        }



        [Then(@"I click on three dots icon for added user")]
        public void ThenIClickOnThreeDotsIconForAddedUser()
        {
            settingpage.ClickOnThreeDotsIconforAddedUser();
        }


        [Then(@"I click on Delete option for unmapped user")]
        public void ThenIClickOnDeleteOptionForUnmappedUser()
        {
            settingpage.ClickOnDeleteOptionforUnMappedUser();
        }

        [When(@"I click on Delete button in unmappeduser popup")]
        public void WhenIClickOnDeleteButtonInUnmappeduserPopup()
        {
            settingpage.ClickDeleteButtonInPopup();

        }

        [Then(@"User deleted confirmation mesage should be displayed (.*)")]
        public void ThenUserDeletedConfirmationMesageShouldBeDisplayedUserDeleted(string message)
        {
            settingpage.VerifyDeleteConfirmMsg(message);
        }


        //Add and Delete Sales Team

        [Then(@"I click on Add Sales Team button")]
        public void ThenIClickOnAddSalesTeamButton()
        {
            settingpage.ClickAddSalesTeamButton();
        }


        [Then(@"I enter the Sales Team Name (.*)")]
        public void ThenIEnterTheSalesTeamNameAutouserGmail_Com(string salesteamname)
        {
            settingpage.EnterSalesTeamName(salesteamname);
        }

        [Then(@"I select the Branch name (.*)")]
        public void ThenISelectTheBranchNameAutomationTestingRole(string p0)
        {
            settingpage.SelectBranch();
        }

        [When(@"I click on Save button in add sales team slider")]
        public void WhenIClickOnSaveButtonInAddSalesTeamSlider()
        {
            settingpage.ClickSaveButtonInUserSlider();
        }

        [Then(@"Sales team created validation message should be displayed (.*)")]
        public void ThenSalesTeamCreatedValidationMessageShouldBeDisplayed(string message)
        {
            settingpage.VerifySalesTeamCreatedConfirmMsg(message);
        }

        [Then(@"I click on three dots icon for added salesteam")]
        public void ThenIClickOnThreeDotsIconForAddedSalesteam()
        {
            settingpage.ClickOnThreeDotsIconforAddedSalesTeam();
        }

        [When(@"I click on Delete option for added salesteam")]
        public void WhenIClickOnDeleteOptionForAddedSalesteam()
        {
            settingpage.ClickOnDeleteOptionforSalesTeam();
        }

        [Then(@"SalesTeam deleted confirmation mesage should be displayed (.*)")]
        public void ThenSalesTeamDeletedConfirmationMesageShouldBeDisplayed(string message)
        {
            settingpage.VerifySalesTeamDeleteConfirmMsg(message);
        }

        [Then(@"I click on Add Position button")]
        public void ThenIClickOnAddPositionButton()
        {

        }

        [Then(@"I enter the position title SalesManager")]
        public void ThenIEnterThePositionTitleSalesManager()
        {

        }

        [When(@"I click on save button")]
        public void WhenIClickOnSaveButton()
        {

        }

        [Then(@"Sales team position created validation message should be displayed Sales team position created")]
        public void ThenSalesTeamPositionCreatedValidationMessageShouldBeDisplayedSalesTeamPositionCreated()
        {

        }




    }
}