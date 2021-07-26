using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class GenerateServiceOrders
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string StartingLocationCode { get; set; }
        public string EndingLocationCode { get; set; }
        public string ReportOnly { get; set; }
        public string SetInvoiceDateFrom { get; set; }
        public string UserEnteredDateFrom { get; set; }

    }
}
