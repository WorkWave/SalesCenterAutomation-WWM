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

        [When(@"Click on Settings Gear Icon")]
        public void WhenClickOnSettingsGearIcon()
        {
            settingpage.ClickonSettingsGearIcon();
        }

        [Then(@"Settings page should be displayed")]
        public void ThenSettingsPageShouldBeDisplayed()
        {
            Assert.True(settingpage.IsLoaded(), "Failed to verify the settings page loaded after click on Settings Gear icon");
        }

        [Then(@"Click on Company Setup link")]
        public void ThenClickOnCompanySetupLink()
        {
            settingpage.ClickonCompanySetUpLink();
        }

        [Then(@"Company Setup page should be displayed")]
        public void ThenCompanySetupPageShouldBeDisplayed()
        {
            Assert.True(companysetuppage.IsLoaded(), "Failed to verify the Company setup page loaded after click on Company setup link");
        }

        [Then(@"Click on Roles and Permissions link")]
        public void ThenClickOnRolesAndPermissionsLink()
        {
            settingpage.ClickonRolesAndPermissionLink();
        }

        [Then(@"Roles and Permissions page should be displayed")]
        public void ThenRolesAndPermissionsPageShouldBeDisplayed()
        {
            Assert.True(rolespermissionsetupuppage.IsLoaded(), "Failed to verify the Roles and Permissions page loaded after click on Roles and Permissions link");
        }

        [Then(@"Click on User and Access link")]
        public void ThenClickOnUserAndAccessLink()
        {
            settingpage.ClickonUsersAndAccessLink();
        }

        [Then(@"User and Access page should be displayed")]
        public void ThenUserAndAccessPageShouldBeDisplayed()
        {
            Assert.True(useraccesspage.IsLoaded(), "Failed to verify the Users and Access page loaded after click on Users and Access link");
        }

        [Then(@"Click on Sales Funnels link")]
        public void ThenClickOnSalesFunnelsLink()
        {
            settingpage.ClickonSalesFunnelsLink();
        }

        [Then(@"Sales Funnels page should be displayed")]
        public void ThenSalesFunnelsPageShouldBeDisplayed()
        {
            Assert.True(salesfunnelpage.IsLoaded(), "Failed to verify the Users and Access page loaded after click on Users and Access link");
        }

        [Then(@"Click on Sales Teams link")]
        public void ThenClickOnSalesTeamsLink()
        {
            settingpage.ClickonSalesTeamsLink();
        }

        [Then(@"Sales Teams page should be displayed")]
        public void ThenSalesTeamsPageShouldBeDisplayed()
        {
            Assert.True(salesteamspage.IsLoaded(), "Failed to verify the Users and Access page loaded after click on Users and Access link");
        }


        //Add the Role

        [Then(@"Click on Add Role button")]
        public void ThenClickOnAddRoleButton()
        {
            settingpage.ClickOnAddRoleMainButton();
        }

        [Then(@"Enter the role name (.*)")]
        public void ThenEnterTheRoleNameSalesManager(String name)
        {
            settingpage.EnterRoleName(name);
            settingpage.ClickOnAllLink();
        }

        [When(@"Click on Add Role button in slider")]
        public void WhenClickOnAddRoleButtonInSlider()
        {
            settingpage.ClickOnAddRoleSaveButton();
        }


        //[Then(@"Validation message should be displayed")]
        //public void ThenValidationMessageShouldBeDisplayed()  
        //{

        //}

        [When(@"Delete the role")]
        public void WhenDeleteTheRole()
        {
            settingpage.ClickOnThreeDots();
            settingpage.ClickOnDeleteOption();
            settingpage.ClickOnDeletebutton();
        }

        //[Then(@"Validation mesage hould be displayed")]
        //public void ThenValidationMesageHouldBeDisplayed()
        //{

        //}

        //Adding Sales Funel

        [Then(@"Click on Add Sales Funnel button")]
        public void ThenClickOnAddSalesFunnelButton()
        {
            settingpage.ClickAddSalesFunnelButton();
        }

        [Then(@"Enter the sales funnel name (.*)")]
        public void ThenEnterTheSalesFunnelNameTestingFunnel(String salesfunnelname)
        {
            settingpage.EnterSalesFunnelName(salesfunnelname);
        }

        [When(@"Click on Save button in add sales funnel slider")]
        public void WhenClickOnSaveButtonInAddSalesFunnelSlider()
        {
            settingpage.ClickOnFunnelSaveButton();
        }

        [When(@"Click on three dots icon for ales funnel")]
        public void WhenClickOnThreeDotsIconForAlesFunnel()
        {
            settingpage.ClickOnThreeDotsIconforSalesFunnel();
        }

        [When(@"Click on Delete option for sales funnel")]
        public void WhenClickOnDeleteOptionForSalesFunnel()
        {
            settingpage.ClickOnDeleteOptionforSalesFunel();
        }

        //Adding UnMapped user 

        [Then(@"Click on Add UnMapped User button")]
        public void ThenClickOnAddUnMappedUserButton()
        {
            settingpage.ClickAddUnmappedButton();
        }

        [Then(@"Enter the user details (.*) (.*) (.*)")]
        public void ThenEnterTheUserDetailsTestTestGmail_Com(string firstname, string lastname, string email)
        {
            settingpage.EnterUserDetails(firstname, lastname, email);
        }

        [Then(@"Select the User Role (.*)")]
        public void ThenSelectTheUserRoleAutomationTestingRole(string rolename)
        {
            settingpage.SelectRoleFromTheDropDown();         
        }

        [Then(@"Click on Add Sales Team option")]
        public void ThenClickOnAddSalesTeamOption()
        {
            settingpage.ClickAddSalesTeamoption();
        }


        [Then(@"Select the Sales Team (.*)")]
        public void ThenSSSelectTheSalesTeam(string salesteamname)
        {
            settingpage.SelectSalesTeamFromTheDropDown();
        }


        [Then(@"Select the team position")]
        public void ThenSelectTheTeamPosition()
        {
            settingpage.ClickSalesTeamPosition();
        }

        [When(@"Delete the unmapped user")]
        public void WhenDeleteTheUnmappedUser()
        {
            settingpage.ClickOnThreeDotsIconforAddedUser();
            settingpage.ClickOnDeleteOptionforUnMappedUser();
            settingpage.ClickDeleteButtonInPopup();
        }


        [Then(@"Validation message should be displayed (.*)")]
        public void ThenValidationMessageShouldBeDisplayedUserCreated_WelcomeEmailSent_(string message)
        {
            settingpage.VerifyConfirmMsg(message);
        }

        [Then(@"Click on three dots icon for added user")]
        public void ThenClickOnThreeDotsIconForAddedUser()
        {
            settingpage.ClickOnThreeDotsIconforAddedUser();
        }
       
        [Then(@"User deleted confirmation mesage should be displayed (.*)")]
        public void ThenUserDeletedConfirmationMesageShouldBeDisplayedUserDeleted(string message)
        {
            settingpage.VerifyDeleteConfirmMsg(message);
        }


        //Add and Delete Sales Team

        [Then(@"Click on Add Sales Team button")]
        public void ThenClickOnAddSalesTeamButton()
        {
            settingpage.ClickAddSalesTeamButton();
        }

        [Then(@"Enter the Sales Team Name (.*)")]
        public void ThenEnterTheSalesTeamNameAutouserGmail_Com(string salesteamname)
        {
            settingpage.EnterSalesTeamName(salesteamname);
        }

        [Then(@"Select the Branch name (.*)")]
        public void ThenSelectTheBranchNameAutomationTestingRole(string p0)
        {
            settingpage.SelectBranch();
        }

        [When(@"Click on Save button in add sales team slider")]
        public void WhenClickOnSaveButtonInAddSalesTeamSlider()
        {
            settingpage.ClickSaveButtonInUserSlider();
        }

        [Then(@"Sales team created validation message should be displayed (.*)")]
        public void ThenSalesTeamCreatedValidationMessageShouldBeDisplayed(string message)
        {
            settingpage.VerifySalesTeamCreatedConfirmMsg(message);
        }

        [When(@"Delete the sales team")]
        public void WhenDeleteTheSalesTeam()
        {
            settingpage.ClickOnThreeDotsIconforAddedSalesTeam();
            settingpage.ClickOnDeleteOptionforSalesTeam();
        }

        [When(@"Click on Delete option for added salesteam")]
        public void WhenClickOnDeleteOptionForAddedSalesteam()
        {
            settingpage.ClickOnDeleteOptionforSalesTeam();
        }

        [Then(@"SalesTeam deleted confirmation mesage should be displayed (.*)")]
        public void ThenSalesTeamDeletedConfirmationMesageShouldBeDisplayed(string message)
        {
            settingpage.VerifySalesTeamDeleteConfirmMsg(message);
        }

        [Then(@"Click on Add Position button")]
        public void ThenIClickOnAddPositionButton()
        {
            settingpage.ClickOnAddPositionButton();
        }

        [Then(@"Enter the position title (.*)")]
        public void ThenEnterThePositionTitleSalesManager(string titlename)
        {
            settingpage.EnterPositionTitle(titlename);
        }

        [Then(@"Sales team position created validation message should be displayed (.*)")]
        public void ThenSalesTeamPositionCreatedValidationMessageShouldBeDisplayedSalesTeamPositionCreated(string positioncreatedmessage)
        {
            settingpage.VerifySalesTeamCreatedConfirmMsg(positioncreatedmessage);
        }

    }
}