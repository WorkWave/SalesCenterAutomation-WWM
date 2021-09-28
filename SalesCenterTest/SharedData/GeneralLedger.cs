namespace WorkWave.PestPac.TA.SharedData
{
    public class GeneralLedger
    {
        public string UseGeneralLedger { get; set; }
        public string DefaultGLCode { get; set; }
        public string GL_SuspenseAccount { get; set; }
        public string Default_PaymentGLCode_FromMOP { get; set; }
        public string SalesCodeSource { get; set; }

        #region New GL Code Data

        public string GLCode { get; set; }
        public string SalesAccount { get; set; }
        public string ARAccount { get; set; }
        public string CashAccount { get; set; }
        public string SalesTaxAccount { get; set; }
        public string DiscountAccount { get; set; }
        public string Description { get; set; }

        #endregion New GL Code Data

        #region Release GL Batch Data

        public string GLBatch_StartDate { get; set; }
        public string GLBatch_EndDate { get; set; }
        public string GLBatch_Show { get; set; }
        public string GLBatch_Include { get; set; }
        public string ReportOnly { get; set; }
        public string ExpectedSalesAccount_Amount { get; set; }
        public string ExpectedARAccount_Amount { get; set; }
        public string ExpectedCashAccount_Amount { get; set; }
        public string ExpectedSalesTaxAccount_Amount { get; set; }
        public string ExpectedDiscountAccount_Amount { get; set; }
        public string GLAccountAndAmount_TextFile { get; set; }

        #endregion Release GL Batch Data

        public string InitialGLCode { get; set; }
    }
}