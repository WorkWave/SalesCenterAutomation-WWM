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
using System.Text.RegularExpressions;

namespace WorkWave.PestPac.TA.Model
{
    public class LeadDetailPage : IWebPage
    {
        #region PageFactory

        [FindsBy(How = How.XPath, Using = "//p[text()='Leads']")]
        private IWebElement PageHeader { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='button']//img[1]/.")]
        private IWebElement ClickSalesCenter { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Leads'])[2]/..")]
        private IWebElement ClickLeadLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='addBtn']")]
        private IWebElement ClickPlusButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='addLeadBtn']")]
        private IWebElement ClickAddLeadButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Add Lead']")]
        private IWebElement leadPage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "firstName")]
        private IWebElement FirstNamefield { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement LastNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "company")]
        private IWebElement CompanyNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "emailAddresses[0].emailAddress")]
        private IWebElement EmailNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "phoneNumber")]
        private IWebElement PhoneNamefield { get { return PageFactory.Load(this); } }
      

       [FindsBy(How = How.XPath, Using = "//input[@name='salesTeamId']/..")]
        private IWebElement ClickSalesTeamField { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//ul//li[text()='Secondary south sales Team']")]
        private IWebElement SelectSalesTeam { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//input[@name='assigneeId']/..")]
        private IWebElement ClickOwnerAssigneeField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//ul//li[text()='Unassigned']")]
        private IWebElement SelectOwnerAssigneeName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='salesFunnelId']/..")]
        private IWebElement ClickFunnelField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//ul//li[contains(text(),'Required Contract & Payment')]")]
        private IWebElement SelectFunnelName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement ClickSaveButton { get { return PageFactory.Load(this); } }

       [FindsBy(How = How.XPath, Using = "//div[@role='alert']")]
        private IWebElement LeadcreatedConfirm_Txt { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "(//div[@data-test-id='searchInputField']//div)[1]/..")]
        private IWebElement ClickSearchIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name, email, phone, address, location']")]
        private IWebElement EnterLeadname { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='autocompany2']/../../../preceding-sibling::div/descendant::button[2]")]
        private IWebElement ClickThreeDotsforLead { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//span[text()='Delete']")]
        private IWebElement ClickDeleteLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='okBtn'])[1]")]
        private IWebElement ClickDeletebutton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'ANT')]")]
        private IWebElement ServcieAdded { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "iframe[src*='test-forms.workwave']")]
        private IWebElement IframeCompleteForm { get { return PageFactory.Load(this); } }


        #region Create opportunity

        [FindsBy(How = How.XPath, Using = "(//div[contains(@data-test-id,'cardFooter')])[1]")]
        private IWebElement ClickServiceExapndIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[contains(@data-test-id,'serviceBtn')]")]
        private IWebElement ClickServiceButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='services']/..")]
        private IWebElement ClickServiceField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='ANT - Ant Treatments']")]
        private IWebElement SelectServicename { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='ANT']")]
        private IWebElement servicePage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Close Services and Products')]")]
        private IWebElement CloseServicesButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='autocompany03']/../../../preceding-sibling::div/descendant::div/div[2]/child::button[1])[1]")]
        private IWebElement ClickConvertOpportunityButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Add Service'])[2]")]
        private IWebElement ClickServiceButtonInSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Add Service']")]
        private IWebElement ClickAddServiceButtonInCReateNewOpportunitySlider { get { return PageFactory.Load(this); } }
        

       [FindsBy(How = How.XPath, Using = "//div[text()='Services or Products Added']")]
        private IWebElement ConvertLeadPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='opportunityStageId']/..")]
        private IWebElement StageField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//ul//li[text()='Stage1']")]
        private IWebElement SelectStageName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='ownerId']/..")]
        private IWebElement ClickOwnerField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//ul//li[text()='Unassigned']")]
        private IWebElement SelectOwnerName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "mui-component-select-salesFunnelId")]
        private IWebElement FunnelField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//ul//li[contains(text(),'Test Sales funnel')]")]
        private IWebElement FunnelName { get { return PageFactory.Load(this); } }

        #endregion Create opportunity

        #region Create oportunity directly

        [FindsBy(How = How.XPath, Using = "//div[text()='Create Opportunity']/..")]
        private IWebElement ClickCreateOpportunityButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        private IWebElement EnterTheLeadname { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Create Opportunity'])[1]")]
        private IWebElement ClickCreateOpportunityButtonInOppPage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='Choose one or more service locations related to this Bill-to']/../preceding-sibling::div")]
        private IWebElement CreateOpportunityPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Create Opportunity']")]
        private IWebElement AddOpportunityPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Add Service or Product']/.")]
        private IWebElement ClickAddAdditionalServiceOrProductButton { get { return PageFactory.Load(this); } }
      
        #endregion create opportunity directly


        #region Delete Opportunity

     [FindsBy(How = How.XPath, Using = "(//p[text()='Opportunities'])[2]")]
        private IWebElement ClickOpportunitiesLink { get { return PageFactory.Load(this); } }




        #endregion Delete Opportunity

        #region Add contract to the lead

        [FindsBy(How = How.XPath, Using = "//button[contains(@data-test-id,'agreementBtn')]/.")]
        private IWebElement ClickSendContractButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Create Contract']")]
        private IWebElement CreateContractPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Select Contract Template')]/..")]
        private IWebElement ClickTemplateField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Residential Service Form']")]
        private IWebElement SelectContractTemplate { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Launch Form to Complete']")]
        private IWebElement ClickLaunchFormToCompleteButton { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Proceed')]")]
        private IWebElement ClickProceedButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Complete Form']")]
        private IWebElement ClickCompleteFormButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='This form has been completed.']")]
        private IWebElement ContractIsAdded { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'mui')]")]
        private IWebElement ReopenLeadStatusField { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[text()='This form has been completed.']")]
        private IWebElement LeadStatusField { get { return PageFactory.Load(this); } }


        #endregion Add contract to the lead

        #region Reopen disqualified leads


        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='filterBtn']/.")]
        private IWebElement ClickOnFilterButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='Lead Status']")]
        private IWebElement LeadStatusExpandIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Disqualified']")]
        private IWebElement LeadStatusName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Apply']")]
        private IWebElement ClickApplyButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//*[@data-testid='MoreVertIcon'])[1]")]
        private IWebElement ClickThreeDotsIconforDisqualified { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Re-Open']")]
        private IWebElement ReopenoptionforDisqualifiedlead { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Qualify']")]
        private IWebElement ReopenLeadStatusName { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[text()='Open']")]
        private IWebElement LeadStatusOpenField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Reset Filters to Default']")]
        private IWebElement ClickClearFilterButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Disqualified']/..")]
        private IWebElement DisqualifiedLeadDisplayed { get { return PageFactory.Load(this); } }

        #endregion Reopen disqualified leads


        #region Attach a lead to location

        [FindsBy(How = How.XPath, Using = "(//span[text()='Bill-to / Locations']/..)[1]")]
        private IWebElement ClickBillToExpandButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//a[text()='Match / Create New']")]
        private IWebElement ClickMatchOrCreateLocationLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Match / Create New Location']")]
        private IWebElement MatchorCreateNewLocationSliderDisplayed { get { return PageFactory.Load(this); } }

      
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Match To Existing Location')]")]
        private IWebElement ClickMatchToExistingLocationButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Match Bill-to'])[1]")]
        private IWebElement ClickExistingLocationRadioButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Save'])[2]")]
        private IWebElement ClickSaveButtonInBilltoMatchingSlider { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[text()='Select Service Location']/..")]
        private IWebElement ClickServiceLocationField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'3600 STATE ROUTE 66')]")]
        private IWebElement SelectServiceLocationName { get { return PageFactory.Load(this); } }

        #endregion Attach a lead to location


        #region Update service

        [FindsBy(How = How.XPath, Using = "//div[text()='ANT']/../../descendant::button")]
        private IWebElement ClickThreeDotsIconInSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='EXTERIOR LIGHT']")]
        private IWebElement SelectOtherServicename { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Update Service']")]
        private IWebElement ClickUpdateServiceButton { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[@data-test-id='editBtn']")]
        private IWebElement ClickEditOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Services Added')]")]
        private IWebElement ClickViewServicesAddedLink { get { return PageFactory.Load(this); } }

       

       







        #endregion Update service


        #region Create new location in PP

        [FindsBy(How = How.XPath, Using = "//button[text()='Create New Location']")]
        private IWebElement ClickCreatenewLocationTab { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Create New Location']")]
        private IWebElement CreateNewLocationPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='editCardFooterBtn'])[1]")]
        private IWebElement ClickBillToEditButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "address1")]
        private IWebElement AddressNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "city")]
        private IWebElement CityNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "state")]
        private IWebElement StateNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "postalCode")]
        private IWebElement PostalcodeNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Update Bill-To Location']")]
        private IWebElement UpdateLocationSliderDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='editCardFooterBtn'])[2]")]
        private IWebElement ClickServiceLocationEditButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Save'])[2]")]
        private IWebElement ClickSaveButtonInUpdateLocationSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='A Service Location has been added successfully.']")]
        private IWebElement ServiceLocationValidationConfirm_Txt { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[text()='Locations Created Successfully']")]
        private IWebElement NewLocationValidationConfirm_Txt { get { return PageFactory.Load(this); } }

        #endregion Create new location in PP

        #region Duplicate alerts

        [FindsBy(How = How.XPath, Using = "//span[@class='MuiIconButton-label']//input/../../../..")]
        private IWebElement ToggleButtonOn { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Duplicate Alert')]")]
        private IWebElement DuplicateAlertCountDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Duplicate Alert')]")]
        private IWebElement ClickDuplicateAlertLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Duplicate Alert']")]
        private IWebElement DuplicateAlertPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Close Duplicate Alert')]")]
        private IWebElement ClickCloseDuplicateAlertButton { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "(//span[text()='Results']/..)[1]")]
        private IWebElement SameDuplicateAlertCountIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//th[text()='Record Name']")]
        private IWebElement RecordNameCoulmIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//th[text()='Address']")]
        private IWebElement AddressColumIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//th[text()='Company Name']")]
        private IWebElement CompanyNameColumIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//th[text()='Email']")]
        private IWebElement EmailColumIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//th[text()='Phone']")]
        private IWebElement PhoneColumIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//th[text()='Type']")]
        private IWebElement TypeColumIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//th[text()='Name']")]
        private IWebElement NameColumIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//th[text()='Branch']")]
        private IWebElement BranchColumIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = " //button[contains(text(),'PestPac Locations')]")]
        private IWebElement ClickPestPacLocationTab { get { return PageFactory.Load(this); } }
       

        #endregion Duplicate alerts

        #region Invalid card info

       [FindsBy(How = How.XPath, Using = "//span[text()=': INVALID CARD INFO']")]
        private IWebElement InvalidCardErrorMessage_Txt { get { return PageFactory.Load(this); } }


        #endregion Invalid card info

        #region verify captre card button

        [FindsBy(How = How.XPath, Using = "//button[contains(@data-test-id,'paymentBtn')]")]
        private IWebElement MouseHoverCaptureCardButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='tooltip']//div[1]")]
        private IWebElement CatureCardButtonWarningToastmessage { get { return PageFactory.Load(this); } }


        #endregion verify captre card button

        #region Disqualified the lead

        [FindsBy(How = How.XPath, Using = "(//div[@role='button'])[2]")]
        private IWebElement ClickLeadStatusField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Disqualified']")]
        private IWebElement DisqualifiedOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//h2[text()='Disqualified']")]
        private IWebElement DisqualifiedPopupIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Not Interested']")]
        private IWebElement NotInterestedRadioButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='SAVE']")]
        private IWebElement SaveButtonInDisqualifiedPopup { get { return PageFactory.Load(this); } }


        #endregion Disqualified the lead

        #region Adding a service to a lead

        [FindsBy(How = How.XPath, Using = "//p[text()='Lead']")]
        private IWebElement DetailsPageIsDisplayed { get { return PageFactory.Load(this); } }



        #endregion Adding a service to a lead

        #region Remove sc contacts for leads

        [FindsBy(How = How.XPath, Using = "//h2[text()='Remove Contact?']/../descendant::button[2]")]
        private IWebElement ClickRemoveButtonInPopupForLeads { get { return PageFactory.Load(this); } }


        #endregion Remove sc contacts for leads

        #region Unbale to convert to lead without service

        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'MuiOutlinedInput-root MuiInputBase-root')]/following-sibling::span)[1]")]
        private IWebElement MouseHoverConverttoOpportunityButton { get { return PageFactory.Load(this); } }


        #endregion Unbale to convert to lead without service

        #region Update lead details

        [FindsBy(How = How.XPath, Using = "//p[text()='Lead']/following-sibling::div/child::div")]
        private IWebElement ClickLeadPencilIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "firstName")]
        private IWebElement UpdateFirstName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement UpdateLastName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//b[text()='Rename this Lead']")]
        private IWebElement RenameThisLeadPopupDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'James Smith')]")]
        private IWebElement UpdatedLeadDetails { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Bill-to'])[2]/../child::button")]
        private IWebElement ClickThreeDotsIcnForBillToLocation { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Update Bill-To Location']")]
        private IWebElement UpdateBillToLocationSliderIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='South Branch']")]
        private IWebElement SelectBranchField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Main Branch']")]
        private IWebElement SelectBranchName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'MuiOutlinedInput-root MuiInputBase-root')]//div)[3]")]
        private IWebElement SelectLocationTypeField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='HOSPITAL- Hospital']")]
        private IWebElement SelectLocationTypeName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//div[@variant='outlined']//div)[3]")]
        private IWebElement SelectDivisonField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='CONSTRUCT- Construction']")]
        private IWebElement SelectDivisonName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='200 street san, chester, PA 93013-373'])[2]")]
        private IWebElement BillToAddressUpdated { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Bill-to'])[2]/../following-sibling::p")]
        private IWebElement BillToScroll { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Bill-to'])[2]/../following-sibling::p")]
        private IWebElement ClickViewMoreInformationLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Service Location']/../child::button")]
        private IWebElement ClickThreeDotsIcnForServiceLocation { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Update Service Location']")]
        private IWebElement UpdateServiceLocationSliderIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='View '])[2]")]
        private IWebElement ClickViewMoreInformationLinkForServcieLocation { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Edit']")]
        private IWebElement ClickEditLinkForAdditionalInformationSection { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='South Branch Sales Team']")]
        private IWebElement SelectSalesTeamValue { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Chad Kochel']")]
        private IWebElement SelectOwnerValue { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Test Sales funnel']")]
        private IWebElement SelectFunnelValue { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//label[text()='Target Pests']/following::input)[1]")]
        private IWebElement ClicktargetPestField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='CLOVR MITE']")]
        private IWebElement SelectPestValue { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//input[@name='campaignId']/..")]
        private IWebElement ClickCampaignField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='CUSTOMER']")]
        private IWebElement SelectCampaignValue { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//input[@name='leadSourceId']/..")]
        private IWebElement ClickleadSourceField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='RECOMMEND']")]
        private IWebElement SelectLeadSourceValue { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'Toastify__toast-icon Toastify--animate-icon')]/following-sibling::div[1]")]
        private IWebElement BillToLocationUpdatedValidationMessage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='salesFunnelStageId']/..")]
        private IWebElement ClickleadStatusField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Qualify']")]
        private IWebElement SelectLeadStatusValue { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='South Branch Sales Team']")]
        private IWebElement UpdatedSalesTeamName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Test Sales funnel']")]
        private IWebElement UpdatedSalesFunnelName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='CUSTOMER']")]
        private IWebElement UpdatedCampaignName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Chad Kochel'])[1]")]
        private IWebElement UpdatedOwnerName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='RECOMMEND']")]
        private IWebElement UpdatedLeadSourceName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='CLOVR MITE']")]
        private IWebElement UpdatedTargetPestsName { get { return PageFactory.Load(this); } }


        #endregion Update lead details

        #region Update service details

        [FindsBy(How = How.XPath, Using = "//p[text()='View Details']")]
        private IWebElement ClickViewDetailsExpandLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Initial Price']/following-sibling::span")]
        private IWebElement InitialPriceIsDisplayed { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.Name, Using = "initialPrice")]
        private IWebElement InitialPriceIsEntered { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//h2[text()='Delete Service']/../child::div/following-sibling::div/child::button[2]")]
        private IWebElement ClickDeleteButtonInDeleteServicePopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='EXTERIOR LIGHT']/../../descendant::button")]
        private IWebElement ClickThreeDotsIconInUpdatedService { get { return PageFactory.Load(this); } }

        #endregion Update service details

        #region Add service or product slideout

        [FindsBy(How = How.Name, Using = "externalId")]
        private IWebElement AddServiceOrProductIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Upsell']/..")]
        private IWebElement UpsellToggleButtonIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Add Pricing']")]
        private IWebElement PricingLabelIsDisplayed { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.Name, Using = "initialPrice")]
        private IWebElement InitialButtonIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "initialDiscountAmount")]
        private IWebElement DiscountButtonIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "//span[text()='Include Sales Tax']/.")]
        private IWebElement ToggleButtonIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "//div[text()='Service or Product Total Summary']")]
        private IWebElement ServiceProductSummaryIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "(//button[text()='Add Service'])[2]")]
        private IWebElement AddServiceButtonIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "initialDiscountAmount")]
        private IWebElement DollarPercentageIsEntered { get { return PageFactory.Load(this); } }


        

        #endregion Add service or product slideout
        #endregion PageFactory

        private readonly string PageHeaderText = "Leads";


        public bool IsLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PageHeader)))
            {
                if (PageHeader.Text.TrimStart().StartsWith(PageHeaderText))
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

        #region Selenium
    
        public void ClickSalesCenterMenu()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesCenter)))
                {
                    ClickSalesCenter.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Send center menu  is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Send center menu  is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Send contract button is not clicked");
            }
        }

        public void ClickonLeadLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickLeadLink)))
                {
                    ClickLeadLink.Click();
                    SUT.Log.DebugFormat("Lead link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead link is not clicked");
            }
        }


        public void ClickonPlusButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickPlusButton)))
                {
                    ClickPlusButton.Click();
                    SUT.Log.DebugFormat("Plus icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Plus icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Plus icon is not clicked");
            }
        }
        public void ClickonAddLeadButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddLeadButton)))
                {
                    ClickAddLeadButton.Click();
                    SUT.Log.DebugFormat("Add lead button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add lead button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add lead button is not clicked");
            }
        }

        private readonly string LeadsPage = "Add Lead";
        

        public bool IsLeadPageLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => leadPage), TimeSpan.FromSeconds(10)))
            {
                if (leadPage.Text.TrimStart().StartsWith(LeadsPage))
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

        //Lead creation
        public void EnterLeadDetails(string firstname, string lastname, string company, string email)
        {
            FirstNamefield.SendKeys(firstname);
            Thread.Sleep(1000);
            LastNamefield.SendKeys(lastname);
            Thread.Sleep(1000);
            CompanyNamefield.SendKeys(company);
            Thread.Sleep(1000);
            EmailNamefield.SendKeys(email);
            Thread.Sleep(1000);          
        }
     
        public void SelectSalesTeamfromdropdown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickSalesTeamField)))
                {
                    ClickSalesTeamField.Click();                  
                    SelectSalesTeam.Click();
                    SUT.Log.DebugFormat("Sales team selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team is not selected from the dropdown");
            }

        }
        public void SelecttheOwnerAssigneeName()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickOwnerAssigneeField), TimeSpan.FromSeconds(10)))
                {
                    ClickOwnerAssigneeField.Click();
                    Thread.Sleep(1000);
                    SelectOwnerAssigneeName.Click();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Owner selected from the dropdown");
                }
                else
                {

                    SUT.Log.ErrorFormat("Owner is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Owner is not selected from the dropdown");
            }
        }

        public void SelecttheFunnelName()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickFunnelField), TimeSpan.FromSeconds(10)))
                {
                    SalesCenterUtility.ScrollToElement(ClickFunnelField);
                    ClickFunnelField.Click();
                    Thread.Sleep(1000);
                  //  SalesCenterUtility.ScrollToElement(SelectFunnelName);
                    SelectFunnelName.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Sales funnel selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales funnel  is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales funnel is not selected from the dropdown");
            }
        }

        public void ClickOnSaveButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickSaveButton)))
                {
                    ClickSaveButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Save button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Save button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Save button is not clicked ");
            }
        }

        public bool VerifyLeadCreatedConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadcreatedConfirm_Txt),TimeSpan.FromSeconds(5)))
            {
                SUT.Log.Debug("Validation message is dislayed");
                Assert.True(LeadcreatedConfirm_Txt.Text.Contains(message), "Validation message is not matching");
                return true;
            }
            else
            {
                SUT.Log.Debug("Validation message is not dislayed");
                return false;
            }
        }
        public void ClickOnSearchIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSearchIcon)))
                {
                    ClickSearchIcon.Click();
                    SUT.Log.DebugFormat("Search icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Search icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Search icon is not clicked ");
            }
        }

        public void EnterTheLeadName(string leadname)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => EnterLeadname)))
                {
                    EnterLeadname.SendKeys(leadname);
                    EnterLeadname.SendKeys(Keys.Enter);
                    Thread.Sleep(10000);
                    SUT.Log.DebugFormat("Lead name is entered");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead name is not entered {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead name is not entered ");
            }
        }

        public void ClickOnThreeDotsIconforAddedLead()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsforLead)))
                {
                    ClickThreeDotsforLead.Click();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Three dot icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Three dot icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Three dot icon is not clicked ");
            }

        }

        public void ClickOnDeleteLinkforLead()
        {
            try {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteLink)))
                {
                    ClickDeleteLink.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delete link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Delete link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Delete link is not clicked");
            }
        }
        public void ClickDeleteButtonInLeadPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeletebutton)))
                {
                    ClickDeletebutton.Click();
                    SUT.Log.DebugFormat("Delete button is clicked in popup");
                }
                else
                {
                    SUT.Log.ErrorFormat("Delete button is not clicked in popup {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Delete button is not clicked in popup");
            }
        }

        //Create opportunity
        public void ClickAddServiceExpandIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceExapndIcon)))
                {
                    ClickServiceExapndIcon.Click();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Service expand icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service expand icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service expand icon is not clicked");
            }
        }

        public void ClickAddServiceButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceButton)))
                {
                    SalesCenterUtility.ScrollToElement(ClickServiceButton);
                    ClickServiceButton.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Add service button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add service button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add service button is not clicked");
            }
        }

        public void SelectServiceFromDropDown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceField)))
                {
                    ClickServiceField.Click();
                    Thread.Sleep(3000);
                //    SalesCenterUtility.ScrollToElement(SelectServicename);
                    SelectServicename.Click();
                    SUT.Log.DebugFormat("Service selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service is not selected from the dropdown");
            }
        }

        public void IsServiceAdded()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ServcieAdded), TimeSpan.FromSeconds(10)))
                {
                    ServcieAdded.Displayed.ToString();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Service added");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service is not added {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service is not added");
            }
        }


        public void ClickCloseServicesAndProductButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CloseServicesButton)))
                {
                    Thread.Sleep(2000);
                    CloseServicesButton.Click();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Closeservice and product button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Closeservice and product button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Closeservice and product button is not clicked");
            }
        }
        public void ClickOnConvertOpportunityButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickConvertOpportunityButton)))
                {                  
                    ClickConvertOpportunityButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Closeservice and product button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Closeservice and product button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Closeservice and product button is not clicked");
            }
        }

        public void ClickAddServiceButtonInSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickServiceButtonInSlider)))
                {
                    ClickServiceButtonInSlider.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Add service button is clicked in the slider");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add service button is not clicked in the slider {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add service button is not clicked in the slider");
            }
        }

        public void ClickOnAddServiceButtonInCreateNewOpportunitySlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickAddServiceButtonInCReateNewOpportunitySlider)))
                {
                    ClickAddServiceButtonInCReateNewOpportunitySlider.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Add service button is clicked in the slider");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add service button is not clicked in the slider {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add service button is not clicked in the slider");
            }
        }

        public void IsConvertLeadPageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ConvertLeadPageIsDisplayed)))
                {
                    ConvertLeadPageIsDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Convert lead page is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Convert lead page is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Convert lead page is not diplayed");
            }
        }
        public void SelecttheStageFromDropdown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => StageField)))
                {
                    StageField.Click();
                    SelectStageName.Click();
                    SUT.Log.DebugFormat("Stage is selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Stage is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Stage is not selected from the droddown");
            }
        }

        public void SelecttheOwnerName()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickOwnerField)))
                {
                    SalesCenterUtility.ScrollToElement(ClickOwnerField);
                    ClickOwnerField.Click();
                    Thread.Sleep(1000);
                    SelectOwnerName.Click();
                    SUT.Log.DebugFormat("Owner selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Owner is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Owner is not selected from the dropdown");
            }
        }
        
        public void VerifyOpportunitiesLink()
        {
            Actions actions = new Actions(SUT.Web.WebDriver);
            actions.MoveToElement(ClickSalesCenter).Build().Perform();
            actions.MoveToElement(ClickOpportunitiesLink).Click().Perform();
        }
      
        //Create opportunity directly

        public void ClickonCreateOpportunityButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddLeadButton)))
                {
                    ClickCreateOpportunityButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Create opportunity button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create opportunity button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create opportunity button is not clicked");
            }
        }

        public void EnterTheLeadNameInSearchField(string leadname)
        {
            EnterTheLeadname.SendKeys(leadname);
            EnterTheLeadname.SendKeys(Keys.Enter);
        }

        public void ClickonCreateOpportunityButtonInOppPage()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCreateOpportunityButtonInOppPage)))
                {
                    ClickCreateOpportunityButtonInOppPage.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Create opportunity button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create opportunity button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create opportunity button is not clicked");
            }
        }

        public void IsCreateOpportunitySliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CreateOpportunityPageIsDisplayed)))
                {
                    CreateOpportunityPageIsDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Create opportunity slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create opportunity slider is diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create opportunity slider is diplayed");
            }
        }

        public void IsAddOpportunityPageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => AddOpportunityPageIsDisplayed),TimeSpan.FromSeconds(10)))
                {
                    AddOpportunityPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Create opportunity slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create opportunity slider is diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create opportunity slider is diplayed");
            }
        }

        public void ClickAddAdditionalServiceorProductButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddAdditionalServiceOrProductButton)))
                {
                    ClickAddAdditionalServiceOrProductButton.Click();
                    SUT.Log.DebugFormat("Add additional service or product button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add additional service or product button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add additional service or product button is not clicked");
            }
        }


        //Add contract to the elad

        public void ClickonSendContractButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSendContractButton),TimeSpan.FromSeconds(5)))
                {
                    ClickSendContractButton.Click();
                    SUT.Log.DebugFormat("Send contract button is clicked");                  
                }
                else
                {
                    SUT.Log.ErrorFormat("Send contract button is not clicked {0}", MethodBase.GetCurrentMethod().Name);                    
                }
               
            } 
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Send contract button is not clicked");
            }
        }

        public void IsCreateContractSliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CreateContractPageIsDisplayed)))
                {
                    CreateContractPageIsDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Create Contrcat slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create Contrcat slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create Contrcat slider is not diplayed");
            }
        }

        public void SelecttheTemplateName()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickTemplateField)))
                {
                    ClickTemplateField.Click();            
                    SelectContractTemplate.Click();
                    SUT.Log.DebugFormat("Contract template selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Contract template is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Contract template is not selected from the dropdown");
            }
        }

        public void ClickOnLaunchFormToCompleteButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickLaunchFormToCompleteButton)))
                {
                    ClickLaunchFormToCompleteButton.Click();
                    Thread.Sleep(20000);
                    SUT.Log.DebugFormat("Launch form button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Launch form button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Launch form button is not clicked ");
            }
        }

        public void ClickOnProceedButtonInPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickProceedButton)))
                {
                    ClickProceedButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Proceed button in popup is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Proceed button in popup is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Proceed button in popup is not clicked ");
            }
        }

        public void IsContractIsAdded()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ContractIsAdded)))
                {
                    ContractIsAdded.Displayed.ToString();
                    SUT.Log.DebugFormat("Contract is added");
                }
                else
                {
                    SUT.Log.ErrorFormat("Contract is not added {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Contract is not added");
            }
        }

        public void ClickFiltersButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickOnFilterButton),TimeSpan.FromSeconds(15)))
                {
                    Thread.Sleep(3000);
                    ClickOnFilterButton.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Filters button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Filters button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Filters button is not clicked ");
            }
        }

        public void SelectleadStatus()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadStatusExpandIcon)))
                {
                    SalesCenterUtility.ScrollToElement(LeadStatusExpandIcon);
                    LeadStatusExpandIcon.Click();
                    Thread.Sleep(1000);
                    LeadStatusOpenField.Click();
                    Thread.Sleep(1000);
                    LeadStatusName.Click();
                    SUT.Log.DebugFormat("Lead status is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead status is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead status is not selected");
            }
        }

        public void ClickOnApplyButtonInSider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickApplyButton)))
                {
                    ClickApplyButton.Click();
                    Thread.Sleep(10000);
                    SUT.Log.DebugFormat("Apply button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Apply button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Apply button is not clicked ");
            }
        }

        public void ClickOnThreeDotsIconforDisqualifiedLead()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconforDisqualified)))
                {
                    ClickThreeDotsIconforDisqualified.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Three dots icon is clicked for Disqualified lead");
                }
                else
                {
                    SUT.Log.ErrorFormat("Three dots icon is not clicked for Disqualified lead {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Three dots icon is not clicked for Disqualified lead ");
            }

        }

        public void SelectReopenOptionforDisqualifiedLead()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ReopenoptionforDisqualifiedlead)))
                {
                    ReopenoptionforDisqualifiedlead.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Reopen option is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reopen option is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reopen option is not clicked");
            }

        }

        public void SelectReopenleadStatus()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ReopenLeadStatusField)))
                {
                    ReopenLeadStatusField.Click();
                    Thread.Sleep(2000);
                    ReopenLeadStatusName.Click();
                    SUT.Log.DebugFormat("Lead status is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead status is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead status is not selected");
            }
        }

        public void ClickOnClearFilterButtonInSider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickClearFilterButton)))
                {
                    ClickClearFilterButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Clear filter button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Clear filter button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Clear filter button is not clicked ");
            }
        }

        public void IsDisqualifiedLeadsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DisqualifiedLeadDisplayed)))
                {
                    DisqualifiedLeadDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Contract is added");
                }
                else
                {
                    SUT.Log.ErrorFormat("Contract is not added {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Contract is not added");
            }
        }

        public void ClickOnBillToExpandIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickBillToExpandButton)))
                {
                    ClickBillToExpandButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Bill to location expand icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Bill to location expand icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Bill to location expand icon is not clicked ");
            }
        }

        public void ClickOnMatchOrCreateLocationLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickMatchOrCreateLocationLink)))
                {
                    ClickMatchOrCreateLocationLink.Click();
                    SUT.Log.DebugFormat("Match/Create new location is clicked");
                }
                else
                {
                    SUT.Log.DebugFormat("Location matched");
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match/Create new location is not clicked ");
            }
        }

        public void IsMatchorCreateSliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => MatchorCreateNewLocationSliderDisplayed)))
                {
                    MatchorCreateNewLocationSliderDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Match or create new location slider is displayed ");
                }
                else
                {
                    SUT.Log.ErrorFormat("Match or create new location slider is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match or create new location slider is not displayed");
            }
        }

        public void ClickOnMatchToExistingLocationButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickMatchToExistingLocationButton)))
                {
                    ClickMatchToExistingLocationButton.Click();
                    SUT.Log.DebugFormat("Match to existing location button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Match to existing location button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match to existing location button is not clicked");
            }
        }

        public void ClickOnSaveButtonInBilltoMatchingSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButtonInBilltoMatchingSlider)))
                {
                    ClickSaveButtonInBilltoMatchingSlider.Click();
                    SUT.Log.DebugFormat("Match to existing location button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Match to existing location button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match to existing location button is not clicked");
            }
        }

        public void ClickOnExistingLocationRadioButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickExistingLocationRadioButton)))
                {
                    ClickExistingLocationRadioButton.Click();
                    SUT.Log.DebugFormat("Existing location radio button is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Existing location radio button is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Existing location radio button is selected");
            }
        }

        public void SelecttheServiceLocation()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceLocationField)))
                {
                    SalesCenterUtility.ScrollToElement(ClickServiceLocationField);
                    ClickServiceLocationField.Click();
                    Thread.Sleep(2000);
                    SelectServiceLocationName.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Service location is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service location is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service location is not selected from the dropdown");
            }
        }

        //Update service in opportunity form

        public void ClickOnThreeDotsIconInUpdateServiceSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconInSlider)))
                {
                    ClickThreeDotsIconInSlider.Click();
                    SUT.Log.DebugFormat("Match to existing location button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Match to existing location button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match to existing location button is not clicked");
            }
        }

        public void ClickOnEditOption()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickEditOption)))
                {
                    ClickEditOption.Click();
                    SUT.Log.DebugFormat("Edit button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Edit button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Edit button is not clicked");
            }
        }

        public void SelectOtherServiceFromDropDown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceField)))
                {
                    ClickServiceField.Click();
                    Thread.Sleep(2000);
                    SelectOtherServicename.Click();
                    SUT.Log.DebugFormat("Service selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service is not selected from the dropdown");
            }
        }

        public void ClickOnUpdateServiceButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickUpdateServiceButton)))
                {
                    ClickUpdateServiceButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Update service button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Update service button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Update service button is not clicked");
            }
        }

        public void ClickOnViewServicesAddedLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickViewServicesAddedLink)))
                {
                    SalesCenterUtility.ScrollToElement(ClickViewServicesAddedLink);
                    ClickViewServicesAddedLink.Click();
                    SUT.Log.DebugFormat("View services added link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View services added link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View services added link is not clicked");
            }
        }

        //Create new location in PP

        public void ClickOnCreateNewLocationTab()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCreatenewLocationTab)))
                {
                    ClickCreatenewLocationTab.Click();
                    SUT.Log.DebugFormat("Create New location tab is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create New location tab is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create New location tab is not clicked");
            }
        }

        public void IsCreateNewLocationDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() =>CreateNewLocationPageIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    CreateNewLocationPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Create new location page is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create new location page is diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create new location page is diplayed");
            }
        }

        public void ClickOnBillToEditButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickBillToEditButton)))
                {
                    ClickBillToEditButton.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Bill-to Edit button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Bill-to Edit button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Bill-to Edit button is not clicked");
            }
        }

        public void IsUpdateLocationSliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdateLocationSliderDisplayed)))
                {
                    UpdateLocationSliderDisplayed.Displayed.ToString();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Match or create new location slider is displayed ");
                }
                else
                {
                    SUT.Log.ErrorFormat("Match or create new location slider is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match or create new location slider is not displayed");
            }
        }

        public void EnterLocationAddressDetails(string address, string city, string state, string postalcode)
        {
            SalesCenterUtility.ScrollToElement(AddressNamefield);
            AddressNamefield.Clear();
            AddressNamefield.SendKeys(address);
            AddressNamefield.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            CityNamefield.Clear();
            CityNamefield.SendKeys(city);
            Thread.Sleep(1000);

            StateNamefield.Clear();
            StateNamefield.SendKeys(state);
            Thread.Sleep(1000);

            PostalcodeNamefield.Clear();
            PostalcodeNamefield.SendKeys(postalcode);
            Thread.Sleep(1000);
        }

        public void ClickOnServiceLocationEditButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceLocationEditButton)))
                {
                    ClickServiceLocationEditButton.Click();
                    SUT.Log.DebugFormat("Service location Edit button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service location Edit button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service location Edit button is not clicked");
            }
        }

        public void ClickOnSaveButtonInUpdateLocationSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButtonInUpdateLocationSlider)))
                {
                    ClickSaveButtonInUpdateLocationSlider.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Save button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Save button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Save button is not clicked");
            }
        }

        public bool VerifyServiceLocationAddedConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ServiceLocationValidationConfirm_Txt)))
            {
                SUT.Log.Debug("Validation  message is displayed");
                Assert.True(ServiceLocationValidationConfirm_Txt.Text.Contains(message), "Validation message is not matching");
                Thread.Sleep(20000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Validation message is displayed");
                return false;
            }
        }

        public bool VerifyNewLocationCreatedConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => NewLocationValidationConfirm_Txt)))
            {
                SUT.Log.Debug("Validation  message is displayed");
                Assert.True(NewLocationValidationConfirm_Txt.Text.Contains(message), "Validation message is not matching");
                Thread.Sleep(12000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Validation message is not displayed");
                return false;
            }
        }

        //Duplicate alerts

        public void EnableToggleButtonOn()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ToggleButtonOn)))
                {
                    ToggleButtonOn.Click();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Show only required fields toggle button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Show only required fields toggle button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Show only required fields toggle button is not clicked");
            }
        }

        public void EnterLeadFirstName(string firstname)
        {
            FirstNamefield.SendKeys(firstname);
            FirstNamefield.SendKeys(Keys.Enter);
            Thread.Sleep(6000);
        }

        public void IsDuplicateAlertCountDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DuplicateAlertCountDisplayed)))
                {
                    string text = DuplicateAlertCountDisplayed.Text;
            
                    Regex re = new Regex(@"[0-9]+");

                    var match = re.Matches(text);
                    foreach(Match m in match)
                    {
                        Console.WriteLine("Duplicate alert count is:::" + m.Value);
                    }

                    SUT.Log.DebugFormat("Duplicate alerts are displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Duplicate alerts are not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Duplicate alerts are not displayed");
            }
        }

        public void ClickOnDuplicateAlertLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDuplicateAlertLink)))
                {
                    ClickDuplicateAlertLink.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Duplicate alert page is displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Duplicate alert page is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Duplicate alert page is not displayed");
            }
        }

        public void IsDuplicatePageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DuplicateAlertCountDisplayed)))
                {
                    string text = SameDuplicateAlertCountIsDisplayed.Text;
           
                    Regex re = new Regex(@"[0-9]+");

                    var match = re.Matches(text);
                    foreach (Match m in match)
                    {
                        Console.WriteLine("Duplicate alert count is:::" +m.Value);
                    }

                    SUT.Log.DebugFormat("Duplicate alerts same count diplayed in duplicate alerts page");
                }
                else
                {
                    SUT.Log.ErrorFormat("Duplicate alerts same count is not diplayed in duplicate alerts page {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Duplicate alerts same count is not diplayed in duplicate alerts page");
            }
        }

        public void ClickOnCloseDuplicateAlertButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCloseDuplicateAlertButton)))
                {
                    ClickCloseDuplicateAlertButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Close duplicate alert button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close duplicate alert button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close duplicate alert button is not clicked");
            }
        }

        //Verifying invliad card info

        public bool VerifyInvalidCardErrorMessage(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => InvalidCardErrorMessage_Txt)))
            {
                SUT.Log.Debug("Error  message is displayed");
                Assert.True(InvalidCardErrorMessage_Txt.Text.Contains(message), "Error  message is not displayed");
                Thread.Sleep(4000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Error  message is not displayed");
                return false;
            }
        }

        //Validate capture card button

        public void MouseHoverOnCaptureCardButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => MouseHoverCaptureCardButton)))
                {
                    SalesCenterUtility.ScrollToElement(MouseHoverCaptureCardButton);
                    Thread.Sleep(2000);
                    Assert.AreEqual(false, MouseHoverCaptureCardButton.Enabled);                  
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Capture card button is disabled");
                }
                else
                {
                    Assert.AreEqual(true, MouseHoverCaptureCardButton.Enabled);
                    SUT.Log.ErrorFormat("Capture card button is enabled {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Capture card button is enabled");
            }
        }

        public bool VerifyCatureCardButtonWarningToastmessage(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CatureCardButtonWarningToastmessage)))
            {
                SUT.Log.Debug("Toast  message is displayed");
                Assert.True(CatureCardButtonWarningToastmessage.Text.Contains(message), "Toast  message is not displayed");
                Thread.Sleep(4000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Toast  message is not displayed");
                return false;
            }
        }

        //Disqualified the lead

        public void ClickOnLeadStatusField()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickLeadStatusField)))
                {
                    ClickLeadStatusField.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Lead status dropdown is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead status dropdown is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead status dropdown is not clicked");
            }
        }

        public void SelectDisqualifiedOption()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DisqualifiedOption)))
                {
                    DisqualifiedOption.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Disqualified option is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Disqualified option is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Disqualified option is not clicked");
            }
        }

        public void IsDisqualifiedPopupIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DisqualifiedPopupIsDisplayed)))
                {
                    DisqualifiedPopupIsDisplayed.Displayed.ToString();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Disqualified popup is displayed ");
                }
                else
                {
                    SUT.Log.ErrorFormat("Disqualified popup is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Disqualified popup is not displayed");
            }
        }

        public void ClickOnNotInterestedRadioButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => NotInterestedRadioButton)))
                {
                    NotInterestedRadioButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Not interested radio button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Not interested radio button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Not interested radio button is not clicked");
            }
        }

        public void ClickOnSaveButtonInDisqualifiedPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SaveButtonInDisqualifiedPopup)))
                {
                    SaveButtonInDisqualifiedPopup.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Save button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Save button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Save button is not clicked");
            }
        }

        //Adding a service to a lead

        public void IsLeadDetailsPageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DetailsPageIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    DetailsPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Lead details page is displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead details page is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead details page is not displayed");
            }
        }

        //Click remove button in popup for lead

        public void ClickOnRemoveButtonInPopupForleads()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickRemoveButtonInPopupForLeads)))
                {
                    ClickRemoveButtonInPopupForLeads.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Remove button is clicked in popup");
                }
                else
                {
                    SUT.Log.ErrorFormat("Remove button is not clicked in popup {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Remove button is not clicked in popup");
            }
        }

        //Unbale to convert to lead without service

        public void MouseHoverOnConvertToOpportunityButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => MouseHoverConverttoOpportunityButton)))
                {
                    MouseHoverConverttoOpportunityButton.Click();
                  //  Assert.AreEqual(false, MouseHoverConverttoOpportunityButton.Enabled);
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Convert to opportunity button is disabled");
                }
                else
                {
                   // Assert.AreEqual(true, MouseHoverCaptureCardButton.Enabled);
                    SUT.Log.ErrorFormat("Convert to opportunity button is enabled {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Convert to opportunity button is enabled");
            }
        }

        //Update lead name details

        public void ClickOnLeadPencilIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickLeadPencilIcon)))
                {
                    ClickLeadPencilIcon.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Lead pencil icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead pencil icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead pencil icon is not clicked");
            }
        }

        public bool UpdateFirstNameInLeadPopup(string firstname)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdateFirstName)))
                {
                    //  UpdateFirstName.Click();
                    UpdateFirstName.SendKeys(Keys.Control + "a");
                    UpdateFirstName.SendKeys(Keys.Delete);
                    UpdateFirstName.SendKeys(firstname);
                    Thread.Sleep(1000);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateLastNameInLeadPopup(string lastname)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdateLastName)))
                {
                    //  UpdateLastName.Click();
                   
                    UpdateLastName.SendKeys(Keys.Control + "a");
                    UpdateLastName.SendKeys(Keys.Delete);
                    UpdateLastName.SendKeys(lastname);
                    Thread.Sleep(1000);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void IsRenameThisLeadPopupDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => RenameThisLeadPopupDisplayed), TimeSpan.FromSeconds(3)))
                {
                    string renamepopup=RenameThisLeadPopupDisplayed.ToString();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Rename This Lead Popup is Displayed {0}", renamepopup);
                }
                else
                {
                    SUT.Log.ErrorFormat("Rename This Lead Popup is not Displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Rename This Lead Popup is not Displayed");
            }
        }

        public bool IsUpdatedLeadDetailsDisplayed()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdatedLeadDetails)))
            {
                if (UpdatedLeadDetails.Text.Contains("James Smith")) 
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

        public void ClickOnThreeDotsIconForBillToLocation()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickThreeDotsIcnForBillToLocation)))
                {
                   // SalesCenterUtility.ScrollToElement(ClickThreeDotsIcnForBillToLocation);
                    ClickThreeDotsIcnForBillToLocation.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Bill-to location three dots icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Bill-to location three dots icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Bill-to location three dots icon is not clicked");
            }
        }

        public void IsUpdateBillToLocationSliderIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdateBillToLocationSliderIsDisplayed), TimeSpan.FromSeconds(3)))
                {
                    string UpdateBillToSliderDisplayed = UpdateBillToLocationSliderIsDisplayed.ToString();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Update  bill to location slider is Displayed {0}", UpdateBillToSliderDisplayed);
                }
                else
                {
                    SUT.Log.ErrorFormat("Update  bill to location slider is not Displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Update  bill to location slider is not Displayed");
            }
        }

        public void SelectBranchdropdownValue()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => SelectBranchField)))
                {
                    SelectBranchField.Click();
                    SelectBranchName.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Branch name is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Branch name is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Branch name is not selected from the dropdown");
            }
        }

        public void SelectLocationTypedropdownValue()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => SelectLocationTypeField)))
                {
                    SelectLocationTypeField.Click();
                    SelectLocationTypeName.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Location type is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Location type is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Location type is not selected from the dropdown");
            }
        }

          public void SelectDivisiondropdownValue()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => SelectDivisonField)))
                {
                    SelectDivisonField.Click();
                    SelectDivisonName.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Division is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Division is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Division is not selected from the dropdown");
            }
        }

        public bool IsBillToFirstandLastNameUpdated()
        {
          
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdatedLeadDetails)))
            {
                if (UpdatedLeadDetails.Text.Contains("James Smith"))
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
 
        public void ClickOnViewMoreInformationLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickViewMoreInformationLink)))
                {
                //    SalesCenterUtility.ScrollToElement(ClickViewMoreInformationLink);                  
                    ClickViewMoreInformationLink.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("View more information link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View more information link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View more information link is not clicked");
            }
        }

        public void ClickOnThreeDotsIconForServiceLocation()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickThreeDotsIcnForServiceLocation)))
                {
                    // SalesCenterUtility.ScrollToElement(ClickThreeDotsIcnForBillToLocation);
                    ClickThreeDotsIcnForServiceLocation.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Service location three dots icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service location three dots icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service location three dots icon is not clicked");
            }
        }

        public void IsUpdateServiceLocationSliderIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdateServiceLocationSliderIsDisplayed), TimeSpan.FromSeconds(3)))
                {
                    string UpdateServiceSliderDisplayed = UpdateServiceLocationSliderIsDisplayed.ToString();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Update  service location slider is Displayed {0}", UpdateServiceSliderDisplayed);
                }
                else
                {
                    SUT.Log.ErrorFormat("Update  service location slider is not Displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Update  service location slider is not Displayed");
            }
        }

        public void ClickOnViewMoreInformationLinkForServcieLocation()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickViewMoreInformationLinkForServcieLocation)))
                {
                    //    SalesCenterUtility.ScrollToElement(ClickViewMoreInformationLink);                  
                    ClickViewMoreInformationLinkForServcieLocation.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("View more information link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View more information link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View more information link is not clicked");
            }
        }

        public void ClickOnEditLinkForAdditionalInformationSection()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickEditLinkForAdditionalInformationSection)))
                {                               
                    ClickEditLinkForAdditionalInformationSection.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Edit link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Edit link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Edit link is not clicked");
            }
        }



        public void SelectSalesTeamdropdownValue()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickSalesTeamField)))
                {
                    ClickSalesTeamField.Click();
                    SelectSalesTeamValue.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Sales team name is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team name is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team name is not selected from the dropdown");
            }
        }

        public void SelectOwnerdropdownValue()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickOwnerAssigneeField)))
                {
                    ClickOwnerAssigneeField.Click();
                    SelectOwnerValue.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Owner name is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Owner name is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Owner name is not selected from the dropdown");
            }
        }

        public void SelectSalesFunneldropdownValue()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickFunnelField)))
                {
                    ClickFunnelField.Click();
                    SelectFunnelValue.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Sales funnel name is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales funnel name is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales funnel name is not selected from the dropdown");
            }
        }

        public void SelectLeadStatusdropdownValue()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickleadStatusField)))
                {
                    ClickleadStatusField.Click();
                    SelectLeadStatusValue.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Lead status value is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead status value is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead status value is not selected from the dropdown");
            }
        }

        public void SelectTargetPestdropdownValue()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClicktargetPestField)))
                {
                    ClicktargetPestField.Click();
                    SelectPestValue.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Target Pest value is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Target Pest value is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Target Pest value is not selected from the dropdown");
            }
        }

        public void SelectCampaigndropdownValue()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickCampaignField)))
                {
                    ClickCampaignField.Click();
                    SelectCampaignValue.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Campaign value is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Campaign value is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Campaign value is not selected from the dropdown");
            }
        }

        public void SelectLeadSourcedropdownValue()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickleadSourceField)))
                {
                    ClickleadSourceField.Click();
                    SelectLeadSourceValue.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Campaign value is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Campaign value is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Campaign value is not selected from the dropdown");
            }
        }

        public bool IsBillToLocationUpdatedValidationMessage(string message)
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => BillToLocationUpdatedValidationMessage), TimeSpan.FromSeconds(10)))
            {
                SUT.Log.Debug("Validation  message is displayed");
                Assert.True(BillToLocationUpdatedValidationMessage.Text.Contains(message), "Validation message is not matching");
                Thread.Sleep(16000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Validation message is displayed");
                return false;
            }
        }

        public bool IsSalesTeamNameUpdated()
        {


            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdatedSalesTeamName)))
            {
                SalesCenterUtility.ScrollToElement(UpdatedSalesTeamName);
                if (UpdatedSalesTeamName.Text.Contains("South Branch Sales Team"))
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

        public bool IsOwnerNameUpdated()
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdatedOwnerName)))
            {
                if (UpdatedOwnerName.Text.Contains("Chad Kochel"))
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

        public bool IsSalesFunnelNameUpdated()
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdatedSalesFunnelName)))
            {
                if (UpdatedSalesFunnelName.Text.Contains("Test Sales funnel"))
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

       
        public bool IsCampaignNameUpdated()
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdatedCampaignName)))
            {
                if (UpdatedCampaignName.Text.Contains("CUSTOMER"))
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

        public bool IsLeadSourceNameUpdated()
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdatedLeadSourceName)))
            {
                if (UpdatedLeadSourceName.Text.Contains("RECOMMEND"))
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

        public bool IsTargetPestsNameUpdated()
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdatedTargetPestsName)))
            {
                if (UpdatedTargetPestsName.Text.Contains("CLOVR MITE"))
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

        //Verify duplicate alerts page

        public bool IsRecordNameColumIsDisplayed()
        {


            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => RecordNameCoulmIsDisplayed)))
            {              
                if (RecordNameCoulmIsDisplayed.Text.Contains("Record Name"))
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

        public bool IsAddressColumIsDisplayed()
        {


            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => AddressColumIsDisplayed)))
            {
                if (AddressColumIsDisplayed.Text.Contains("Address"))
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

        public bool IsCompanyNameColumIsDisplayed()
        {


            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CompanyNameColumIsDisplayed)))
            {
                if (CompanyNameColumIsDisplayed.Text.Contains("Company Name"))
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

        public bool IsEmailColumIsDisplayed()
        {


            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => EmailColumIsDisplayed)))
            {
                if (EmailColumIsDisplayed.Text.Contains("Email"))
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

        public bool IsPhoneColumIsDisplayed()
        {


            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PhoneColumIsDisplayed)))
            {
                if (PhoneColumIsDisplayed.Text.Contains("Phone"))
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

        public bool IsTypeColumIsDisplayed()
        {


            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => TypeColumIsDisplayed)))
            {
                if (TypeColumIsDisplayed.Text.Contains("Type"))
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

        public bool IsNameColumIsDisplayed()
        {


            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => NameColumIsDisplayed)))
            {
                if (NameColumIsDisplayed.Text.Contains("Name"))
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

        public bool IsBranchColumIsDisplayed()
        {


            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => BranchColumIsDisplayed)))
            {
                if (BranchColumIsDisplayed.Text.Contains("Branch"))
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

       
          public void ClickOnPestPacLocationTab()
            {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickPestPacLocationTab)))
                {
                    ClickPestPacLocationTab.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Pestpac location tab is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Pestpac location tab is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Pestpac location tab is not clicked");
            }
        }

        //Update service details

        public void ClickOnViewDetailsExpandLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickViewDetailsExpandLink)))
                {
                    ClickViewDetailsExpandLink.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("View details expand link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View details expand link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View details expand link is not clicked");
            }
        }

        public bool IsInitialPriceIsDisplayed()
        {


            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => InitialPriceIsDisplayed)))
            {
                if (InitialPriceIsDisplayed.Text.Contains("50"))
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

        public bool IsInitialPriceIsEntered(string firstname)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => InitialPriceIsEntered)))
                {
                    //  UpdateFirstName.Click();
                    InitialPriceIsEntered.SendKeys(Keys.Control + "a");
                    InitialPriceIsEntered.SendKeys(Keys.Delete);
                    InitialPriceIsEntered.SendKeys(firstname);
                    Thread.Sleep(1000);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ClickOnDeleteButtonInDeleteServicePopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteButtonInDeleteServicePopup)))
                {
                    ClickDeleteButtonInDeleteServicePopup.Click();
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

        public void ClickOnThreeDotsIconInUpdatedService()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconInUpdatedService)))
                {
                    ClickThreeDotsIconInUpdatedService.Click();
                    SUT.Log.DebugFormat("Three dots icon is clicked for updated service");
                }
                else
                {
                    SUT.Log.ErrorFormat("Three dots icon is not clicked for updated service {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Three dots icon is not clicked for updated service");
            }
        }

        //Add service or product slideoout

        public void IsAddServiceOrProductDropdownIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => AddServiceOrProductIsDisplayed), TimeSpan.FromSeconds(3)))
                {
                    string AddServiceOrProductDisplayed = AddServiceOrProductIsDisplayed.ToString();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Add service or product dropdown is Displayed {0}", AddServiceOrProductDisplayed);
                }
                else
                {
                    SUT.Log.ErrorFormat("Add service or product dropdown is not Displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add service or product dropdown is not Displayed");
            }
        }

        public void IsUpsellToggleButtonIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => UpsellToggleButtonIsDisplayed), TimeSpan.FromSeconds(3)))
                {
                    SalesCenterUtility.ScrollToElement(UpsellToggleButtonIsDisplayed);
                    string UpsellToggleButtonDisplayed = UpsellToggleButtonIsDisplayed.ToString();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Upsell toggle button is Displayed {0}", UpsellToggleButtonDisplayed);
                }
                else
                {
                    SUT.Log.ErrorFormat("Upsell toggle button is not Displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Upsell toggle button is not Displayed");
            }
        }

        public void IsPricingLabelIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => PricingLabelIsDisplayed), TimeSpan.FromSeconds(3)))
                {
                    string PricingLabelDisplayed = PricingLabelIsDisplayed.ToString();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Pricing label is Displayed {0}", PricingLabelDisplayed);
                }
                else
                {
                    SUT.Log.ErrorFormat("Pricing label is not Displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Pricing label is not Displayed");
            }
        }

        public void IsInitialButtonIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => InitialButtonIsDisplayed), TimeSpan.FromSeconds(3)))
                {
                    string InitialButtonDisplayed = InitialButtonIsDisplayed.ToString();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Initial button is Displayed {0}", InitialButtonDisplayed);
                }
                else
                {
                    SUT.Log.ErrorFormat("Initial button is not Displayed  {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Initial button is not Displayed");
            }
        }

        public void IsDiscountButtonIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => DiscountButtonIsDisplayed), TimeSpan.FromSeconds(3)))
                {
                    SalesCenterUtility.ScrollToElement(DiscountButtonIsDisplayed);
                    string DiscountButtonDisplayed = DiscountButtonIsDisplayed.ToString();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Discount button is Displayed {0}", DiscountButtonDisplayed);
                }
                else
                {
                    SUT.Log.ErrorFormat("Discount button is not Displayed  {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Discount button is not Displayed");
            }
        }

        public void IsToggleButtonIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ToggleButtonIsDisplayed), TimeSpan.FromSeconds(3)))
                {
                    SalesCenterUtility.ScrollToElement(ToggleButtonIsDisplayed);
                    string ToggleButtonDisplayed = ToggleButtonIsDisplayed.ToString();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Toggle button is Displayed {0}", ToggleButtonDisplayed);
                }
                else
                {
                    SUT.Log.ErrorFormat("Toggle button is not Displayed  {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Toggle button is not Displayed");
            }
        }

        public void IsServiceProductSummaryIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ServiceProductSummaryIsDisplayed), TimeSpan.FromSeconds(3)))
                {
                    string ServiceProductSummaryDisplayed = ServiceProductSummaryIsDisplayed.ToString();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Service product summary is Displayed {0}", ServiceProductSummaryDisplayed);
                }
                else
                {
                    SUT.Log.ErrorFormat("Service product summary is not Displayed  {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service product summary is not Displayed");
            }
        }

        public void IsAddServiceButtonIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => AddServiceButtonIsDisplayed), TimeSpan.FromSeconds(3)))
                {
                    string  AddServiceButtonDisplayed = AddServiceButtonIsDisplayed.ToString();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Add servcie button is Displayed {0}", AddServiceButtonDisplayed);
                }
                else
                {
                    SUT.Log.ErrorFormat("Add servcie button is not Displayed  {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add servcie button is not Displayed");
            }
        }

        //Add dollar amount and discount percetage to service

        public bool IsDollarPercentageIsEntered(string dollarpercentage)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => DollarPercentageIsEntered)))
                {
                    //  UpdateFirstName.Click();
                    DollarPercentageIsEntered.SendKeys(Keys.Control + "a");
                    DollarPercentageIsEntered.SendKeys(Keys.Delete);
                    DollarPercentageIsEntered.SendKeys(dollarpercentage);
                    Thread.Sleep(1000);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


    }

}



    #endregion Selenium



