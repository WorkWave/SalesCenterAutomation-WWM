using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class NewAccountDefaults
    {
        public string Default_BlankBranch { get; set; }
        public string Default_MethodOfPayment { get; set; }
        public bool? BillToPrintStatement { get; set; }
        public bool? BillToPrintInvoice { get; set; }
        public bool? BillToEmailStatement { get; set; }
        public bool? BillToEmailInvoice { get; set; }
        public bool? BillToAutomatedEmailsInspectionReport { get; set; }
        public bool? BillToAutomatedEmailsInvoice { get; set; }
        public bool? LocationBatchPrint { get; set; }
        public bool? LocationBatchEmail { get; set; }
        public bool? LocationReAuthorize { get; set; }
        public string SendInspectionReportOn { get; set; }
    }
}
