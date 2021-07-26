using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class CCAutomation
    {
        public string CCAutomation_Name { get; set; }
        public string CCAutomation_ScheduleType { get; set; }
        public string CCAutomation_ScheduleTime { get; set; }
        //FIX: could be multiple DAYS
        public string CCAutomation_ScheduleDay { get; set; }
        //FIX: could be multiple BRANCHES
        public string CCAutomation_Branch { get; set; }
        public string CCAutomation_TransactionAmtMin { get; set; }
        public string CCAutomation_TransactionAmtMax { get; set; }
        public string CCAutomation_ChargeAttempts { get; set; }
        public string CCAutomation_DaysBetweenChargeAttempts { get; set; }
        public string CCAutomation_EndingBillDate { get; set; }
        public string CCAutomation_EmailCreditCardReceipt { get; set; }
        public string CCAutomation_EmailDeclinedTransactionReceipts { get; set; }
        public string CCAutomation_PaymentAutoRelease { get; set; }
        public string ChangeLogReport_FetchedLatestJobScheduleCode { get; set; }
        public int WaitTime_PPSXB { get; set; }
        public int WaitTime_PPTXB { get; set; }
    }
}