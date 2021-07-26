using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class ReleaseCCBilling
    {
        public string CreditCardOrACHRecord { get; set; }
        public string BillDate { get; set; }
        public string BeginningBillDate { get; set; }
        public string EndingBillDate { get; set; }
        public string BatchNumber { get; set; }
        public string LatestBatchReleaseResult { get; set; }
        public string AvailabilityOfPaymentMethod { get; set; }
    }
}
