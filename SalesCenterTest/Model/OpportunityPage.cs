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
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;

namespace WorkWave.PestPac.TA.Model
{
    class OpportunityPage : IWebPage
    {
       
        private readonly string PrimaryContactText = "James Jacob";

        #region PageFactory

        #region Bulk reopen close opportunities

        [FindsBy(How = How.XPath, Using = "//div[@role='tooltip']/descendant::ul/child::div[4]")]
        private IWebElement ClickOpportunitiesLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Opportunities']")]
        private IWebElement PageHeader { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//*[local-name()='svg' and @data-testid='ListIcon']/..")]
        private IWebElement ClickListviewButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[2]/..")]
        private IWebElement ClickFirstOpportunitiesCheckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[3]")]
        private IWebElement ClickSecondOpportunitiesCheckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='bulkActBtn-reopen']")]
        private IWebElement ClickBulkReopenButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='Opportunity Status']")]
        private IWebElement OpportunitiesStatusExpandIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='filters.closed.value']/..")]
        private IWebElement OpportunitiesStatusOpenField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Closed']")]
        private IWebElement OpportunitiesStatusName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Narrowed to Opportunities')]")]
        private IWebElement ClosedOpportunitiesDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Reopen')]")]
        private IWebElement ReopenPageIsDisplayed { get { return PageFactory.Load(this); } }

        #endregion  Bulk reopen close opportunities

        #region close lost opportunities

        [FindsBy(How = How.LinkText, Using = "View Detail Page")]
        private IWebElement ClickViewDetailsLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Opportunity Detail Page')]")]
        private IWebElement OpportunityDetailPageIsDisplayed { get { return PageFactory.Load(this); } }

        #endregion Close lost opportunities

        #region Select all the checkbox in listview

        [FindsBy(How = How.XPath, Using = "//div[text()='Closed Won / Closed Lost']/..")]
        private IWebElement ClickCloseLostExpandIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Closed Lost...')]/..")]
        private IWebElement ClickCloseLostOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Lost to Competitor']")]
        private IWebElement ClickLostCompetitorRadioButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='SAVE']")]
        private IWebElement ClickSaveButtonInCloseLostPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[1]/..")]
        private IWebElement ClickAllCheckboxOption { get { return PageFactory.Load(this); } }
    
        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[1]/..")]
        private IWebElement CheckboxSelected { get { return PageFactory.Load(this); } }

        #endregion Select all the checkbox in listview

        #region reopen closed won/lost opportunities through card view

        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='opportunityMoreBtn']")]
        private IWebElement ClickThreeDotsIconforClosedOpportunities { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='- - / - - / - - - -']/..")]
        private IWebElement ClickCalenderIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='OK']/..")]
        private IWebElement ClickOkButtonInCalenderPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Re-Open')])[1]")]
        private IWebElement ClickReopenButtonInCalenderPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@data-test-id='reopenBtn']")]
        private IWebElement ReopenoptionforClosedOpportunities { get { return PageFactory.Load(this); } }




        #endregion reopen closed won/lost opportunities through card view 

        #region  closed won opportunity

        [FindsBy(How = How.XPath, Using = "(//div[text()='Next Action'])[1]")]
        private IWebElement ClickAnywhere { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Closed Won']")]
        private IWebElement ClickCloseWonOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Close Form Manager']")]
        private IWebElement ClickCloseFormmanagerButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Opportunities']")]
        private IWebElement ClickOpportunitiesLinkInLeadsPage { get { return PageFactory.Load(this); } }

        #endregion closed won opportunity

        #region Add credit card details

        [FindsBy(How = How.XPath, Using = "//button[contains(@data-test-id,'paymentBtn')]/.")]
        private IWebElement ClickCaptureCardButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement EnterCardName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement ClickEnterButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[contains(text(),'Add CC for API Auto CC Refund')]/../../../following-sibling::div[contains(@data-test-id,'cardFooter')])[1]")]
        private IWebElement ClickServiceExapndIconForMatchedOpportunity { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "cardNumber")]
        private IWebElement CardNumber { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ddlExpirationMonth")]
        private IWebElement selmonth { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ddlExpirationYear")]
        private IWebElement selyear { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement ClickAddcreditCardButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "iframe[src*='certtransaction.hostedpayments']")]
        private IWebElement IframeName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "//div[text()='Successfully added payment method.']/.")]
        private IWebElement PaymentAddedMessageIsDisplayed { get { return PageFactory.Load(this); } }


        
        #endregion  Add credit card details

        #region Bulk  Reassign opportunitues

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Re-Assign')]")]
        private IWebElement ClickReassignButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='reassign']")]
        private IWebElement ReassignSliderIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='salesTeamId']/..")]
        private IWebElement ClickSalesTeamField { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//li[text()='Auto Test Sales Team']")]
        private IWebElement SalesTeamNameInReassignSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='assigneeId']/..")]
        private IWebElement ClickSalesTeamMemberField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Unassigned']")]
        private IWebElement SalesTeamMemberInReassignSlider { get { return PageFactory.Load(this); } }


        #endregion Bulk reaasign opportunities

        #region Close won the opportunity without pp location matched

        [FindsBy(How = How.XPath, Using = "//h2[text()='Closing Requirements Missing']")]
        private IWebElement CloseRequirementMissingPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='CLOSE']")]
        private IWebElement ClickCloseButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Close / Win Opportunity']")]
        private IWebElement CloseWonOpportunitySliderDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        private IWebElement ClickSubmitButtonInCloseWOnOpportunitySlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//div[contains(@id,'mui')])[1]")]
        private IWebElement ClickTech1Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='ADMN']")]
        private IWebElement SelectTech1Name { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//div[contains(@id,'mui')])[2]")]
        private IWebElement ClickTech2Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='EDWARD']")]
        private IWebElement SelectTech2Name { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "(//div[contains(@id,'mui')])[3]")]
        private IWebElement ClickSales1Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='AKLEIN']")]
        private IWebElement SelectSales1Name { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "(//div[contains(@id,'mui')])[4]")]
        private IWebElement ClickSales2Field { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//li[text()='DAVID']")]
        private IWebElement SelectSales2Name { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.Name, Using = "salesNote")]
        private IWebElement SalesNote { get { return PageFactory.Load(this); } }

        #endregion Close won the opportunity without pp location matched

        #region Remove SC contacts

        [FindsBy(How = How.XPath, Using = "//button[text()='View Contacts']")]
        private IWebElement ClickViewContactsLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Contacts'])[2]")]
        private IWebElement ContactPageDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Add Contact')]")]
        private IWebElement ClickAddContactButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        private IWebElement ClickSearchIconInContactSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        private IWebElement Searchfield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Add Contact'])[2]")]
        private IWebElement ClickAddContactButtonInContactSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='James Jacob']/../descendant::button")]
        private IWebElement ClickThreeDotsforContacts { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'MuiListItemText-root MuiListItemText-dense')]//span)[2]")]
        private IWebElement ClickRemoveLinkForContacts { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Remove'])[2]")]
        private IWebElement ClickRemoveButtonInPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Remove']")]
        private IWebElement ClickRemoveButtonInWorkWavePopup { get { return PageFactory.Load(this); } }
       

       [FindsBy(How = How.XPath, Using = "(//span[text()='Add Contact'])[2]")]
        private IWebElement AddOpportunityPageIsDisplayed { get { return PageFactory.Load(this); } }

        #endregion Remove SC Contacts

        #region verify primary contact name

        [FindsBy(How = How.XPath, Using = "//div[text()='James Jacob']/../descendant::span[1]")]
        private IWebElement ClickPrimaryContactRadioButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Close']")]
        private IWebElement ClickCloseButtonInContactsPage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='James Jacob']")]
        private IWebElement PrimaryContactName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//input[@type='radio'])[1]/..")]
        private IWebElement OtherPrimaryContactRadioButton { get { return PageFactory.Load(this); } }

       
        #endregion verify primary contact name

        #region Edit SC opp contacts

      [FindsBy(How = How.XPath, Using = "//span[text()='Edit']")]
        private IWebElement ClickEditLinkForContacts { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement LastNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "phoneNumber")]
        private IWebElement PhoneNumber { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "emailAddresses[0].emailAddress")]
        private IWebElement EmailId { get { return PageFactory.Load(this); } }

     

        [FindsBy(How = How.XPath, Using = "//button[text()='Update Contact']")]
        private IWebElement ClickUpdateButtonInAddContactSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Update Contact']")]
        private IWebElement ClickThreeDotsforUpdatedContacts { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'WorkWave Marketing Contacts')]")]
        private IWebElement ClickWorkWaveContactsLink { get { return PageFactory.Load(this); } }

        #endregion Edit SC opp contacts 

        #region Create SC contacts for opp

        [FindsBy(How = How.XPath, Using = "(//button[text()='Add New Contact'])[1]")]
        private IWebElement ClickAddNewContactTab { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "firstName")]
        private IWebElement FirstName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement LastName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "company")]
        private IWebElement CompanyName { get { return PageFactory.Load(this); } }


       [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Create Contact')]")]
        private IWebElement ClickCreateContactButton { get { return PageFactory.Load(this); } }


        #endregion Create SC contacts for opp

        #region Push sc contacts to pp contacts

        [FindsBy(How = How.XPath, Using = "//span[text()='Send To PestPac Location']")]
        private IWebElement ClickSendTopestPaclocationlink { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'PestPac Contacts ')]")]
        private IWebElement ClickPestPacTab { get { return PageFactory.Load(this); } }



        #endregion Push sc contacts to pp contacts

        #region Add note 

        [FindsBy(How = How.XPath, Using = "//*[text()='Add Note']/.")]
        private IWebElement ClickAddNoteButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Add Note'])[2]")]
        private IWebElement AddNoteSLiderIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "detail")]
        private IWebElement Note { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//b[text()='TestAutomationNote']/../../../../following-sibling::div/child::button")]
        private IWebElement ClickThreeDotsIconforAddedNotes { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//*[@id='simple-popover']/descendant::ul/child::div)[1]")]
        private IWebElement ClickEditLinkforNotes { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement UpdateNote { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//*[@id='simple-popover']/descendant::ul/child::div)[2]")]
        private IWebElement ClickDeleteOptionforNotes { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='cancelBtn'])[4]")]
        private IWebElement ClickCancelButtonInNotesDeletePopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='okBtn'])[4]")]
        private IWebElement ClickDeleteButtonInNotesDeletePopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//b[text()='addedsecondnote']/../../../../following-sibling::div/child::button")]
        private IWebElement ClickThreeDotsIcontoDeleteNotes { get { return PageFactory.Load(this); } }


        #endregion Add note

        #region Delete opportunity card

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='opportunityMoreBtn'])[1]")]
        private IWebElement ClickThreeDotsIconforOpportunityCard { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Delete']")]
        private IWebElement ClickDeleteLinkforOpportunityCard { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='okBtn'])[1]")]
        private IWebElement ClickDeleteButtonInOpportunityDeletePopup { get { return PageFactory.Load(this); } }


        #endregion Delete opportunity card


        #region Delete already added service

        [FindsBy(How = How.XPath, Using = "(//button[contains(@data-test-id,'serviceMoreBtn')])[1]")]
        private IWebElement ClickThreeDotsIconforaddedService { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@data-test-id='deleteBtn']")]
        private IWebElement ClickDeleteLinkOptionforAddedService { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='okBtn'])[31]")]
        private IWebElement ClickDeleteButtonInDeleteServicePopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='services']/..")]
        private IWebElement ClickOtherServiceField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='BEDBUG - Bed Bug Treatment']")]
        private IWebElement SelectOtherServicename { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='ANT - Ant Treatments']")]
        private IWebElement SelectServicename { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "(//div[contains(@data-test-id,'cardFooter')])[1]")]
        private IWebElement ClickServiceExpandIconForOpportunity { get { return PageFactory.Load(this); } }


        #endregion Delete already added service

        #region Switch to Formmanager

        [FindsBy(How = How.CssSelector, Using = "iframe[src*='test-forms.workwave']")]
        private IWebElement IframeCompleteForm { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Complete Form']")]
        private IWebElement ClickCompleteFormButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary']")]
        private IWebElement ClickSendFormandNotifyFormButton { get { return PageFactory.Load(this); } }


       



        #endregion Switch to Formmamanger

        #region Can not send additional contracts,services for closed won opp

        [FindsBy(How = How.XPath, Using = "//button[contains(@data-test-id,'agreementBtn')]")]
        private IWebElement MouseHoverSendContractsButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[contains(@data-test-id,'serviceBtn')]")]
        private IWebElement MouseHoverAddServiceButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Services Added')]")]
        private IWebElement ClickViewServicesAddedLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Add Service or Product']/.")]
        private IWebElement TryToClickAddAdditionalServiceOrProductButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[contains(@data-test-id,'serviceMoreBtn')])[1]")]
        private IWebElement EditAndDeleteServices { get { return PageFactory.Load(this); } }



        #endregion Can not send additional contracts,services for closed won opp

        #region Send a contrcat form to the customer

        [FindsBy(How = How.XPath, Using = "//div[text()='INSTRUCTIONS']")]
        private IWebElement InstructionPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@id='Sales Center - Assistant Manager']")]
        private IWebElement ClickDepartmentRadioButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'p-tree-toggler p-unselectable-text')]//span[1]")]
        private IWebElement ClickSalesCenterUserExpandButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='nu5987624@gmail.com Non admin user(nu5987624@gmail.com)']")]
        private IWebElement MailIdUserCheckBox { get { return PageFactory.Load(this); } }


        #endregion Send a contrcat form to the customer

        #region Add a contract to an opp

        [FindsBy(How = How.XPath, Using = "//span[contains(@data-test-id,'agreementLink')]")]
        private IWebElement ClickViewContractsLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//*[local-name()='svg' and @data-testid='CloseIcon']")]
        private IWebElement ClickCloseIconInContractSlider { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//p[text()='Residential Service Form']")]
        private IWebElement ContratForm { get { return PageFactory.Load(this); } }



        #endregion Add a contract to an opp


        #region Card details

        [FindsBy(How = How.XPath, Using = "//div[@role='alert']")]
        private IWebElement CardAddedConfirm_Txt { get { return PageFactory.Load(this); } }


        #endregion Card details

        #region TrackB scenario

        [FindsBy(How = How.XPath, Using = "(//p[text()='Add CC for API Auto CC Refund']/../../../preceding-sibling::div/descendant::div/div[2]/child::button[1])[1]")]
        private IWebElement ClickConvertOpportunityButtonAfterMatchingTheLocation { get { return PageFactory.Load(this); } }


        #endregion TrackB scenario

        #region closing requirement counts

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'1 Service')]")]
        private IWebElement ServiceCountDisplayedInManageServicesPage { get { return PageFactory.Load(this); } }

       
      
        #endregion closing requirement counts


        #endregion PageFactory

        private readonly string PageHeaderText = "Opportunities";

        public bool IsLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PageHeader),TimeSpan.FromSeconds(10)))
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

        public void ClickonOpportunitiesLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickOpportunitiesLink),TimeSpan.FromSeconds(10)))
                {
                    ClickOpportunitiesLink.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Opportunities link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunities link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunities link is not clicked");
            }
        }

        public void ClickonListViewButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickListviewButton)))
                {
                   
                    ClickListviewButton.Click();
                    Thread.Sleep(10000);
                    SUT.Log.DebugFormat("List view button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("List view button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("List view button is not clicked");
            }
        }

        public void IsClosedOpportunitiesDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClosedOpportunitiesDisplayed)))
                {
                    ClosedOpportunitiesDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Closed opportunities are displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Closed opportunities are not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Closed opportunities are not displayed");
            }
        }

        public void SelecttheOpportunities()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickFirstOpportunitiesCheckbox),TimeSpan.FromSeconds(10)))
                {
                    ClickFirstOpportunitiesCheckbox.Click();
                    Thread.Sleep(3000);
                    ClickSecondOpportunitiesCheckbox.Click();
                    SUT.Log.DebugFormat("Opportunities are selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunities are not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunities are not selected");
            }
        }

        public void ClickOnBulkReopenButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickBulkReopenButton)))
                {
                    ClickBulkReopenButton.Click();
                    SUT.Log.DebugFormat("Bulk reopen button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Bulk reopen button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Bulk reopen button is not clicked");
            }
        }

        public void SelectOpportunitiesStatus()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => OpportunitiesStatusExpandIcon)))
                {
                    SalesCenterUtility.ScrollToElement(OpportunitiesStatusExpandIcon);
                    OpportunitiesStatusExpandIcon.Click();
                    Thread.Sleep(1000);
                    OpportunitiesStatusOpenField.Click();
                    OpportunitiesStatusName.Click();
                    SUT.Log.DebugFormat("Opportunties status is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunties status is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunties status is not selected");
            }
        }

        public void IsReopenSliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ReopenPageIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    ReopenPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(10000);
                    SUT.Log.DebugFormat("Reopen slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reopen slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reopen slider is not diplayed");
            }
        }

        //Close lost opportunities

        public void ClickOnViewDetailsLink()
        {
            try
            {
                SUT.Web.WebDriver.SwitchTo().DefaultContent();
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickViewDetailsLink),TimeSpan.FromSeconds(5)))
                {
                    ClickViewDetailsLink.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("View detail link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View detail link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View detail link is not clicked");
            }
        }

        public void IsOpportunityDetailPageDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() =>OpportunityDetailPageIsDisplayed), TimeSpan.FromSeconds(5)))
                {
                    OpportunityDetailPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(8000);
                    SUT.Log.DebugFormat("Reopen slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reopen slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reopen slider is not diplayed");
            }
        }

        public void ClickOnCloseLostExpandIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCloseLostExpandIcon)))
                {
                    ClickCloseLostExpandIcon.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Closed Won/Close Lost expand icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Closed Won/Close Lost expand icon is clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Closed Won/Close Lost expand icon is clicked");
            }
        }

        public void ClickOnCloseLostOption()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickCloseLostOption)))
                {
                    ClickCloseLostOption.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Close lost option is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close lost option is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close lost option is not clicked");
            }
        }

        public void IsSelectLostCompetitorRadioButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickLostCompetitorRadioButton)))
                {
                    ClickLostCompetitorRadioButton.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Lost competitor radio button is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lost competitor radio button is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lost competitor radio button is not selected");
            }
        }

        public void ClickOnSaveButtonInCloseLostPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButtonInCloseLostPopup)))
                {
                    ClickSaveButtonInCloseLostPopup.Click();
                    Thread.Sleep(3000);
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

        //Select all checkbox

        public void SelecttheAllOpportunitiesCheckBox()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAllCheckboxOption)))
                {
                    ClickAllCheckboxOption.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("All Opportunities checkbox is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("All Opportunities checkbox is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("All Opportunities checkbox is not selected");
            }
        }

        public void IsCheckBoxSelected()
        {
            try
            {
              bool IscheckboxSelected=  CheckboxSelected.Selected;

                if (IscheckboxSelected)
                {                   
                    SUT.Log.DebugFormat("All Opportunities checkbox is selected");
                }
                else
                {
                    CheckboxSelected.Click();
                    SUT.Log.ErrorFormat("All Opportunities checkbox is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("All Opportunities checkbox is not selected");
            }
        }

        public void ClickOnThreeDotsIconforClosedOpportunities()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconforClosedOpportunities)))
                {
                    ClickThreeDotsIconforClosedOpportunities.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Three dots icon is clicked for closed won/lost opportunities");
                }
                else
                {
                    SUT.Log.ErrorFormat("Three dots icon is not clicked for closed won/lost opportunities {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Three dots icon is not clicked for closed won/lost opportunities ");
            }
        }

        //Reopen closed won/lost opportunities
      
        public void ClickonOkReopenButtonInCalenderPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickReopenButtonInCalenderPopup)))
                {
                    ClickReopenButtonInCalenderPopup.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Reopen button is clicked in calender popup");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reopen button is not clicked in calender popup {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reopen button is not clicked in calender popup");
            }
        }

        public void SelectReopenOptionforClosedOpportunities()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ReopenoptionforClosedOpportunities)))
                {
                    ReopenoptionforClosedOpportunities.Click();
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

        //Closed won opportunity

        public void ClickonAgainBilltoexpandicon()
        {
            SUT.Web.WebDriver.Navigate().Refresh();
            Thread.Sleep(10000);
            SUT.Log.DebugFormat("Page is refreshed");
        }


        public void ClickOnCloseWonOption()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickCloseWonOption)))
                {
                    ClickCloseWonOption.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Close lost option is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close lost option is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close lost option is not clicked");
            }
        }

        public void ClickOnCloseFormManagerButton()
        {
            SUT.Web.WebDriver.SwitchTo().DefaultContent();
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickCloseFormmanagerButton),TimeSpan.FromSeconds(5)))
            {
               
                ClickCloseFormmanagerButton.Click();
                SUT.Log.DebugFormat("Complete button is clicked");
            }
            else
            {
                SUT.Log.ErrorFormat("Complete button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
            }
        }

        public void ClickonOpportunitiesLInkinLeadsPage()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOpportunitiesLinkInLeadsPage)))
                {
                    ClickOpportunitiesLinkInLeadsPage.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Opportunities link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunities link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunities link is not clicked");
            }
        }

        public void IsCloseWonOpportunitySliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CloseWonOpportunitySliderDisplayed)))
                {
                    CloseWonOpportunitySliderDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Close won opportunity slider is displayed ");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close won opportunity slider is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close won opportunity slider is not displayed");
            }
        }

        public void ClickonSubmitButtonInCloseWOnOpportunitySlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSubmitButtonInCloseWOnOpportunitySlider)))
                {
                    ClickSubmitButtonInCloseWOnOpportunitySlider.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Submit button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Submit button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Submit button is not clicked");
            }
        }

        public void SelecttheTech1Details()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickTech1Field)))
                {
                 //   SalesCenterUtility.ScrollToElement(ClickTech1Field);
                    ClickTech1Field.Click();
                    Thread.Sleep(1000);
                    SelectTech1Name.Click();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Technician selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Technician is selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Technician is selected from the droddown");
            }
        }

        public void SelecttheTech2Details()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickTech2Field)))
                {
                    //   SalesCenterUtility.ScrollToElement(ClickTech1Field);
                    ClickTech2Field.Click();
                    Thread.Sleep(1000);
                    SelectTech2Name.Click();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Technician is selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Technician is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Technician is not selected from the droddown");
            }
        }

        public void SelecttheSales1Details()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickSales1Field)))
                {
                    ClickSales1Field.Click();
                    Thread.Sleep(1000);
                    SelectSales1Name.Click();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Sales user name  selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales user name  is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales user name  is not selected from the droddown");
            }
        }

        public void SelecttheSales2Details()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickSales2Field)))
                {
                    ClickSales2Field.Click();
                    Thread.Sleep(1000);
                    SelectSales2Name.Click();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Sales user name  selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales user name  is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales user name  is not selected from the droddown");
            }
        }

        public void EnterSalesNote(string salesnote)
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SalesNote)))
                {
                    SalesNote.Click();
                    SalesNote.Clear();
                    SalesNote.SendKeys(salesnote);
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Sales note is entered");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales note is not entered {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales note is not entered ");
            }
        }

    //Enter the card details

    public void ClickonCaptureCardButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCaptureCardButton)))
                {              
                    ClickCaptureCardButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Opportunities link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunities link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunities link is not clicked");
            }
        }

        public void IsCardNameEntered(string name)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => EnterCardName)))
                {
                    EnterCardName.SendKeys(name);                  
                    SUT.Log.DebugFormat("Card name is entered");
                }
                else
                {
                    SUT.Log.ErrorFormat("Card name is not entered {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Card name is not entered");
            }
        }

        public void ClickOnEnterButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickEnterButton)))
                {
                    ClickEnterButton.Click();
                    Thread.Sleep(15000);
                    SUT.Log.DebugFormat("Enter button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Enter button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Enter button is not clicked");
            }
        }

        public void ClickOnServiceExpandIconForMatchedOpportunity()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickServiceExapndIconForMatchedOpportunity)))
                {
                    ClickServiceExapndIconForMatchedOpportunity.Click();
                    Thread.Sleep(5000);
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

        public void EnterCardNumber(string cardnumber)
        {
            SUT.Web.WebDriver.SwitchTo().Frame(IframeName);
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => CardNumber)))
            {
                SUT.Log.Debug("Safely switched to the payment iFrame");               
                    CardNumber.Click();
                    CardNumber.SendKeys(cardnumber);
                    SUT.Log.DebugFormat("Card number is entered");
           }  
        }

       
        public void EnterthedateandYear()
            
        {

            SelectElement month = new SelectElement(selmonth);
            month.SelectByIndex(3);
            Thread.Sleep(2000);

            SelectElement year = new SelectElement(selyear);
            year.SelectByIndex(5);
            Thread.Sleep(1000);
        }

        public void ClickOnAddCreditCardButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddcreditCardButton)))
                {
                    ClickAddcreditCardButton.Click();
                    Thread.Sleep(13000);
                    SUT.Log.DebugFormat("Add credit card button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add credit card button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add credit card button is not clicked");
            }
        }

        //Reassign sales team

        public void ClickOnReassignButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickReassignButton)))
                {
                    ClickReassignButton.Click();
                    SUT.Log.DebugFormat("Reassign button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reassign button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reassign button is not clicked");
            }
        }

        public void IsReassignSliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ReassignSliderIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    ReassignSliderIsDisplayed.Displayed.ToString();
                    Thread.Sleep(8000);
                    SUT.Log.DebugFormat("Reassign slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reassign slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reassign slider is not diplayed");
            }
        }

        public void SelectSalesTeamInReassignSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesTeamField)))
                {
                    ClickSalesTeamField.Click();
                    SalesTeamNameInReassignSlider.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Sales team is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team is not selected");
            }
        }

        public void SelectSalesTeamMemberInReassignSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesTeamMemberField)))
                {
                    ClickSalesTeamMemberField.Click();
                    SalesTeamMemberInReassignSlider.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Sales team member is assigned");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team member is not assigned {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team member is not assigned");
            }
        }

        public void IsCloseRequirementMissingPopupDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CloseRequirementMissingPopup)))
                {
                    CloseRequirementMissingPopup.Displayed.ToString();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Close requirements missing popup is displayed ");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close requirements missing popup is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close requirements missing popup is not displayed");
            }
        }

        public void ClickOnCloseButtonInPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCloseButton)))
                {
                    ClickCloseButton.Click();
                    SUT.Log.DebugFormat("Close button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close button is not clicked{0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close button is not clicked");
            }
        }

        //Removing SC contacts

        public void ClickOnViewContactsLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickViewContactsLink)))
                {
                    ClickViewContactsLink.Click();
                    SUT.Log.DebugFormat("View Contacts link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View Contacts link is not clicked{0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View Contacts link is not clicked");
            }
        }

        public void ContactPageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ContactPageDisplayed), TimeSpan.FromSeconds(4)))
                {
                    ContactPageDisplayed.Displayed.ToString();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Contact page is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Contact page is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Contact page is not diplayed");
            }
        }

        public void ClickOnAddContactButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddContactButton)))
                {
                    ClickAddContactButton.Click();
                    SUT.Log.DebugFormat("Add contact button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add contact button is not clicked{0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add contact button is not clicked");
            }
        }

        public void IsAddContactSliderIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => AddOpportunityPageIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    AddOpportunityPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Add contact slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add contact slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add contact slider is not diplayed");
            }
        }

        public void ClickOnSearchiconInContactSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSearchIconInContactSlider)))
                {
                    ClickSearchIconInContactSlider.Click();
                    SUT.Log.DebugFormat("Search icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Search icon is not clicked{0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Search icon is not clicked");
            }
        }

        public void EnterTheExistingContactName(string contactname)
        {
            Searchfield.SendKeys(contactname);
            Searchfield.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
           
        }

        public void ClickOnAddContactButtonInContactSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickAddContactButtonInContactSlider)))
                {
                    ClickAddContactButtonInContactSlider.Click();
                    SUT.Log.DebugFormat("Add contact button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add contact button is not clicked{0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add contact button is not clicked");
            }
        }

        public void ClickOnThreeDotsIconforAddedContacts()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsforContacts)))
                {
                    SalesCenterUtility.ScrollToElement(ClickThreeDotsforContacts);
                    ClickThreeDotsforContacts.Click();
                    Thread.Sleep(2000);
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

        public void ClickOnRemoveLinkforContacts()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickRemoveLinkForContacts)))
                {
                    ClickRemoveLinkForContacts.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Remove link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Remove link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Remove link is not clicked");
            }
        }

        public void ClickOnRemoveButtonInPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickRemoveButtonInPopup)))
                {
                    ClickRemoveButtonInPopup.Click();
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

        public void ClickOnRemoveButtonInWorkWavePopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickRemoveButtonInWorkWavePopup)))
                {
                    ClickRemoveButtonInWorkWavePopup.Click();
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

        public void ClickOnEditLinkforContacts()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickEditLinkForContacts)))
                {
                    ClickEditLinkForContacts.Click();
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

        public bool EnterEmailId(string emailid)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => EmailId)))
                {
                    EmailId.Click();
                    EmailId.Clear();
                    EmailId.SendKeys(emailid);
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

        public bool EnterPhoneNumber(string phonenumber)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PhoneNumber)))
                {
                    PhoneNumber.Click();
                    PhoneNumber.Clear();
                    PhoneNumber.SendKeys(phonenumber);
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


        public void ClickOnUpdateButtonInAddContactSlider()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickUpdateButtonInAddContactSlider)))
                {
                    ClickUpdateButtonInAddContactSlider.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Update  button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Update  button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Update  button is not sclicked");
            }
        }

        public void ClickOnThreeDotsIconforUpdatedContacts()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsforUpdatedContacts)))
                {
                    ClickThreeDotsforUpdatedContacts.Click();
                    Thread.Sleep(2000);
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

        public void ClickOnWorkWaveContactsLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickWorkWaveContactsLink)))
                {
                    ClickWorkWaveContactsLink.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Workwave contact link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Workwave contact link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Workwave contact link is not clicked ");
            }
        }

        //Create SC contacts for opp

        public void ClickOnAddNewContactTab()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddNewContactTab)))
                {
                    ClickAddNewContactTab.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Add new contact tab is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add new contact tab is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add new contact tab is not clicked ");
            }
        }

        public bool EnterFirstName(string firstname)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => FirstName)))
                {
                    FirstName.Click();
                    FirstName.Clear();
                    FirstName.SendKeys(firstname);
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

        public bool EnterLastName(string lastname)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LastName)))
                {
                    LastName.Click();
                    LastName.Clear();
                    LastName.SendKeys(lastname);
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

        public bool EnterCompanyName(string companyname)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CompanyName)))
                {
                    CompanyName.Click();
                    CompanyName.Clear();
                    CompanyName.SendKeys(companyname);
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


        public void ClickOnCreateContactButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCreateContactButton)))
                {
                    SalesCenterUtility.ScrollToElement(ClickCreateContactButton);
                    ClickCreateContactButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Create contact button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create contact button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create contact button is not clicked ");
            }
        }

        //Verify the contact name

        public void ClickOnPrimaryContactRadioButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickPrimaryContactRadioButton)))
                {
                    ClickPrimaryContactRadioButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Primary contact radio button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Primary contact radio button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Primary contact radio button is not clicked ");
            }
        }

        public void ClickOnCloseButtonInContactsPage()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCloseButtonInContactsPage)))
                {
                    ClickCloseButtonInContactsPage.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Close button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close button is not clicked");
            }
        }

        public bool VerifyPrimaryContactName_isDisplayed()
        {

            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PrimaryContactName)))
                {
                    SUT.Log.DebugFormat("Primary contact name: {0}", PrimaryContactName.Text);
                    if (PrimaryContactName.Text.Equals(PrimaryContactText))
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
            catch (Exception)
            {

                throw;
            }
        }

        public void SelectOtherPrimaryContactRadioButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => OtherPrimaryContactRadioButton)))
                {
                    OtherPrimaryContactRadioButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Primary contact radio button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Primary contact radio button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Primary contact radio button is not clicked ");
            }
        }

        //Push WWM contacts to pp contacts

        public void ClickOnSendTopestPaclocationlink()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSendTopestPaclocationlink)))
                {
                    ClickSendTopestPaclocationlink.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Send to pestpac location link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Send to pestpac location link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Send to pestpac location link is not clicked");
            }
        }

        public void ClickOnPestPacTab()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickPestPacTab)))
                {
                    ClickPestPacTab.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Pestpac tab is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Pestpac tab is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Pestpac tab is not clicked");
            }
        }

        public void ClickOnAddNoteButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddNoteButton)))
                {
                    ClickAddNoteButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Add note button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add note button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add note button is not clicked");
            }
        }

        public void IsAddNoteSliderIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => AddNoteSLiderIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    AddNoteSLiderIsDisplayed.Displayed.ToString();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Add note slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add note slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add note slider is not diplayed");
            }
        }

        public void EnterNoteTitle(string title)
        {
            Title.Click();
            Title.SendKeys(title);
            Thread.Sleep(1000);
        }

        public void EnterNote(string note)
        {         
            Note.Click();
            Note.SendKeys(note);
            Thread.Sleep(1000);         
        }

        public void ClickOnThreeDotsIconforAddedNotes()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconforAddedNotes)))
                {
                    SalesCenterUtility.ScrollToElement(ClickThreeDotsIconforAddedNotes);
                    ClickThreeDotsIconforAddedNotes.Click();
                    Thread.Sleep(2000);
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

        public void ClickOnEditLinkforNotes()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickEditLinkforNotes)))
                {
                    ClickEditLinkforNotes.Click();
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

        public bool UpdateNotesDetail(string notesdetail)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdateNote)))
                {
                    UpdateNote.SendKeys(Keys.Control + "a");
                    UpdateNote.SendKeys(Keys.Delete);
                    UpdateNote.SendKeys(notesdetail);
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

        public void ClickOnDeleteOptionforNotes()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteOptionforNotes)))
                {
                    ClickDeleteOptionforNotes.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delete option is clicked");
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

        public void ClickOnCancelButtonInNotesDeletePopup()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCancelButtonInNotesDeletePopup)))
                {
                    ClickCancelButtonInNotesDeletePopup.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Cancel button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Cancel button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Cancel button is not clicked");
            }
        }

        public void ClickOnDeleteButtonInNotesDeletePopup()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteButtonInNotesDeletePopup)))
                {
                    ClickDeleteButtonInNotesDeletePopup.Click();
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

        public void ClickOnThreeDotsIcontoDeleteNotes()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIcontoDeleteNotes)))
                {
                    SalesCenterUtility.ScrollToElement(ClickThreeDotsIcontoDeleteNotes);
                    ClickThreeDotsIcontoDeleteNotes.Click();
                    Thread.Sleep(2000);
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

        //Delete opportunity card

        public void ClickOnThreeDotsIconforOpportunityCard()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconforOpportunityCard)))
                {
                    ClickThreeDotsIconforOpportunityCard.Click();
                    Thread.Sleep(2000);
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

        public void ClickOnDeleteLinkforOpportunityCard()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteLinkforOpportunityCard)))
                {
                    ClickDeleteLinkforOpportunityCard.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delete option is clicked");
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

        public void ClickOnDeleteButtonInOpportunityDeletePopup()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteButtonInOpportunityDeletePopup)))
                {
                    ClickDeleteButtonInOpportunityDeletePopup.Click();
                    Thread.Sleep(4000);
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

        //Delete already added service

        public void ClickOnServiceExpandIconForOpportunity()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceExpandIconForOpportunity)))
                {
                    ClickServiceExpandIconForOpportunity.Click();
                    Thread.Sleep(3000);
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

        public void ClickOnThreeDotsIconforaddedService()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickThreeDotsIconforaddedService)))
                {
                    ClickThreeDotsIconforaddedService.Click();
                    Thread.Sleep(2000);
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

        public void ClickOnDeleteLinkOptionforAddedService()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteLinkOptionforAddedService)))
                {
                    ClickDeleteLinkOptionforAddedService.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delete option is clicked");
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

        public void ClickOnDeleteButtonInDeleteServicePopup()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteButtonInDeleteServicePopup)))
                {
                    ClickDeleteButtonInDeleteServicePopup.Click();
                    Thread.Sleep(4000);
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

        public void SelectTheServiceFromDropDown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOtherServiceField)))
                {
                    ClickOtherServiceField.Click();
                    Thread.Sleep(2000);
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

        public void SelectTheOtherServiceFromDropDown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOtherServiceField)))
                {
                    ClickOtherServiceField.Click();
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

        //Switch to formmanager

        public void ClickOnCompleteFormButton()
        {
            if (SalesCenterUtility.Frame_SafeSwitch(IframeCompleteForm, () => ClickCompleteFormButton, 10))
            {
                SUT.Log.Debug("Safely switched to the payment iFrame");
                ClickCompleteFormButton.Click();
                Thread.Sleep(4000);
                SUT.Log.DebugFormat("Complete form button is clicked");
            }
        }

        public void ClickOnSendFormandNotifyFormButton()
        {
            if (SalesCenterUtility.Frame_SafeSwitch(IframeCompleteForm, () => ClickSendFormandNotifyFormButton, 10))
            {
                SUT.Log.Debug("Safely switched to the payment iFrame");
                ClickSendFormandNotifyFormButton.Click();
                Thread.Sleep(2000);

                SUT.Log.DebugFormat("Send form and notify button is clicked");
            }
        }


        //Not able to send additionl contracts for closed won opp

        public void MouseHoverOnSendContractsButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => MouseHoverSendContractsButton)))
                {
                    SalesCenterUtility.ScrollToElement(MouseHoverSendContractsButton);
                    Thread.Sleep(2000);
                    Assert.AreEqual(false, MouseHoverSendContractsButton.Enabled);
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Capture card button is disabled");
                }
                else
                {
                    Assert.AreEqual(true, MouseHoverSendContractsButton.Enabled);
                    SUT.Log.ErrorFormat("Capture card button is enabled {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Capture card button is enabled");
            }
        }

        //Not able to add,edit and delete the services for closed won app

        public void MouseHoverOnAddServiceButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => MouseHoverAddServiceButton)))
                {
                    SalesCenterUtility.ScrollToElement(MouseHoverAddServiceButton);
                    Thread.Sleep(2000);
                    Assert.AreEqual(false, MouseHoverAddServiceButton.Enabled);
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Capture card button is disabled");
                }
                else
                {
                    Assert.AreEqual(true, MouseHoverAddServiceButton.Enabled);
                    SUT.Log.ErrorFormat("Capture card button is enabled {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Capture card button is enabled");
            }
        }

        public void ClickOnViewServicesAddedLink()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickViewServicesAddedLink)))
                {
                    ClickViewServicesAddedLink.Click();
                    Thread.Sleep(4000);
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

        public void TryToClickOnAddAdditionalServiceOrProductButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => TryToClickAddAdditionalServiceOrProductButton)))
                {
                   // SalesCenterUtility.ScrollToElement(MouseHoverAddServiceButton);
                    Thread.Sleep(2000);
                    Assert.AreEqual(false, TryToClickAddAdditionalServiceOrProductButton.Enabled);
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Add additional service or product button is disabled");
                }
                else
                {
                    Assert.AreEqual(true, TryToClickAddAdditionalServiceOrProductButton.Enabled);
                    SUT.Log.ErrorFormat("Capture card button is enabled {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add additional service or product button is enabled");
            }
        }

        public void TryToEditAndDeleteTheServices()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => EditAndDeleteServices)))
                {
                    // SalesCenterUtility.ScrollToElement(MouseHoverAddServiceButton);
                    Thread.Sleep(2000);
                    Assert.AreEqual(false, EditAndDeleteServices.Enabled);
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Edit and delete option is disabled");
                }
                else
                {
                    Assert.AreEqual(true, EditAndDeleteServices.Enabled);
                    SUT.Log.ErrorFormat("Edit and delete option is enabled {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Edit and delete option is enabled");
            }
        }

        //Send contract form to the customer


        public void IsInstructionPageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => InstructionPageIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    InstructionPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Add contact slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add contact slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add contact slider is not diplayed");
            }
        }

        public void ClickOnDepartmentRadioButton()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickDepartmentRadioButton)))
                {
                    ClickDepartmentRadioButton.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Department radio button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Department radio button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Department radio button is not clicked");
            }
        }


        public void ClickOnSalesCenterUserExpandButton()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesCenterUserExpandButton)))
                {
                    ClickSalesCenterUserExpandButton.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Sales center user expand icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales center user expand icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales center user expand icon is not clicked");
            }
        }

        public void SelectMailIdUserCheckBox()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => MailIdUserCheckBox)))
                {
                    MailIdUserCheckBox.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("User mail id checkbox is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("User mail id checkbox is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("User mail id checkbox is not selected");
            }
        }

        //add a contract to an opportunity

        public void ClickOnViewContractsLink()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickViewContractsLink)))
                {
                   
                    ClickViewContractsLink.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("View Contracts link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View Contracts link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View Contracts link is not clicked");
            }
        }

        public void ClickOnCloseIconInContractSlider()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCloseIconInContractSlider)))
                {
                    ClickCloseIconInContractSlider.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Close icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close icon is not clicked");
            }
        }

        private readonly string ContractFormText = "Opportunities";

        public bool IsSameContractFormDisplayedInViewDetailsPage()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ContratForm), TimeSpan.FromSeconds(15)))
            {
                if (PageHeader.Text.TrimStart().StartsWith(ContractFormText))
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

        //Switch back to default content

        public void VerifyCardAddedConfirmMsg(string message)
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CardAddedConfirm_Txt), TimeSpan.FromSeconds(15)))
                {
                    SUT.Log.Debug("Validation  message is displayed");
                    Assert.True(CardAddedConfirm_Txt.Text.Contains(message), "Validation message is not matching");
                   
                }
                else
                {
                    SUT.Log.Debug("Validation message is displayed");
                    
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close icon is not clicked");
            }
        }

        //Track B scenario

        public void ClickOnConvertOpportunityButtonAfterMatchingTheLocation()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickConvertOpportunityButtonAfterMatchingTheLocation)))
                {
                    ClickConvertOpportunityButtonAfterMatchingTheLocation.Click();
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

        //Closing requirements count

        public void IsServiceCountDisplayedInManageServicesPage()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ServiceCountDisplayedInManageServicesPage)))
                {
                    string text = ServiceCountDisplayedInManageServicesPage.Text;

                    Regex re = new Regex(@"[0-9]+");

                    var match = re.Matches(text);
                    foreach (Match m in match)
                    {
                        Console.WriteLine("Service count is:::" + m.Value);
                    }

                    SUT.Log.DebugFormat("Service count is Displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service count is not Displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service count is not Displayed");
            }
        }

        public bool IsPaymentAddedMessageIsDisplayed()
        {

            SUT.Web.WebDriver.SwitchTo().ParentFrame();

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PaymentAddedMessageIsDisplayed),TimeSpan.FromSeconds(10)))
            {
                if (PaymentAddedMessageIsDisplayed.Text.Contains("Successfully added payment method."))
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




    }
}
