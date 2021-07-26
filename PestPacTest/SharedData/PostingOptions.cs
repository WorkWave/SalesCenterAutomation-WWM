using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class PostingOptions
    {
        public string GLCodes { get; set; }
        public string ServicePrice { get; set; }

        public string Batch { get; set; }
        public string Batch_Total { get; set; }
        public string NewOrExisting_PaymentMethod { get; set; }
        public string Batch_PaymentRecordCount { get; set; }

        #region Payment Entry - Payment Remains Unapplied Modal

        public string CancelButton_Availability { get; set; }
        public string CreateFinanceChargesButton_Availability { get; set; }
        public string LeaveAsAnOpenCreditButton_Availability { get; set; }

        #endregion Payment Entry - Payment Remains Unapplied Modal

        public bool TrainingForThisScreenLink_Availability { get; set; }
        public string PaymentEntry_ExpectedServicesInDropDown { get; set; }
        public string PaymentEntry_UnavailableServicesInDropDown { get; set; }
        public string Prepayments { get; set; }
        public string Prepayments_ServiceSetupServiceCode { get; set; }
        public string Prepayments_ApplyAmount { get; set; }
        public string Prepayments_Discount { get; set; }
        public string Prepayments_AcceptExceededDiscount { get; set; }
        public string RenewalPrepayments { get; set; }
        public string RenewalPrepayments_RenewalService { get; set; }
        public string RenewalPrepayments_CreateInvoice { get; set; }
        public string RenewalPrepayments_CreateServiceOrder { get; set; }
        public string RenewalPrepayments_WorkDate { get; set; }
        public string RenewalPrepayments_WorkTime { get; set; }
        public string RenewalPrepayments_Duration { get; set; }

    }
}
