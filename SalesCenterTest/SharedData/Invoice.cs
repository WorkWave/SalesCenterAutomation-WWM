namespace WorkWave.PestPac.TA.SharedData
{
    public class Invoice
    {
        public string InvoiceNumber { get; set; }
        public string InvoiceNumber1 { get; set; }
        public string InvoiceNumber2 { get; set; }
        public string InvoiceServicePrice { get; set; }
        public string InvoiceTechComment { get; set; }
        public string InvoiceLocationName { get; set; }
        public string InvoiceEmail { get; set; }
        public string ExpectedCommissionTech1 { get; set; }
        public string ExpectedCommissionTech2 { get; set; }
        public string ExpectedCommissionSales1 { get; set; }
        public string ExpectedCommissionSales2 { get; set; }
        public string Tech1Bonus { get; set; }
        public string Sales1Bonus { get; set; }
        public string ExpectedTech1Bonus { get; set; }
        public string ExpectedSales1Bonus { get; set; }
        public string Tech2Bonus { get; set; }
        public string Sales2Bonus { get; set; }
        public string ExpectedTech2Bonus { get; set; }
        public string ExpectedSales2Bonus { get; set; }
        public string MaterialCode { get; set; }
        public string InvoiceDate { get; set; }
        public string URLContains { get; set; }
        public string GLCode { get; set; }
        public string InvoiceStartDate { get; set; }
        public string InvoiceEndDate { get; set; }

        public string QuickSearch { get; set; }
        public string SelectCustomersTo { get; set; }
        public string Include_BillTosWithAutomatedEmailing { get; set; }
    }
}