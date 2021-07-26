using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class PrinterOrEmailSetup
    {
        public string Defaults { get; set; }
        public string Statement_StatementForm { get; set; }
        public string Statement_StandardForm { get; set; }
        public bool Statement_PrintToPDF { get; set; }
        public string StandardInput { get; set; }
        public string setEmailFormatName { get; set; }

        public string InvoiceForm { get; set; }
        public string PrintToPDF { get; set; }
        public string StartBillToCode { get; set; }
        public string EndBillToCode { get; set; }

        public string TechNameCheckbox { get; set; }
        public string Invoice_ManualEmailFormat { get; set; }
        public string PDFBody { get; set; }
        public string HTMLFormat { get; set; }

    }
}
