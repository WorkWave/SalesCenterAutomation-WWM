namespace WorkWave.PestPac.TA.SharedData
{
    public class BillTo
    {
        public string BillToNumber { get; set; }
        public string BillToFirstName { get; set; }
        public string BillToLastName { get; set; }
        public string BillToBalance { get; set; }
        public string BillToCredit { get; set; }
        public string BillToBranch { get; set; }
        public string BillToCompanyName { get; set; }
        public string BillToEmail { get; set; }
        public bool? AutomatedEmailInspectionReports { get; set; }
        public bool? AutomatedEmailInvoices { get; set; }
        public string BillTo_AddressLine1 { get; set; }
        public string BillTo_AddressLine2 { get; set; }
        public string BillTo_ZipCode { get; set; }
        public string BillTo_City { get; set; }
        public string BillTo_State { get; set; }
        public string BillTo_Country { get; set; }
        public string BillTo_columnSortingOrder { get; set; }
        public string BillTo_SortedPaymentMethodAccountTypes { get; set; }
        public string BillTo_SortedPaymentMethodNames { get; set; }
        public string BillTo_SortedPaymentMethodExpirations { get; set; }
        public bool BillTo_Email_None { get; set; }
        public string BillTo_InvoicesPrintOrEmail { get; set; }
        public string BillTo_Statement { get; set; }
    }
}