namespace WorkWave.PestPac.TA.SharedData
{
    public class CompanySetup
    {
        #region General Options - Additional Features

        public string UseActiveDirectory { get; set; }
        public string DefaultDomain { get; set; }

        #endregion General Options - Additional Features

        #region Payment Options - Payment Screen

        public string DefaultPaymentDateFrom { get; set; }
        public string CreateFinanceChargeOnPaymentEntry { get; set; }
        public string ServiceCode { get; set; }
        public string HideServicesNotAssignedToBillTo { get; set; }
        public string AutoApplyOnPaymentEntry { get; set; }

        #endregion Payment Options - Payment Screen

        #region Service Order/Service Setup - Defaults for New Orders & Setups

        public bool AnnualPrepayDiscount { get; set; }
        public string Discount { get; set; }
        public string DiscountReason { get; set; }
        public bool IncludeTax { get; set; }
        public string UseMultipleTech { get; set; }
        public string UseDecimalUnitPrice { get; set; }
        public string NotificationDays { get; set; }
        public bool NotifyLocationOnByDefault { get; set; }
        public bool NotifyBillToOnByDefault { get; set; }
        public bool PrintNotificationOnByDefault { get; set; }
        public bool EmailNotificationOnByDefault { get; set; }
        public bool CallNotificationOnByDefault { get; set; }
        public bool TextNotificationOnByDefault { get; set; }

        #endregion Service Order/Service Setup - Defaults for New Orders & Setups


        #region Payment Options - Payment Methods

        public string RequireCVV { get; set; }

        public string ACHCheckbox { get; set; }

        public string AllowPreAuthorizationOfCC { get; set; }
        public string ProcessACHThrough { get; set; }
        public string CreditCardUpdater { get; set; }

        #endregion Payment Options - Payment Methods

        #region User defined Fields

        public string Tech3 { get; set; }
        public string Tech1 { get; set; }

        public string Tech4 { get; set; }
        public string Tech5 { get; set; }
        public string Tech3Caption { get; set; }
        public string Tech4Caption { get; set; }
        public string Tech5Caption { get; set; }
        public string TechShare { get; set; }
        public string TechRole { get; set; }

        public string PayOnOne { get; set; }
        public string PayOnTwo { get; set; }
        public string PayOnAlertText { get; set; }
        public string PayOnAlertUpfrontText { get; set; }
        public string PayOnBlank { get; set; }
        public string UseRequiredFields { get; set; }
        public string PromptAssociatedWithLead { get; set; }
        public string Setting { get; set; }

        #endregion User defined Fields

        #region Renewals

        public string PromptForRenewalPrepayment { get; set; }
        public string CreateServiceOrder { get; set; }
        public string RequireWorkDate { get; set; }
        public string RequireService { get; set; }

        #endregion Renewals

        #region Additonal Features - Notes

        public string NotecodeValidation { get; set; }

        #endregion Additonal Features - Notes
    }
}